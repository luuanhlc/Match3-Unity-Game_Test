using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Ins;
    public DataItem ItemData;

    private void Awake()
    {
        Ins = this;
    }
}
