﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Collectable
{
    public override Sprite GetSprite()
    {
        return CollectableList.Instance.key;
    }
}
