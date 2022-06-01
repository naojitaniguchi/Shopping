using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateByCollision : MonoBehaviour
{
    public enum MODE
    {
        COLLISION,
        TRIGGER
    }

    public MODE mode = MODE.TRIGGER;
    public GameObject[] targets;
    public string targetTag = "Player";
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if ( mode == MODE.TRIGGER )
        {
            if (col.gameObject.tag == targetTag)
            {
                for ( int i = 0; i < targets.Length; i ++ )
                targets[i].SetActive(true);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        if (mode == MODE.COLLISION)
        {
            if (col.gameObject.tag == targetTag)
            {
                for (int i = 0; i < targets.Length; i++)
                    targets[i].SetActive(true);
            }
        }
    }
}
