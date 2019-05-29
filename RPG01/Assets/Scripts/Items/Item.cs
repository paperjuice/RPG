using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    ItemBehaviour itemBehaviour;
    GenerateItemStats wtf;

    private void Awake() {
    }

    private void Start() {
        //itemBehaviour = GetComponent<ItemBehaviour>();

        //if (itemBehaviour == null) { Debug.Log("WO"); }
        //itemBehaviour.SugiPUla();
        wtf = GetComponent<GenerateItemStats>();
        wtf.Mergi();
    }

    public void AddToInventory() {
        //itemBehaviour.AddToInventory();
    }

}
