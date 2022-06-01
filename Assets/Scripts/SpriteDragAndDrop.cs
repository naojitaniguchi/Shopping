using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDragAndDrop : MonoBehaviour
{
    bool isDraging;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDraging)
        {
            Vector2 mouthPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mouthPosition);
        }
    }

    public void OnMouseDown()
    {
        isDraging = true;
    }

    public void OnMouseUp()
    {
        isDraging = false;
    }
}
