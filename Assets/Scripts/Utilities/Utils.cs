using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using URandom = UnityEngine.Random;

public class Utils
{
    public static NormalItem.eNormalType GetRandomNormalType()
    {
        Array values = Enum.GetValues(typeof(NormalItem.eNormalType));
        NormalItem.eNormalType result = (NormalItem.eNormalType)values.GetValue(URandom.Range(0, values.Length));

        return result;
    }

    public static NormalItem.eNormalType GetRandomNormalTypeExcept(NormalItem.eNormalType[] types)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        int rnd = URandom.Range(0, list.Count);
        NormalItem.eNormalType result = list[rnd];

        return result;
    }

    public static NormalItem.eNormalType GetRandomNormalTypeExceptPrioritizeLeast(NormalItem.eNormalType[] types, List<int> appear)
    {
        Dictionary<NormalItem.eNormalType, int> itemAppear = new();

        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        foreach (var type in list)
        {
            itemAppear.Add(type, 0);
        }

        for(int i = 0; i < appear.Count; i++)
        {
            if (!itemAppear.ContainsKey((NormalItem.eNormalType)i)) continue;

            itemAppear[((NormalItem.eNormalType)i)] = appear[i];
        }

        return itemAppear.OrderBy(kvp => kvp.Value).First().Key;
    }
}
