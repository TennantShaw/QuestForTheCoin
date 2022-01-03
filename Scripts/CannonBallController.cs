using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallController : MonoBehaviour
{
    //Variables

    // Collision Detection Method
    void OnCollisionEnter(Collision collision) {
       if (collision.gameObject.CompareTag("Ground")) {
           Destroy(gameObject);
       }

       if (collision.gameObject.CompareTag("SeaMonster")) {
           Destroy(gameObject);
       }
    }
}
