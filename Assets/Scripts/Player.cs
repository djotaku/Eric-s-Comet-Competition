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
    }

    private void Move()
    {
        var forwardMovement = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        var rotationMovement = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
        transform.Rotate(0, 0, -rotationMovement, Space.Self);
    }
}
