using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject[] slots;

    //TODO: Add this to ItemBehaviour
    public void DeactivateOnButtonPress(GameObject item, KeyCode key) {
        if (Input.GetKeyDown(key) && item != null){
            item.SetActive(false);
        }
    }

    public void AddToSlot(GameObject itemIcon) {
        Debug.Log("boy");
        foreach(GameObject i in slots) {
            if(i.transform.childCount == 0) {
                itemIcon.GetComponent<RectTransform>().SetParent(i.transform);
                itemIcon.GetComponent<RectTransform>().localPosition = Vector2.zero;
            }
        }
    }
    
}
