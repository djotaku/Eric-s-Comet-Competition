using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCollider : MonoBehaviour
{
    [SerializeField] int offset = 5; //may need to change if I change how big a unit of space the screen is

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var leftPos = FindObjectOfType<LeftCollider>().GetPosition();
        FindObjectOfType<Player>().SetLocation(new Vector2(leftPos.x + offset, 0));
    }

    public Vector2 GetPosition()
    {
        return transform.position;
    }
}
