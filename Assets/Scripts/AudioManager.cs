using UnityEngine;

public class AudioManager : MonoBehaviour
{   
    [Header("-----------Audio Sources-----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-----------Audio Clips-----------")]
    public AudioClip backgroundMusic;
    public AudioClip buttonClick;
    public AudioClip death;
    public AudioClip jump;
    public AudioClip point;
    public AudioClip win;
    public AudioClip lose;
    public AudioClip littleTime;
    public AudioClip respawn;

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void PlayWin(AudioClip clip)
    {
        musicSource.Stop();
        musicSource.PlayOneShot(clip);
    }

    public void PlayLose(AudioClip clip)
    {
        musicSource.Stop();
        musicSource.PlayOneShot(clip);
    }
}
