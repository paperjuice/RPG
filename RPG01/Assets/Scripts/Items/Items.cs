using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {
    Item generatedItem = new Item();

    [SerializeField]
    private GameObject UI_Icon;
    private InventoryBehaviour inventoryBehaviour;

    private void Awake() {
        inventoryBehaviour =
            GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventoryBehaviour>();
    }

    void Start() {
        GenerateItemStats();
        UI_Icon.GetComponent<ItemUI>().Item = generatedItem;
    }

    public void AddToInventory() {
        inventoryBehaviour.AddToSlot(UI_Icon);
        gameObject.SetActive(false);
    }

   void GenerateItemStats() {
        int random = Random.Range(1, 3);

        generatedItem.Type = GenerateItemType();

        switch (random) {
            case 1:
                generatedItem.MinDamage = 1;
                break;

            case 2:
                generatedItem.Health = 3.0f;
                break;
        }
    }

    ItemType GenerateItemType() {
        int number = Random.Range(0, 3);
        switch (number) {
            case 0: return ItemType.HEAD;
            case 1: return ItemType.SHOULDERS;
            case 2: return ItemType.CHEST;
            default: return ItemType.HEAD;
        }
    }
}
