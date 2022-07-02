using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellerController : MonoBehaviour
{

    public GameObject shopCamera;
    public GameObject shopCanvas;
    public GameObject sayCanvas;
    public float sayTime = 1.5f;

    bool isInRange;

    private void OnMouseDown()
    {
        if (isInRange)
        {
            OpenShop(true);
        }
        else
        {
            StartCoroutine(SayComeCloser());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isInRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
    }


    //activate ShopUI canvas and virtual camera that adjusted to follow player and zoom on
    public void OpenShop(bool isShopOpen)
    {
        shopCamera.SetActive(isShopOpen);
        shopCanvas.SetActive(isShopOpen);
    }

    IEnumerator SayComeCloser()
    {
        sayCanvas.SetActive(true);
        yield return new WaitForSeconds(sayTime);
        sayCanvas.SetActive(false);
    }
}
