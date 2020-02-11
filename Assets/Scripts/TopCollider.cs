using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Top Triggered!");
        var bottomPos = FindObjectOfType<BotCollider>().GetPosition();
        FindObjectOfType<Player>().SetLocation(bottomPos);
    }
}
