using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetwheels : MonoBehaviour {
	public WheelCollider TargetWheels;
	private Vector3 wheelposition = new Vector3 ();
	private Quaternion wheelrotation = new Quaternion ();


	private void Update(){

		TargetWheels.GetWorldPose (out wheelposition, out wheelrotation);
		transform.position = wheelposition;
		transform.rotation = wheelrotation;

	}
}
