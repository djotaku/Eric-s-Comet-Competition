using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCollider : MonoBehaviour
{
    [SerializeField] int offset = 6; //may need to change if I change how big a unit of space the screen is

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var rightPos = FindObjectOfType<RightCollider>().GetPosition();
        FindObjectOfType<Player>().SetLocation(new Vector2(rightPos.x - offset, 0));
    }

    public Vector2 GetPosition()
    {
        return transform.position;
    }
}
