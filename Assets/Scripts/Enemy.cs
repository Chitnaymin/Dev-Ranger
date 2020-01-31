using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
	public float Offset;
	public GameObject targetPlayer;
	private void Start() {
		
	}
	private void Update() {
		//transform.position = new Vector3(targetPlayer.transform.position.x, targetPlayer.transform.position.y, targetPlayer.transform.position.z+Offset);
		GetComponent<NavMeshAgent>().SetDestination(targetPlayer.transform.position);
	}
}
