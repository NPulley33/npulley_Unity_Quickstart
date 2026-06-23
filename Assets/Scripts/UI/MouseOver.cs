using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    /// <summary>
    /// Percent increase of size when mouse hovers over an UI element (Scale Multiplier / 100 )
    /// </summary>
    [SerializeField] float scaleMultiplier = 0.1f;
    float originalScale; 
    float expandedScale;
    RectTransform rectTransform;

    /// <summary>
    /// If true, the text element of a button will be set to the selected colors on mouse hover & click events, 
    /// much like the button itself. For consistency, copy the "Normal", "Highlighted", & "Pressed" colors for the button componenet
    /// </summary>
    public bool SetTextColor;
    public Color Hover;
    public Color Click;
    public Color Normal;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        originalScale = rectTransform.localScale.x;
        expandedScale = originalScale + scaleMultiplier;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //when mouse is over a UI element, expand it's scale for clarity
        rectTransform.localScale = new Vector3(expandedScale, expandedScale, expandedScale);
        if (SetTextColor) transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Hover;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //when mouse leaves UI element, return to original scale
        rectTransform.localScale = new Vector3(originalScale, originalScale, originalScale);
        if (SetTextColor) transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Normal;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (SetTextColor) transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Click;
    }
}