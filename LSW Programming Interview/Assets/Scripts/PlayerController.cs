using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    Rigidbody2D rigidbody2d;
    float horizontalInput;
    float verticalInput;
    Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        position = rigidbody2d.position;
        position.x += horizontalInput * speed;
        position.y += verticalInput * speed;

        rigidbody2d.MovePosition(position);
    }
}
