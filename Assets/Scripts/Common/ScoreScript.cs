using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + player.score;   
    }
}
