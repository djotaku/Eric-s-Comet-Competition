using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopCollider : MonoBehaviour
{

    [SerializeField] int offset = 1; //may need to change if I change how big a unit of space the screen is

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var bottomPos = FindObjectOfType<BotCollider>().GetPosition();
        FindObjectOfType<Player>().SetLocation(new Vector2(0, bottomPos.y+offset));
    }

    public Vector2 GetPosition()
    {
        return transform.position;
    }
}
