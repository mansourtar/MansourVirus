using UnityEngine;
using UnityEngine.SceneManagement;

public class jacobleonard : MonoBehaviour
{
    
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                return;
            }
        }
    }

    public void belindaesquivel()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
