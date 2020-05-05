using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] corona;
    
    private BoxCollider2D col;

    float x1, x2;

    void Awake() {
        col = GetComponent<BoxCollider2D> ();

        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;
    }

    void Start() {
        StartCoroutine (SpawnCorona(0.5f));
    }

    IEnumerator SpawnCorona(float time) {
        yield return new WaitForSecondsRealtime (time);

        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);

        Instantiate (corona[Random.Range(0, corona.Length)], temp, Quaternion.identity);
        
        StartCoroutine (SpawnCorona(Random.Range(0.1f, 1.5f)));
    }
} // class
