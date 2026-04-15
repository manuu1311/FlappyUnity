using UnityEngine;

public class ExplosionManager : MonoBehaviour
{
    public ParticleSystem[] particles;
    public void Explode() {
        foreach(ParticleSystem particle in particles) {
            particle.Play();
        }
    }
}
