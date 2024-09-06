using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchasable : MonoBehaviour
{
    [SerializeField] public int cost;
    private void Start()
    {
       
    }

    private void Update()
    {

       
    }
    public void OnClick()
    {
        this.gameObject.SetActive(false);
    }
}
