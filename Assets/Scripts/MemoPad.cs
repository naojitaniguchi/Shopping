using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoPad : MonoBehaviour
{
    public int[] itemNumbers;
    public int money;

    public GameObject sccessDialog;
    public GameObject moneySavedDialog;
    public GameObject TryAgainDialog;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkItems()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if ( player == null)
        {
            return;
        }
        ShopCart cart = player.GetComponent<ShopCart>();
        if ( cart == null)
        {
            return;
        }

        if ( cart.itemNumbers.Length != itemNumbers.Length)
        {
            return;
        }

        int count = 0;
        for ( int i = 0; i < itemNumbers.Length; i ++)
        {
            if ( cart.itemNumbers[i] >= itemNumbers[i])
            {
                count++;
            }
        }

        if ( count == itemNumbers.Length)
        {
            sccessDialog.SetActive(true);

            if ( cart.money >= money)
            {
                moneySavedDialog.SetActive(true);
            }
        }
        else
        {
            TryAgainDialog.SetActive(true);
            // Destroy(player);

        }
    }
}
