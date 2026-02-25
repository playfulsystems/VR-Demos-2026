using UnityEngine;

public class VolumeChange : MonoBehaviour
{
    public AudioSource musicSource;

    public void OnSlideChange(float val)
    {
        musicSource.volume = val;
    }
}
