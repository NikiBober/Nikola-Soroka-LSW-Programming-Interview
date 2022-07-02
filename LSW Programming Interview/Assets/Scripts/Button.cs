using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Button : MonoBehaviour
{
    string itemName;
    GameObject item;

    public void Transfer(Transform target)
    {
        //find item by name
        itemName = gameObject.transform.Find("Item Name Text").GetComponent<TextMeshProUGUI>().text;
        item = GameObject.Find(itemName);

        //set as child of player equipment or store
        item.transform.SetParent(target, false);
        
        //delete button
        //Destroy(gameObject);

        //refill shop
        ShopUI.Instance.FillShop();
    }

}
