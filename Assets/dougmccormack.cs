using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class dougmccormack : MonoBehaviour
{

    int donaarnold;
    AsyncOperation progress = null;
    Image progressBar;
    float tiffanymachado = 0;
    string mayraduong;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + jeremysprague.alisapope.ToString());
        if (jeremysprague.alisapope)
        {
            mayraduong = "NotiSc";
        }
        else
        {
            mayraduong = guillermoblanton.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            donaarnold = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            donaarnold = 0;
        }
        donaarnold++;
        PlayerPrefs.SetInt("appStartedNumber", donaarnold);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (tiffanymachado < 5)
        {
            tiffanymachado += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + jeremysprague.alisapope.ToString());
        if (jeremysprague.alisapope)
        {
            mayraduong = "NotiSc";
        }
        else
        {
            mayraduong = guillermoblanton.Homenamescene;
        }
        SceneManager.LoadScene(mayraduong);
    }

}
