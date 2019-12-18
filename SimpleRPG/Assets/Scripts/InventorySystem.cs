using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem
{
    private List<Collectable> _lItems;

    public InventorySystem()
    {
        _lItems = new List<Collectable>();
    }
    
    public void Add(Collectable c)
    {
        _lItems.Add(c);
    }
    public void show()
    {
       /* foreach (Collectable l in _lItems)
            Debug.Log(l.name);*/
       
    }
}
