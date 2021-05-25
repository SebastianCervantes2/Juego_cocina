using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ingredient_licuadora : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform_L;
    private CanvasGroup canvasGroup_L;
    public GameObject pos_inicial;
    public Licuadora licuadora;
    private void Awake()
    {
        rectTransform_L = GetComponent<RectTransform>();
        canvasGroup_L = GetComponent<CanvasGroup>();
        licuadora = licuadora.GetComponent<Licuadora>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup_L.blocksRaycasts = false;
        canvasGroup_L.alpha = 0.6f;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup_L.blocksRaycasts = true;
        canvasGroup_L.alpha = 1f;
        if (licuadora.correcto == false)
        {
            GetComponent<RectTransform>().anchoredPosition = pos_inicial.GetComponent<RectTransform>().anchoredPosition;
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform_L.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
}

