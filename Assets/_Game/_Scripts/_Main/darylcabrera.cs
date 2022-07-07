using UnityEngine;

public class darylcabrera : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static darylcabrera USE;

    private AudioSource catalinagoldstein;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            catalinagoldstein = transform.GetChild(0).GetComponent<AudioSource>();

            reneechampion();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void reneechampion()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void georginabernard()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void katelynshapiro(AudioClip clip)
    {
        catalinagoldstein.PlayOneShot(clip);
    }
}
