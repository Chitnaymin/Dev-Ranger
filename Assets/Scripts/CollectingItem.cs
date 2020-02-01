using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingItem : MonoBehaviour
{
	public List<Sprite> BasicItems = new List<Sprite>();
	public List<Image> images = new List<Image>();
	public List<GameObject> items = new List<GameObject>();
	int tempValue=0;

	private void OnCollisionEnter(Collision collision) {
	}

	private void OnTriggerEnter(Collider other) {
		for (int i = 0; i < items.Count; i++) {
			if (other.gameObject.name == items[i].name) {
				tempValue = items[i].GetComponent<ItemData>().GetData();
				images[tempValue].sprite = BasicItems[tempValue];
				items[i].SetActive(false);
			}
		}
	}
}
