using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class homermccall : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool jessielacy = false;
    [System.Serializable]
    public class benknowles : UnityEvent { }
    [SerializeField]
    private benknowles myOwnEvent = new benknowles();
    public benknowles onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, avaashley = 1f;
    private Vector3 startPosition, hannahnichols;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (jessielacy)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (jessielacy)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator melissalara()
    {
        yield return estherstallings(transform, transform.localPosition, hannahnichols, avaashley);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float ednazimmer = 1.0f / value;
        float lesleyguzman = 0.0f;
        while (lesleyguzman < 1.0)
        {
            lesleyguzman += Time.deltaTime * ednazimmer;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, lesleyguzman));
            yield return null;
        }

        thisTransform.localPosition = hannahnichols;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        hannahnichols = EPos;

        avaashley = MTime;

        StartCoroutine(melissalara());
    }
}
