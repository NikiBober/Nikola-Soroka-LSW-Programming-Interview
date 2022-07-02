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
    public TextMeshProUGUI moneyAmountText;
    public int money;

    Vector3 offset;
    int positionIndex;


    public static ShopUI Instance;
    

    void Start()
    {
        Instance = this;

        FillShop();
    }

    public void FillShop()
    {
        UpdateWallet(0);

        //delete any previosly maded buttons
        foreach (Transform item in buttonContainer)
        {
            Destroy(item.gameObject);
        }

        // generate buy button for each object in Store game object
        positionIndex = 0;
        foreach (Transform item in store)
        {
            CreateButton(item, buyButtonTemplate);
            positionIndex++;
        }

        // generate sell button for each object in Equipment game object
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

    public void UpdateWallet(int amount)
    {
        money += amount;
        moneyAmountText.SetText(money.ToString());
    }
}
