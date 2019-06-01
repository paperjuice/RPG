using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    Dictionary<ItemStats, float> stats = new Dictionary<ItemStats, float>();

    [SerializeField]
    private GameObject UI_Icon;
    private InventoryBehaviour inventoryBehaviour;

    private void Awake() {
        inventoryBehaviour =
            GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventoryBehaviour>();
    }

    private void Start() {
        GenerateItemStats();
        UI_Icon.GetComponent<ItemUI>().GetItemStatsForUI(stats);
    }

    public void AddToInventory() {
        inventoryBehaviour.AddToSlot(UI_Icon);
    }

    public void GenerateItemStats() {
        stats.Add(ItemStats.HEALTH, 20);
        stats.Add(ItemStats.MIN_DAMAGE, 1);
        stats.Add(ItemStats.MAX_DAMAGE, 3);
    }
}
