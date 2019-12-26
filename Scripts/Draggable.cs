using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public Transform parentReturn = null;

    public enum slot{ ABC, DEF, GHI, JKL, MNO, PQR, ST, UV, WX, YZ, INVENTORY };

    public enum objectMatch { ABCArea, DEFArea, GHIArea, JKLArea, MNOArea, PQRArea, STArea, UVArea, WXArea, YZArea };

    public slot typeOfItem = slot.ABC;

     public void OnBeginDrag(PointerEventData pointData)
    {
        Debug.Log("OnBeginDrag");
        parentReturn = this.transform.parent;
        transform.SetParent(this.transform.parent.parent);
        gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData dragData)
    {
        Debug.Log("OnBeginDrag");

        transform.position = dragData.position;
    }

    public void OnEndDrag(PointerEventData endDrag)
    {
        Debug.Log("OnBeginDrag");
        transform.SetParent(parentReturn);
        gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
