using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CarController : MonoBehaviour
{
	public static CarController Instance = null;
	public GameObject damageReceiver;

    [SerializeField]
    private WheelCollider fl, fr, rl, rr;
    [Space]
    [Range(100,1000)]
    [SerializeField]
    private int speed = 100;
    [SerializeField]
    private Transform steer;
    [SerializeField]
    [Range(10, 100)]
    private int angle = 10;

	private float damage = 10f;
	private float health = 100f;

	private void Awake() {
		Instance = this;
	}
	private void Start()
    {
            
    }
    private void Update()
    {
        float forward = Input.GetAxis("Vertical");
        if(GetComponent<Rigidbody>().velocity.magnitude < 15f)
        {
            //Debug.Log("t");
            rl.motorTorque = 1 * speed;
            rr.motorTorque = 1 * speed;
        }
        fl.steerAngle = -steer.rotation.z * angle;
        fr.steerAngle = -steer.rotation.z * angle;
        //Debug.Log(steer.rotation.z*angle);
		//Debug.Log(EventSystem.);

		if (Input.GetKey(KeyCode.A)) {
			if (health >= 0) {
				health -= damage;
				DamageReceived();
			} else {
				return;
			}
		}
	}
	public void DamageReceived() {
		if (health == 0) {
			damageReceiver.SetActive(false);
			speed = 100;
		} else {
			return;
		}
	}
}
