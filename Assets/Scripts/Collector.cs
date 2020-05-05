using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D target) {
        if (target.tag == "Bad Corona" || target.tag == "Good Corona") {
            target.gameObject.SetActive(false);
        }
    }

} // class
