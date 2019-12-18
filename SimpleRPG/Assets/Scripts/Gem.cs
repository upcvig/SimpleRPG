using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : Collectable
{
    public override Sprite GetSprite()
    {
        return CollectableList.Instance.gem;
    }

}
