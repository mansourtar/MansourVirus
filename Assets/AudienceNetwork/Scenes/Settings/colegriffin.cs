using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class colegriffin : MonoBehaviour
{
    private static string sierracullen = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string myrnasapp;

    
    public static void winifredwoods()
    {
        string prefix = PlayerPrefs.GetString(sierracullen, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        myrnasapp = PlayerPrefs.GetString(sierracullen, "");
        urlPrefixInput.text = myrnasapp;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        myrnasapp = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(sierracullen, myrnasapp);
        AudienceNetwork.AdSettings.SetUrlPrefix(myrnasapp);
    }

    public void AdViewScene()
    {
        SceneManager.LoadScene("AdViewScene");
    }

    public void InterstitialAdScene()
    {
        SceneManager.LoadScene("InterstitialAdScene");
    }

    public void RewardedVideoAdScene()
    {
        SceneManager.LoadScene("RewardedVideoAdScene");
    }
}
