using UnityEngine;
using UnityEngine.SceneManagement;

public class alexwolfe : MonoBehaviour
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

    public void colleengilliam()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
