using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Licuadora : MonoBehaviour, IDropHandler
{
    public GameObject leche_condensada, crema_de_leche, jugo_de_limon, gelatina_disuelta, punto;
    public bool correcto;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {

            if (eventData.pointerDrag == leche_condensada || crema_de_leche || jugo_de_limon || gelatina_disuelta)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = punto.GetComponent<RectTransform>().anchoredPosition;
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
