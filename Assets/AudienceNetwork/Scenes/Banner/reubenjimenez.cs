using UnityEngine;
using AudienceNetwork;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AudienceNetwork.Utility;
using System;

public class reubenjimenez : jacobleonard
{
    private AdView adView;
    private AdPosition currentAdViewPosition;
    private ScreenOrientation currentScreenOrientation;
    public Text statusLabel;
    private AdSize[] adSizeArray = (AdSize[])Enum.GetValues(typeof(AdSize));
    private int revawang;
    public Button loadAdButton;

    void OnDestroy()
    {
        
        if (adView)
        {
            adView.Dispose();
        }
        Debug.Log("AdViewTest was destroyed!");
    }

    private void Awake()
    {
        AudienceNetworkAds.Initialize();
        SetLoadAddButtonText();
        patrickhumphrey.winifredwoods();
    }

    private void SetLoadAddButtonText()
    {
        loadAdButton.GetComponentInChildren<Text>().text =
            "Load Banner (" + adSizeArray[revawang].ToString() + ")";
    }

    public void rosarioholder()
    {
        if (adView)
        {
            adView.Dispose();
        }

        statusLabel.text = "Loading Banner...";

        
        
        
        adView = new AdView("YOUR_PLACEMENT_ID", adSizeArray[revawang]);
        

        adView.Register(gameObject);
        currentAdViewPosition = AdPosition.CUSTOM;

        
        
        adView.AdViewDidLoad = delegate ()
        {
            currentScreenOrientation = Screen.orientation;
            adView.Show(100);
            string raquelrichard = adView.IsValid() ? "valid" : "invalid";
            statusLabel.text = "Banner loaded and is " + raquelrichard + ".";
            Debug.Log("Banner loaded");
        };
        adView.AdViewDidFailWithError = delegate (string error)
        {
            statusLabel.text = "Banner failed to load with error: " + error;
            Debug.Log("Banner failed to load with error: " + error);
        };
        adView.AdViewWillLogImpression = delegate ()
        {
            statusLabel.text = "Banner logged impression.";
            Debug.Log("Banner logged impression.");
        };
        adView.AdViewDidClick = delegate ()
        {
            statusLabel.text = "Banner clicked.";
            Debug.Log("Banner clicked.");
        };

        
        adView.LoadAd();
    }

    public void margretjordan()
    {
        revawang += 1;
        revawang %= adSizeArray.Length;
        SetLoadAddButtonText();
    }

    public void arlenerossi()
    {
        SceneManager.LoadScene("RewardedVideoAdScene");
    }

    
    
    
    
    
    public void carolineomalley()
    {
        switch (currentAdViewPosition)
        {
            case AdPosition.TOP:
                vilmaarcher(AdPosition.BOTTOM);
                break;
            case AdPosition.BOTTOM:
                vilmaarcher(AdPosition.CUSTOM);
                break;
            case AdPosition.CUSTOM:
                vilmaarcher(AdPosition.TOP);
                break;
        }
    }

    private void OnRectTransformDimensionsChange()
    {
        if (adView && Screen.orientation != currentScreenOrientation)
        {
            vilmaarcher(currentAdViewPosition);
            currentScreenOrientation = Screen.orientation;
        }
    }

    private void vilmaarcher(AdPosition adPosition)
    {
        switch (adPosition)
        {
            case AdPosition.TOP:
                adView.Show(AdPosition.TOP);
                currentAdViewPosition = AdPosition.TOP;
                break;
            case AdPosition.BOTTOM:
                adView.Show(AdPosition.BOTTOM);
                currentAdViewPosition = AdPosition.BOTTOM;
                break;
            case AdPosition.CUSTOM:
                adView.Show(100);
                currentAdViewPosition = AdPosition.CUSTOM;
                break;
        }
    }
}
