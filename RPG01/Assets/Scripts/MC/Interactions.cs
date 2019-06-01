using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    GameObject droppedItem;
    InventoryBehaviour inventoryBehaviour;
    Items items;

    private void Awake() {
        inventoryBehaviour = gameObject.AddComponent<InventoryBehaviour>();
        items = gameObject.AddComponent<Items>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.F)) {
            if(droppedItem != null)
                droppedItem.GetComponent<Items>().AddToInventory();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Item") {
            droppedItem = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.tag == "Item") {
            droppedItem = null;
        }
    }
}
