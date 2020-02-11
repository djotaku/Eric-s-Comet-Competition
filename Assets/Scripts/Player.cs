using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // config params
    [Header("Player")] // to organize in Unity
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float rotationSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        var forwardMovement = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        var deltaX = -Mathf.Sin(transform.rotation.eulerAngles.z * Mathf.Deg2Rad) * forwardMovement;
        var deltaY = Mathf.Cos(transform.rotation.eulerAngles.z * Mathf.Deg2Rad) * forwardMovement;
        var newXPos = transform.position.x + deltaX;
        var newYPos = transform.position.y + deltaY;
        transform.position = new Vector2(newXPos, newYPos);
    }

    private void Rotate()
    {
        var rotationMovement = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
        transform.Rotate(0, 0, -rotationMovement, Space.Self);
    }

    public void SetLocation(Vector2 newPos)
    {
        if (newPos.x == 0)
        {
            transform.position = new Vector2 (transform.position.x, newPos.y);
        }
        else if (newPos.y == 0)
        {
            transform.position = new Vector2(newPos.x, transform.position.y);
        }
        
    }
}