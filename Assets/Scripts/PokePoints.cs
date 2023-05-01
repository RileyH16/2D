using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokePoints : MonoBehaviour
{
    public int pointsToAdd;
    public Score score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            score.score += pointsToAdd;

        }
    }
}
