using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPushCheck : MonoBehaviour
{
    public GameObject MemoPad;
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
        MemoPad.GetComponent<MemoPad>().checkItems();
    }
}
