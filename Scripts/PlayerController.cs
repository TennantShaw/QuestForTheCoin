using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float rotateSpeed = 50f;
    public float xBoundary = 200f;
    public float botZBoundary = -200;
    public float topZBoundary = 600f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerMovement();
    }

    void MovePlayer() {
        // Use Player Input to move the ship forward
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        // Use Player Input to rotate the ship left
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow)) {
            transform.Rotate(0f, -rotateSpeed * Time.deltaTime, 0f);
        }

        // Use Player Input to rotate the ship right
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow)) {
            transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
        }
    }

    void ConstrainPlayerMovement () {
        // Reset the players position if they go beyond the x boundary on the left
        if (transform.position.x < -xBoundary) {
            transform.position = new Vector3(-xBoundary, transform.position.y, transform.position.z);
        }

        // Reset the players position if they go beyond the x boundary on the right
         if (transform.position.x > xBoundary) {
            transform.position = new Vector3(xBoundary, transform.position.y, transform.position.z);
        }

        // Reset the players position if they go beyond the z boundary on the bottom
        if (transform.position.z < botZBoundary) {
            transform.position = new Vector3(transform.position.x, transform.position.y, botZBoundary);
        }

        // Reset the players position if they go beyond the z boundary on the top
        if (transform.position.z > topZBoundary) {
            transform.position = new Vector3(transform.position.x, transform.position.y, topZBoundary);
        }
    }
}
