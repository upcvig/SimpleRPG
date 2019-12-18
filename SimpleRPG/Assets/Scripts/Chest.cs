using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Chest : MonoBehaviour, IPointerClickHandler
{
    public Sprite openChest;
    public bool open;
    public int numCoins;

    public ObjectsColor.ObjectColor chestcolor;

    private void Awake()
    {
        open = false;
    }
 

    public void OnPointerClick(PointerEventData eventData)
    {
        if (open)
            GetComponent<SpriteRenderer>().sprite = openChest;        
    }
}
