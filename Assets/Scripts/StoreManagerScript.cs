using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManagerScript : MonoBehaviour
{
    private Camera mainCamera;
    //this variable is temporary, IDK how or where were actually gonna do the money system
    public int tempMoney;
    private void Start()
    {
        
        mainCamera = Camera.main;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickObject();
        }
    }
    void ClickObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit))
        {

            GameObject clickedObject = hit.collider.gameObject;
            Purchasable purchasable = clickedObject.GetComponent<Purchasable>();
            if (purchasable != null && tempMoney >= purchasable.cost)
            {
                purchasable.OnClick();
                tempMoney = tempMoney - purchasable.cost;
                Debug.Log(tempMoney.ToString());
            }
            else if (purchasable != null && tempMoney <= purchasable.cost)
            {
                Debug.Log("Not enough money");
            }
        }
    }
}
