using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public Draggable.slot typeOfItem = Draggable.slot.ABC;
    public GameObject objectToActivate;
    

    public void OnPointerEnter(PointerEventData pointEnter)
    {

    }

    public void OnPointerExit(PointerEventData pointExit)
    {

    }

	public void OnDrop(PointerEventData dropHere)
    {
        Debug.Log( dropHere.pointerDrag.name + " was Dropped on " + gameObject.name);
        Draggable d = dropHere.pointerDrag.GetComponent<Draggable>();

        if (d != null)
        {
            if (typeOfItem == d.typeOfItem || typeOfItem == Draggable.slot.INVENTORY)
            {
                objectToActivate.SetActive(true);
                d.parentReturn = transform;
            }
        }

    }
}
