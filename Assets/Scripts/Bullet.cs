using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private int damage = 1;
    [SerializeField]
    private float distance;

    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed != 0)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            if (Vector3.Distance(transform.position, startPos) >= distance)
            {
                Destroy(gameObject);
            }
        }
    }
    void OnCollisionEnter(Collision col)


    {
        speed = 0;
        


        Destroy(gameObject);

    }
}
