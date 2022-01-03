using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public Rigidbody cannonballPrefabRB;
    public float cannonballXOffset = 0.5f;
    public float shotForce = 10.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (gameObject.CompareTag("RightSideCannon")) {
                Rigidbody cannonBall = Instantiate(cannonballPrefabRB, new Vector3(transform.position.x + cannonballXOffset, transform.position.y, transform.position.z), transform.rotation);
                FireCannonballRight(cannonBall);
            }

            if (gameObject.CompareTag("LeftSideCannon")) {
                Rigidbody cannonBall = Instantiate(cannonballPrefabRB, new Vector3(transform.position.x - cannonballXOffset, transform.position.y, transform.position.z), transform.rotation);
                FireCannonballLeft(cannonBall);
            }
        }
    }

    void FireCannonballRight (Rigidbody cb) {
        //cb.velocity = transform.right * shotForce;
        /*if (transform.rotation.y >= 0.0f) {
            cb.AddRelativeForce(1.0f * shotForce, 0.0f, 0.0f, ForceMode.Impulse);
        } else {
            cb.AddRelativeForce(1.0f * -shotForce, 0.0f, 0.0f, ForceMode.Impulse);
        }*/

        Vector3 direction = cb.transform.position - transform.position;
        cb.AddForceAtPosition(direction.normalized, transform.position);
    }
    
    void FireCannonballLeft (Rigidbody cb) {
        cb.velocity = transform.right * -shotForce;
    }
}
