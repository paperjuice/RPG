using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBehaviour : MonoBehaviour
{
    public void DeactivateOnButtonPress(GameObject item, KeyCode key) {
        if (Input.GetKeyDown(key) && item != null){
            item.SetActive(false);
        }
    }


}
