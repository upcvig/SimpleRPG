using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableList: MonoBehaviour
{
    public static CollectableList Instance { get; private set; }

    public Sprite gem;
    public Sprite key;

    public Transform PF_CollectableWorld;

    public void Awake()
    {
        Instance = this;
    }
 
}
