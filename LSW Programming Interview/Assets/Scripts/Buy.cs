using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public Transform playerEquipment;

    string itemName;
    GameObject item;

    public void BuyItem()
    {
        itemName = gameObject.transform.Find("Item Name Text").GetComponent<TextMeshProUGUI>().text;
        item = GameObject.Find(itemName);

        item.transform.SetParent(playerEquipment, false);

        gameObject.SetActive(false);
    }

}
