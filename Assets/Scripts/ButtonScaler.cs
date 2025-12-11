using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Vector3 original;

    void Start()
    {
        original = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = original * 1.15f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = original;
    }
}
