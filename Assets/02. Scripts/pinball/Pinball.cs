using System;
using UnityEditor.UI;
using UnityEngine;

public class Pinball : MonoBehaviour
{
    public PinballManager pm;
    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Score10":
                pm.score += 10;
                break;
            case "Score30":
                pm.score += 30;
                break;
            case "Score50":
                pm.score += 50;
                break;
            default:
                break;
        }

        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Gameover"))
        {
            Debug.Log($"게임오버 점수: {pm.score}");            
        }
    }
}
