using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10.0f;
    public float tapMargine = 0.1f;
    public bool draging;
    public MOVE_MODE modeMode = MOVE_MODE.ONLY_X;

    public enum MOVE_MODE
    {
        ONLY_X,
        ONLY_Y,
        BOTH
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed * -1.0f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed * -1.0f;
        }

        if (!draging)
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 mouthPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                mouthPosition.x += Camera.main.transform.position.x;
                mouthPosition.y += Camera.main.transform.position.y;

                if ( modeMode == MOVE_MODE.ONLY_X)
                {
                    if (mouthPosition.x > gameObject.transform.position.x + tapMargine)
                    {
                        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
                    }
                    else if (mouthPosition.x < gameObject.transform.position.x - tapMargine)
                    {
                        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed * -1.0f;
                    }
                }

                if (modeMode == MOVE_MODE.ONLY_Y)
                {
                    if (mouthPosition.y > gameObject.transform.position.y + tapMargine)
                    {
                        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
                    }
                    else if (mouthPosition.y < gameObject.transform.position.y - tapMargine)
                    {
                        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed * -1.0f;
                    }
                }

                if (modeMode == MOVE_MODE.BOTH)
                {
                    Vector2 nowPosition;
                    nowPosition.x = gameObject.transform.position.x;
                    nowPosition.y = gameObject.transform.position.y;

                    Vector2 diff = mouthPosition - nowPosition;
                    if ( diff.magnitude > tapMargine)
                    {
                        gameObject.GetComponent<Rigidbody2D>().velocity = diff.normalized * speed;
                    }
                }
            }
        }
    }
}
