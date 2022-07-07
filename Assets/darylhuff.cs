using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class darylhuff : MonoBehaviour
{

    int johnniestringer;
    AsyncOperation progress = null;
    Image progressBar;
    float meaganpereira = 0;
    string toniaornelas;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + cleobush.nicholemagana.ToString());
        if (cleobush.nicholemagana)
        {
            toniaornelas = "NotiSc";
        }
        else
        {
            toniaornelas = elbertdickerson.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            johnniestringer = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            johnniestringer = 0;
        }
        johnniestringer++;
        PlayerPrefs.SetInt("appStartedNumber", johnniestringer);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (meaganpereira < 5)
        {
            meaganpereira += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + cleobush.nicholemagana.ToString());
        if (cleobush.nicholemagana)
        {
            toniaornelas = "NotiSc";
        }
        else
        {
            toniaornelas = elbertdickerson.Homenamescene;
        }
        SceneManager.LoadScene(toniaornelas);
    }

}
