using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Variables
    public float speed = 5f;
    private Rigidbody enemyRB;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate() {
        Vector3 towardsPlayer = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(towardsPlayer * speed);
    }
}
