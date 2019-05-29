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

    public void AddToSlot(RectTransform itemIcon) {
        Debug.Log("boy");
        foreach(GameObject i in slots) {
            if(i.transform.childCount == 0) {
                itemIcon.SetParent(i.transform);
                itemIcon.localPosition = Vector2.zero;
            }
        }
    }
    
}
