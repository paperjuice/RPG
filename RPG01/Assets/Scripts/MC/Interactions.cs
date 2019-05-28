using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    GameObject item;
    InventoryBehaviour inventoryBehaviour;

    private void Awake() {
        inventoryBehaviour = gameObject.AddComponent<InventoryBehaviour>();
    }

    void Update() {
        inventoryBehaviour.DeactivateOnButtonPress(
           item,
           KeyCode.F
            );
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Item") {
            item = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.tag == "Item") {
            item = null;
        }
    }
}
