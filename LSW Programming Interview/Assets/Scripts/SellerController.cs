using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellerController : MonoBehaviour
{
    public GameObject store;

    public GameObject shopCamera;
    public GameObject shopCanvas;
    public GameObject sayCanvas;
    public float sayTime = 1.5f;

    bool isInRange;

    private void OnMouseDown()
    {
        foreach (Transform item in store.transform)
        {
            Debug.Log(item.name);
        }

        if (isInRange)
        {
            ZoomCamera();
            OpenShop();
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


    //activate virtual camera that ajusted to follow player and zoom on
    void ZoomCamera()
    {
        shopCamera.SetActive(true);
    }

    void OpenShop()
    {
        shopCanvas.SetActive(true);
    }

    IEnumerator SayComeCloser()
    {
        sayCanvas.SetActive(true);
        yield return new WaitForSeconds(sayTime);
        sayCanvas.SetActive(false);
    }
}
