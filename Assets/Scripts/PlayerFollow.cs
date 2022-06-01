using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public GameObject player;
    public float xDistanceMax = 0.3f;
    public float yDistanceMax = 0.3f;
    public float mapXMin = -100.0f;
    public float mapXMax = 100.0f;
    public float mapYMin = -100.0f;
    public float mapYMax = 100.0f;
    public bool useMapArea = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (useMapArea)
        {
            if (player.transform.position.x < mapXMin)
            {
                return;
            }
            if (player.transform.position.x > mapXMax)
            {
                return;
            }

            if (player.transform.position.y < mapYMin)
            {
                return;
            }
            if (player.transform.position.y > mapYMax)
            {
                return;
            }
        }

        float xDistance = player.transform.position.x - gameObject.transform.position.x;
        float yDistance = player.transform.position.y - gameObject.transform.position.y;
        float xPos = gameObject.transform.position.x;
        float yPos = gameObject.transform.position.y;
        if (Math.Abs(xDistance) > xDistanceMax)
        {
            if (xDistance > 0.0f)
            {
                xPos = player.transform.position.x - xDistanceMax;
            }
            else
            {
                xPos = player.transform.position.x + xDistanceMax;
            }
        }
        if (Math.Abs(yDistance) > yDistanceMax)
        {
            if (yDistance > 0.0f)
            {
                yPos = player.transform.position.y - yDistanceMax;
            }
            else
            {
                yPos = player.transform.position.y + yDistanceMax;
            }

        }
        gameObject.transform.position = new Vector3(xPos, yPos, gameObject.transform.position.z);
    }
}