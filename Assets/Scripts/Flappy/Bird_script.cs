using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEditor;
using Unity.Collections;

public class Bird_script : MonoBehaviour
{
    public GameObject cloudPrefab;
    public Sprite[] wingSprites;
    private SpriteRenderer leftWing;
    private SpriteRenderer rightWing;
    private SpriteRenderer jumpcloud;
    public Rigidbody2D rigidBody;
    public float Flap_str=5f;
    public InputActionReference jump;
    private WaitForSeconds flapDelay = new WaitForSeconds(0.4f);
    public SoundManager soundManager;

    void Awake()
    {
        rightWing = transform.Find("birdwingright").GetComponent<SpriteRenderer>();
        leftWing = transform.Find("birdwingleft").GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        // Subscribe to the action
        jump.action.performed += OnJump;
        jump.action.Enable();
    }

    private void OnDisable()
    {
        // Unsubscribe to prevent memory leaks
        jump.action.performed -= OnJump;
        jump.action.Disable();
    }

    // Update is called once per frame
    public void OnJump(InputAction.CallbackContext context)
    {   
        if (context.performed)
        {
            rigidBody.linearVelocity = new Vector2(rigidBody.linearVelocity.x, Flap_str);
            Flap();
            SpawnCloud();
        }
    }

    void SpawnCloud() {
        Vector3 spawnPos = transform.position + new Vector3(0, 0, 1f);
    Instantiate(cloudPrefab, spawnPos, Quaternion.Euler(0, 0, 180));
    }
    void Flap() {
        StartCoroutine(FlapRoutine());
        soundManager.Jump();
    }

    IEnumerator FlapRoutine() {
        leftWing.sprite = wingSprites[1];
        rightWing.sprite = wingSprites[1];
        yield return flapDelay;
        leftWing.sprite = wingSprites[0];
        rightWing.sprite = wingSprites[0];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //do
            FindAnyObjectByType<GameManager>().GameOver();
        }
        else if (collision.gameObject.CompareTag("Scoring"))
        {
            //do
            float rew=collision.gameObject.GetComponent<Score_rew>().rew;
            FindAnyObjectByType<GameManager>().IncreaseScore(rew);
            if (rew > 1) {
             soundManager.StarPickup2();   
            }
            else {
             soundManager.StarPickup1();   
            }
            Destroy(collision.gameObject);
        }
    }
}


