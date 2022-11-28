using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    private int score;
    [SerializeField]
    private TextMeshProUGUI scoreText;

    private void Awake() {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Point")) {
            score++;
            scoreText.text = score.ToString();
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Enemy")) {
            PlayerPrefs.SetInt("score",score);
            SceneManager.LoadScene(2);
            scoreText.text = score.ToString();
            Destroy(gameObject);
        }
    }
}
