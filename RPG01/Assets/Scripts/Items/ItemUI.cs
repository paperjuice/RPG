using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUI : MonoBehaviour
{
    Dictionary<ItemStats, float> stats = new Dictionary<ItemStats, float>();

    public void GetItemStatsForUI(Dictionary<ItemStats, float> statsUI) {
        stats = statsUI;
        Debug.Log(stats[ItemStats.HEALTH]);
    }
}
