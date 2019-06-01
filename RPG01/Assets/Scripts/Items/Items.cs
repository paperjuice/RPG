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
        Test();
    }

    public void AddToInventory() {
        inventoryBehaviour.AddToSlot(UI_Icon);
        gameObject.SetActive(false);
    }

    void Test() {
        Debug.Log("hahaha");
    }
    

   void GenerateItemStats() {
        Debug.Log("hwy");
        int random = Random.Range(1, 3);

        switch (random) {
            case 1:
                generatedItem.MinDamage = 1;
                break;

            case 2:
                generatedItem.Health = 3.0f;
                break;
        }

        //Debug.Log("DMG" + generatedItem.MinDamage);
        //Debug.Log("HEALTH" + generatedItem.Health);
    }
}
