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
        foreach(GameObject i in slots) {
            if(i.transform.childCount == 0) {
                SetIconPosition(i, itemIcon);
            }
        }
    }

    void SetIconPosition(GameObject parent, GameObject itemIcon) {
        RectTransform UIIcon = itemIcon.GetComponent<RectTransform>();
        UIIcon.SetParent(parent.transform);
        UIIcon.localPosition = Vector2.zero;
        UIIcon.offsetMax = Vector2.zero;
        UIIcon.offsetMin = Vector2.zero;
    }

}
