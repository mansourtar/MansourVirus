using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class santoscarlson : MonoBehaviour
{
    
    void Start()
    {

        chelseysamuel();
    }

    
    bool trudygay = false;




    void Update()
    {
        if (nadiaandersen.Length > 0 && !trudygay)
        {
            trudygay = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + harriettlee);

            if (harriettlee.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(joannerudolph(billiegolden, image));
                return;
            }
            else if (guadalupehurtado.Length > 0)
            {
                elbertdickerson.Instance.ShowApplovin();
            }
            else if (milliesutherland.Length > 0)
            {
                elbertdickerson.Instance.ShowInterstitialfb();
            }
            else if (debbiewilliams.Length > 0)
            {
                elbertdickerson.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(elbertdickerson.Homenamescene);

        }
    }

    string milliesutherland = "";
    string billiegolden = "";
    string guadalupehurtado = "";
    string debbiewilliams = "";
    string harriettlee = "";
    string nadiaandersen = "";

    void chelseysamuel()
    {
        FirebaseDatabase.GetInstance(elbertdickerson.firebaselink)
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
              milliesutherland = snapshot.Child("NotiFbads").Value.ToString();
              billiegolden = snapshot.Child("NotiImg").Value.ToString();
              guadalupehurtado = snapshot.Child("NotiLovin").Value.ToString();
              debbiewilliams = snapshot.Child("NotiUnityads").Value.ToString();
              debbiewilliams = snapshot.Child("NotiUnityads").Value.ToString();
              harriettlee = snapshot.Child("NotiUrl").Value.ToString();
              nadiaandersen = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived billiegolden " + billiegolden);
              UnityEngine.Debug.Log("XReceived harriettlee " + harriettlee);

          }
      });

    }

    public void frankierossi()
    {
        Application.OpenURL(harriettlee);

    }

    UnityWebRequest www;
    IEnumerator joannerudolph(string url, Image targetImage)
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
