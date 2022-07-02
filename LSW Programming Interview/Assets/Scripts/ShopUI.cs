using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    public Transform store;
    public Transform equipment;
    public Transform buttonContainer;
    public Transform buyButtonTemplate;
    public Transform sellButtonTemplate;
    public float buttonHeigh;

    Vector3 offset;
    int positionIndex = 0;

    public static ShopUI Instance;

    void Start()
    {
        Instance = this;

        FillShop();
    }

    public void FillShop()
    {
        foreach (Transform item in buttonContainer)
        {
            Destroy(item.gameObject);
        }


        positionIndex = 0;

        foreach (Transform item in store)
        {
            CreateButton(item, buyButtonTemplate);
            positionIndex++;
        }

        positionIndex = 0;

        foreach (Transform item in equipment)
        {
            CreateButton(item, sellButtonTemplate);
            positionIndex++;
        }

    }

    void CreateButton(Transform item, Transform buttonTemplate)
    {
        offset = new Vector3(0, -buttonHeigh, 0) * positionIndex;

        var itemButton = Instantiate(buttonTemplate, buttonTemplate.transform.position + offset, Quaternion.identity, buttonContainer);

        itemButton.Find("Item Image").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
        itemButton.Find("Item Name Text").GetComponent<TextMeshProUGUI>().SetText(item.name);
        itemButton.Find("Item Price Text").GetComponent<TextMeshProUGUI>().SetText(item.GetComponent<Item>().price.ToString());

        itemButton.gameObject.SetActive(true);
    }

}
