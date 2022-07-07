using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class jesstyler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool lenorefair = false;
    [System.Serializable]
    public class kellylambert : UnityEvent { }
    [SerializeField]
    private kellylambert myOwnEvent = new kellylambert();
    public kellylambert onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, shawnaholder = 1f;
    private Vector3 startPosition, hesteringram;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (lenorefair)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (lenorefair)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator kaitlinluke()
    {
        yield return estherstallings(transform, transform.localPosition, hesteringram, shawnaholder);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float frankielittle = 1.0f / value;
        float kristisparks = 0.0f;
        while (kristisparks < 1.0)
        {
            kristisparks += Time.deltaTime * frankielittle;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, kristisparks));
            yield return null;
        }

        thisTransform.localPosition = hesteringram;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        hesteringram = EPos;

        shawnaholder = MTime;

        StartCoroutine(kaitlinluke());
    }
}
