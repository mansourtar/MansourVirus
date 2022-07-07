using UnityEngine;
using UnityEngine.UI;

public class elmerwilliamson : MonoBehaviour
{
    public Camera cameraObj;
    public nicolascurran coloringMenu, paintingMenu;

    [System.Serializable]
    public class nicolascurran
    {
        public GameObject karinmcdowell;
        public Color color;
        public Image image;
        public Sprite lyndasumner;
        public Sprite isabelhinkle;
    }

    void Awake()
    {
        Camera.main.aspect = 16 / 9f;
    }

    void Start()
    {
                OnMenuButtonClicked(false);
    }

    public void OnMenuButtonClicked(bool isPainting)
    {
        PlayerPrefs.SetInt("isPainting", isPainting ? 1 : 0);
        PlayerPrefs.Save();

        paintingMenu.karinmcdowell.SetActive(isPainting);
        coloringMenu.karinmcdowell.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.lyndasumner : paintingMenu.isabelhinkle;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.lyndasumner : coloringMenu.isabelhinkle;
    }

    public void cathypinto()
    {
       
    }
}
