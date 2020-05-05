using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    private float minX, maxX;
    
    void Start()
    {
        Vector3 coor = Camera.main.ScreenToWorldPoint (new Vector3(Screen.width, Screen.height, 0));
        minX = -coor.x + 0.4f;
        maxX = coor.x - 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        if (temp.x > maxX) {
            temp.x = maxX;
        }

        if (temp.x < minX) {
            temp.x = minX;
        }

        transform.position = temp;
    }
} // class
