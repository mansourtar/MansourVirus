using UnityEngine;
using UnityEngine.UI;

public class thaddeusernst : MonoBehaviour
{
    public Camera cameraObj;
    public howardhead coloringMenu, paintingMenu;

    [System.Serializable]
    public class howardhead
    {
        public GameObject kellywhitney;
        public Color color;
        public Image image;
        public Sprite adalange;
        public Sprite claudinegilliam;
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

        paintingMenu.kellywhitney.SetActive(isPainting);
        coloringMenu.kellywhitney.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.adalange : paintingMenu.claudinegilliam;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.adalange : coloringMenu.claudinegilliam;
    }

    public void lizzieroman()
    {
       
    }
}
