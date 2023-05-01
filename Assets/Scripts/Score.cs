using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TextMesh scoreText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMesh>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"SCORE: {score}";

    }
}
