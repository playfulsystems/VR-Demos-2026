using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
    public AudioSource audioSource;
    int collPointsPlayed = 0;

    void OnCollisionEnter(Collision c)
    {
        if (Time.time < 0.5f) return;       // fix collision on scene start

        audioSource.volume = 1;
        audioSource.Play();
        collPointsPlayed = 1;
    }

    private void OnCollisionStay(Collision c)
    {
        if (Time.time < 0.5f) return;       // fix collision on scene start

        // play sounds when other contacts happen
        if (c.contacts.Length > collPointsPlayed)
        {
            audioSource.volume *= 0.75f;
            audioSource.Play();
            collPointsPlayed++;
        }        
    }
}
