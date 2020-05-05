using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    private Text scoreText;

    private int score = 0;

    void Awake() {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text> ();
        scoreText.text = "0";
    }

    void OnTriggerEnter2D(Collider2D target) {
        if (target.tag == "Bad Corona") {
            transform.position = new Vector2 (0, 100);
            target.gameObject.SetActive(false);
            StartCoroutine (RestartGame());
        }

        if (target.tag == "Good Corona") {
            target.gameObject.SetActive(false);
            score++;
            scoreText.text = score.ToString();
        }
    }

    IEnumerator RestartGame() {
        yield return new WaitForSecondsRealtime (2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

} // class
