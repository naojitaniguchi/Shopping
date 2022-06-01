using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopCart : MonoBehaviour
{
    public int money = 1000;
    public int[] itemNumbers;
    public GameObject moneyText;
    public GameObject canvas;
    public GameObject itemElent;
    public float itemElenetX;
    public float itemElenetYTop;
    public float itemElenetYStep;
    List<GameObject> itemElements;

    // Start is called before the first frame update
    void Start()
    {
        itemNumbers = new int[(int)ShopItem.SHOP_ITEM.SHOP_ITEM_NUM];
        moneyText.GetComponent<TMP_Text>().text = money.ToString();
        itemElements = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Item")
        {
            int index = (int)col.gameObject.GetComponent<ShopItem>().itemType;
            itemNumbers[index]++;
            money -= col.gameObject.GetComponent<ShopItem>().price;
            col.gameObject.GetComponent<ShopItem>().inCart = true;
            moneyText.GetComponent<TMP_Text>().text = money.ToString();

            addItemElementToCanvas(col.gameObject.GetComponent<ShopItem>().itemType, itemNumbers[index]);
        }
    }

    void addItemElementToCanvas(ShopItem.SHOP_ITEM itemType, int itemCount)
    {
        bool hit = false;
        for ( int i = 0; i < itemElements.Count; i ++)
        {
            if ( itemElements[i].GetComponent<ItemStatusElement>().type == itemType)
            {
                itemElements[i].GetComponent<ItemStatusElement>().setCount(itemCount);
                hit = true;
                break;
            }
        }
        if (!hit)
        {
            GameObject obj = Instantiate(itemElent);
            obj.GetComponent<ItemStatusElement>().setItem(itemType, itemCount);
            obj.transform.SetParent(canvas.transform);
            float yPos = itemElenetYTop + (float)itemElements.Count * itemElenetYStep;
            obj.GetComponent<RectTransform>().localPosition = new Vector3(itemElenetX, yPos, 0.0f);
            itemElements.Add(obj);
        }
    }
}
