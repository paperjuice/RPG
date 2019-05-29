using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    [SerializeField]
    RectTransform itemIcon;

    InventoryBehaviour inventoryBehaviour;

    private void Awake() {
        inventoryBehaviour =
            GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventoryBehaviour>();
    }

    public void AddToInventory() {
        inventoryBehaviour.AddToSlot(itemIcon);
    }

    public void SugiPUla() {
        Debug.Log("Hello");
    }
}
