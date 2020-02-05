using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingItem : MonoBehaviour {
	public List<Sprite> BasicItems = new List<Sprite>();
	public List<Image> images = new List<Image>();
	public List<GameObject> items = new List<GameObject>();
	List<GameObject> go = new List<GameObject>();
	int tempValue = 0;
	bool isRepair = false;
	GameObject goSlot;
	private void Start() {
		goSlot = UIManager.Instance.finalSlot;
		goSlot.transform.GetChild(0).gameObject.SetActive(false);
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
	void Update() {
		
	}
	
	public void Repair() {
		goSlot.GetComponent<Image>().sprite = null;
		UIManager.Instance.RepairSystem();
		CarController.Instance.damageReceiver.SetActive(true);
	}

	IEnumerator Timer() {
		goSlot.transform.GetChild(0).gameObject.SetActive(true);

		for (int i = 10; i >= 1; i--) {
			goSlot.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = i.ToString();
			yield return new WaitForSeconds(1f);
		}
		goSlot.transform.GetChild(0).gameObject.SetActive(false);
		Repair();
		yield break;
	}

	public void ConbineItems() {
		go = UIManager.Instance.obj;
		int a = 0;
		for (int i = 0; i < go.Count; i++) {
			if (go[i].transform.childCount != 0) {
				a = i + 1;
			}
		}
		if (a == 3) {
			StartCoroutine(Timer());
		}
	}
}
