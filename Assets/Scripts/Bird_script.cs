using UnityEngine;
using UnityEngine.InputSystem;

public class Bird_script : MonoBehaviour
{
    public Sprite[] wingSprites;
    private SpriteRenderer leftWing;
    private SpriteRenderer rightWing;
    private SpriteRenderer jumpcloud;
    public Rigidbody2D rigidBody;
    public float Flap_str=5f;
    public InputActionReference jump;

    void Awake()
    {
        rightWing = transform.Find("birdwingright").GetComponent<SpriteRenderer>();
        leftWing = transform.Find("birdwingleft").GetComponent<SpriteRenderer>();;
        jumpcloud = transform.Find("birdjumpcloud").GetComponent<SpriteRenderer>();;
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
        Debug.Log("Jump triggered");
        if (context.performed)
        {
            rigidBody.linearVelocity = new Vector2(rigidBody.linearVelocity.x, Flap_str);
        }
    }
}

