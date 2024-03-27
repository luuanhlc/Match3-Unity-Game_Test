using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDisplay : MonoBehaviour
{
    [SerializeField] private int Index;
    [SerializeField] private SpriteRenderer item_sprite;

    private void OnValidate()
    {
        item_sprite = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        item_sprite.sprite = ItemManager.Ins.ItemData.Sprite_Item[Index - 1];
    }
}
