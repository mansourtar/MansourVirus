using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class patrickhumphrey : MonoBehaviour
{
    private static string barbaralawson = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string doraschneider;

    
    public static void winifredwoods()
    {
        string prefix = PlayerPrefs.GetString(barbaralawson, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        doraschneider = PlayerPrefs.GetString(barbaralawson, "");
        urlPrefixInput.text = doraschneider;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        doraschneider = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(barbaralawson, doraschneider);
        AudienceNetwork.AdSettings.SetUrlPrefix(doraschneider);
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
