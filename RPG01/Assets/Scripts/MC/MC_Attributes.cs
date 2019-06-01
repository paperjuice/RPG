using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_Attributes : MonoBehaviour
{
    Item head = new Item();
    Item chest = new Item();
    Item belt =  new Item();
    Item pants = new Item();
    Item boots = new Item();
    Item hands = new Item();
    Item shoulders = new Item();
    Item ring = new Item();
    Item necklace = new Item();
    Item mainHand = new Item();
    Item offHand = new Item();

    public float Health { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }

    private void Start() {
        InitialiseAttributes();
    }

    void InitialiseAttributes() {
        Health = 20.0f;
        MinDamage = 0;
        MaxDamage = 0;
    }

    public void EquipItem(Item item) {
        Debug.Log(item.Type);

        switch (item.Type) {
            case ItemType.HEAD:
                AddAttributes(item, head);
                head = item;
                break;

            case ItemType.SHOULDERS:
                AddAttributes(item, shoulders);
                shoulders = item;
                break;

            case ItemType.CHEST:
                AddAttributes(item, chest);
                chest = item;
                break;
        }

        Debug.Log(Health);
        Debug.Log(MinDamage);
    }

    void AddAttributes(Item newItem, Item currentItem) {
        Health = Health - currentItem.Health + newItem.Health;
        MinDamage = MinDamage - currentItem.MinDamage + newItem.MinDamage;
        MaxDamage += MaxDamage - currentItem.MaxDamage + newItem.MaxDamage;
    }

    
}
