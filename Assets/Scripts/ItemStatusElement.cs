using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemStatusElement : MonoBehaviour
{
    public Sprite[] sprites;
    public GameObject ImageObject;
    public GameObject TextObject;
    public ShopItem.SHOP_ITEM type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setItem( ShopItem.SHOP_ITEM itemType, int itemCount)
    {
        ImageObject.GetComponent<Image>().sprite = sprites[(int)itemType];
        TextObject.GetComponent<TMP_Text>().text = itemCount.ToString();
        type = itemType;
    }

    public void setCount(int itemCount)
    {
        TextObject.GetComponent<TMP_Text>().text = itemCount.ToString();
    }
}
