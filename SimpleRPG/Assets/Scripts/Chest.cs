using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Chest : MonoBehaviour, IPointerClickHandler
{
    public Key key;
    public Sprite openChest;
    public bool open;
    public int numCoins;

    private void Awake()
    {
        open = false;
    }
    private void OnEnable()
    {
        key.OnContact += OnOpenChest;

    }

    private void OnDisable()
    {
        key.OnContact -= OnOpenChest;
    }

    private void OnOpenChest()
    {
        open = true;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (open)
            GetComponent<SpriteRenderer>().sprite = openChest;
        
    }
}
