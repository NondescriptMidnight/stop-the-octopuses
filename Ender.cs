using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Ender : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public AudioClip wholeSong;
    public Draggable.slot typeOfItem = Draggable.slot.ABC;
    public GameObject[] cannonball;

    public void OnPointerEnter(PointerEventData pointEnter)
    {

    }

    public void OnPointerExit(PointerEventData pointExit)
    {

    }

    public void OnDrop(PointerEventData dropHere)
    {
        Debug.Log(dropHere.pointerDrag.name + " was Dropped on " + gameObject.name);
        Draggable d = dropHere.pointerDrag.GetComponent<Draggable>();

        if (d != null)
        {
            if (typeOfItem == d.typeOfItem || typeOfItem == Draggable.slot.INVENTORY)
            {
                Octomove.isStopped = true;
                Player.isOver = true;
                AudioSource.PlayClipAtPoint(wholeSong, Camera.main.transform.position, 1f);

                d.parentReturn = transform;
                Invoke("Victory", 3f);
            }
        } }
        void Victory(){
        GameObject canv = GameObject.Find("Canvas");
        GameObject one = GameObject.Find("ABC");
        GameObject two = GameObject.Find("DEF");
        GameObject three = GameObject.Find("GHI");
        GameObject four = GameObject.Find("JKL");
        GameObject five = GameObject.Find("MNO");
        GameObject six = GameObject.Find("PQR");
        GameObject seven = GameObject.Find("ST");
        GameObject eight = GameObject.Find("UV");
        GameObject nine = GameObject.Find("WX");
        GameObject ten = GameObject.Find("YZ");
        GameObject shotOne = (GameObject)Instantiate(cannonball[0], one.transform.position, Quaternion.identity);
        GameObject shotTwo = (GameObject)Instantiate(cannonball[1], two.transform.position, Quaternion.identity);
        GameObject shotThree = (GameObject)Instantiate(cannonball[2], three.transform.position, Quaternion.identity);
        GameObject shotFour = (GameObject)Instantiate(cannonball[3], four.transform.position, Quaternion.identity);
        GameObject shotFive = (GameObject)Instantiate(cannonball[4], five.transform.position, Quaternion.identity);
        GameObject shotSix = (GameObject)Instantiate(cannonball[5], six.transform.position, Quaternion.identity);
        GameObject shotSeven = (GameObject)Instantiate(cannonball[6], seven.transform.position, Quaternion.identity);
        GameObject shotEight = (GameObject)Instantiate(cannonball[7], eight.transform.position, Quaternion.identity);
        GameObject shotNine = (GameObject)Instantiate(cannonball[8], nine.transform.position, Quaternion.identity);
        GameObject shotTen = (GameObject)Instantiate(cannonball[9], ten.transform.position, Quaternion.identity);
        shotOne.transform.parent = canv.transform;
        shotTwo.transform.parent = canv.transform;
        shotThree.transform.parent = canv.transform;
        shotFour.transform.parent = canv.transform;
        shotFive.transform.parent = canv.transform;
        shotSix.transform.parent = canv.transform;
        shotSeven.transform.parent = canv.transform;
        shotEight.transform.parent = canv.transform;
        shotNine.transform.parent = canv.transform;
        shotTen.transform.parent = canv.transform;
        Invoke("End", 10f);
        }

    void End()
    {
        Application.LoadLevel(1);
    }
    }
