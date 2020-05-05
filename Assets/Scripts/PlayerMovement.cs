using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 0.5f;
    private Rigidbody2D myBody;

    void Awake() {
        myBody = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate() {
        Vector2 vel = myBody.velocity;
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            vel.x = touch.deltaPosition.x * speed;
            myBody.velocity = vel;

            if (touch.phase == TouchPhase.Ended) {
                myBody.velocity = Vector2.zero;
            }
        }
        else {
            myBody.velocity = Vector2.zero;
        }
    }

} // class
