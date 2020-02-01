using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    /* [SerializeField]
     private WheelCollider fl, fr, rl, rr;
     [Space]
     [Range(100, 1000)]
     [SerializeField]
     private int speed = 100;*/
    [SerializeField]
    private Transform player;
    
    
    [SerializeField]
    private float distance;

    private Vector3 velocity;
    private Rigidbody rigi;
    private float speed;


    private void Start()
    {
        rigi = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        speed = player.gameObject.GetComponent<Rigidbody>().velocity.magnitude;
        velocity = new Vector3(speed, gameObject.GetComponent<Rigidbody>().velocity.y,speed);

    }
    private void FixedUpdate()
    {
        if (Vector3.Distance(player.position,transform.position) > distance) {
            rigi.velocity = velocity;
        }
    }
}
