using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class erniegrimm : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool lawandapack = false;
    [System.Serializable]
    public class damiangoodman : UnityEvent { }
    [SerializeField]
    private damiangoodman myOwnEvent = new damiangoodman();
    public damiangoodman onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, abbiesylvester = 1f;
    private Vector3 startPosition, juliannesalgado;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (lawandapack)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (lawandapack)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator marquitapurcell()
    {
        yield return estherstallings(transform, transform.localPosition, juliannesalgado, abbiesylvester);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float hillarykent = 1.0f / value;
        float emilianorton = 0.0f;
        while (emilianorton < 1.0)
        {
            emilianorton += Time.deltaTime * hillarykent;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, emilianorton));
            yield return null;
        }

        thisTransform.localPosition = juliannesalgado;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        juliannesalgado = EPos;

        abbiesylvester = MTime;

        StartCoroutine(marquitapurcell());
    }
}
