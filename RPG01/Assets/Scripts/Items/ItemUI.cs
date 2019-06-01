using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour {

    private MC_Attributes MC;
    public Item Item { get; set; }

    private void Awake() {
        MC = GameObject.FindGameObjectWithTag("Player").GetComponent<MC_Attributes>();
    }

    public void AddToEquipment() {
        MC.EquipItem(Item);
    }
}
