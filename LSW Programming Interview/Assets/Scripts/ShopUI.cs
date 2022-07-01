using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    public Transform store;
    public Transform buttonTemplate;
    public float buttonHeigh;

    Vector3 offset;
    int positionIndex = 0;

    void Start()
    {
        FillShop();
        buttonTemplate.gameObject.SetActive(false);
    }

    void FillShop()
    {
        foreach (Transform item in store)
        {
            CreateBuyButton(item);
            positionIndex++;
        }
    }

    void CreateBuyButton(Transform item)
    {
        offset = new Vector3(0, -buttonHeigh, 0) * positionIndex;

        var itemButton = Instantiate(buttonTemplate, buttonTemplate.transform.position + offset, Quaternion.identity, gameObject.transform);

        itemButton.Find("Item Image").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
        itemButton.Find("Item Name Text").GetComponent<TextMeshProUGUI>().SetText(item.name);
        itemButton.Find("Item Price Text").GetComponent<TextMeshProUGUI>().SetText(item.GetComponent<Item>().price.ToString());
    }

}
