﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Itemtype
{
    Food,
    Equipment,
    Default
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public Itemtype type;
    [TextArea(15, 20)]
    public string description;

}
