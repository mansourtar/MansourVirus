using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class claytonkey : MonoBehaviour
{
    
    void Start()
    {

        chelseysamuel();
    }

    
    bool elainediehl = false;




    void Update()
    {
        if (chrystalbaker.Length > 0 && !elainediehl)
        {
            elainediehl = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + marihorn);

            if (marihorn.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(dalelilly(loriealston, image));
                return;
            }
            else if (teresakeys.Length > 0)
            {
                guillermoblanton.Instance.ShowApplovin();
            }
            else if (erikajensen.Length > 0)
            {
                guillermoblanton.Instance.ShowInterstitialfb();
            }
            else if (paulinecardona.Length > 0)
            {
                guillermoblanton.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(guillermoblanton.Homenamescene);

        }
    }

    string erikajensen = "";
    string loriealston = "";
    string teresakeys = "";
    string paulinecardona = "";
    string marihorn = "";
    string chrystalbaker = "";

    void chelseysamuel()
    {
        FirebaseDatabase.GetInstance(guillermoblanton.firebaselink)
      .GetReference("MyMob")
      .GetValueAsync().ContinueWith(task =>
      {
          if (task.IsFaulted)
          {
              UnityEngine.Debug.Log("XReceived data error ");

          }
          else if (task.IsCompleted)
          {
              DataSnapshot snapshot = task.Result;
              erikajensen = snapshot.Child("NotiFbads").Value.ToString();
              loriealston = snapshot.Child("NotiImg").Value.ToString();
              teresakeys = snapshot.Child("NotiLovin").Value.ToString();
              paulinecardona = snapshot.Child("NotiUnityads").Value.ToString();
              paulinecardona = snapshot.Child("NotiUnityads").Value.ToString();
              marihorn = snapshot.Child("NotiUrl").Value.ToString();
              chrystalbaker = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived loriealston " + loriealston);
              UnityEngine.Debug.Log("XReceived marihorn " + marihorn);

          }
      });

    }

    public void loriebarton()
    {
        Application.OpenURL(marihorn);

    }

    UnityWebRequest www;
    IEnumerator dalelilly(string url, Image targetImage)
    {
        using (www = UnityWebRequestTexture.GetTexture(url))
        {
            
            yield return www.SendWebRequest();

            if (!www.isDone)
            {
                Debug.Log("Error while Receiving: " + www.error);
            }
            else
            {
                Debug.Log("Success");

                
                var texture2d = DownloadHandlerTexture.GetContent(www);
                var sprite = Sprite.Create(texture2d, new Rect(0, 0, texture2d.width, texture2d.height), Vector2.zero);
                targetImage.sprite = sprite;
            }
        }
    }


}
