using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Taza : MonoBehaviour, IDropHandler
{
    public GameObject punto_mantequilla, punto_galleta, mantequilla, galleta;
    public bool correcto;
    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {

            if (eventData.pointerDrag == galleta)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = punto_galleta.GetComponent<RectTransform>().anchoredPosition;
                correcto = true;
            }
            else if (eventData.pointerDrag == mantequilla)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = punto_mantequilla.GetComponent<RectTransform>().anchoredPosition;
                correcto = true;
            }

            else
            {
                correcto = false;
            }
            return;
        }
    }
}
