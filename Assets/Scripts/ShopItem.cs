using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    public enum SHOP_ITEM
    {
        EBI,
        SALMON,
        RICEBALL_MENTAI,
        RICEBALL_EBITEN,
        SHOP_ITEM_NUM
    }

    public SHOP_ITEM itemType;
    public int price;
    public bool inCart = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseUp()
    {
        Debug.Log("Mouse Up");
        if ( inCart)
        {
            gameObject.SetActive(false);
        }
    }
}
