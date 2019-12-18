using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableWorld : MonoBehaviour
{
    private Collectable _collectable;
    private SpriteRenderer spriteRenderer;

    public static CollectableWorld spawnCollectable(Vector3 pos, Collectable c)
    {
        Transform item = Instantiate(CollectableList.Instance.PF_CollectableWorld, pos, Quaternion.identity);

        CollectableWorld cret = item.GetComponent<CollectableWorld>();
        cret.setCollectable(c);

        return cret;
    }

    public void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void setCollectable(Collectable c)
    {
        _collectable = c;
        GetComponent<SpriteRenderer>().sprite = _collectable.GetSprite();
    }
}
