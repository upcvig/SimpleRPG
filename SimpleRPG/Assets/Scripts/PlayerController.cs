using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    [SerializeField]
    private InventorySystem _inventory;

    private void Awake()
    {
        _inventory = new InventorySystem();
        CollectableWorld.spawnCollectable(new Vector3(-1, -1, 0), new Gem { amount=1});
        CollectableWorld.spawnCollectable(new Vector3(-1, 1, 0), new Key { amount = 1});
    }

    public void AddCollectable(Collectable c)
    {
        _inventory.Add(c);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _inventory.show();
    }

}
