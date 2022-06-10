using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerPosition : MonoBehaviour
{
    bool setPlayer = false;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (setPlayer == false)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            playerObj.transform.position = position;
            setPlayer = true;
        }   
    }
}
