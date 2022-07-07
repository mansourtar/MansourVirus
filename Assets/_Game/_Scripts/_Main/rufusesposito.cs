using UnityEngine;

public class rufusesposito : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static rufusesposito USE;

    private AudioSource sophiaconley;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            sophiaconley = transform.GetChild(0).GetComponent<AudioSource>();

            charmainewarren();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void charmainewarren()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void wandakoehler()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void lorrainevalentine(AudioClip clip)
    {
        sophiaconley.PlayOneShot(clip);
    }
}
