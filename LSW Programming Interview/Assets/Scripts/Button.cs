using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Button : MonoBehaviour
{
    string itemName;
    GameObject item;
    int itemPrice;

    private void Start()
    {
        //find item by name
        itemName = gameObject.transform.Find("Item Name Text").GetComponent<TextMeshProUGUI>().text;
        item = GameObject.Find(itemName);
        itemPrice = item.GetComponent<Item>().price;
    }

    void Transfer(Transform target)
    {
        //set as child of player equipment or store
        item.transform.SetParent(target, false);
        
        //refill shop
        ShopUI.Instance.FillShop();
    }

    public void Buy()
    {
        Transfer(ShopUI.Instance.equipment);
        ShopUI.Instance.UpdateWallet(-itemPrice);
    }

    public void Sell()
    {
        Transfer(ShopUI.Instance.store);
        ShopUI.Instance.UpdateWallet(itemPrice);
    }


}
