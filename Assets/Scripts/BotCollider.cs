using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bottom Triggered!");
    }

    public Vector2 GetPosition()
    {
        return transform.position;
    }

}
