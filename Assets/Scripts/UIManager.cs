using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
	public static UIManager Instance = null;
	public GameObject RepairPanel;
	public Image Arrow;
	public List<GameObject> obj = new List<GameObject>();
	public GameObject finalSlot;

	private void Awake() {
		Instance = this;
	}
	public void RepairSystem() {
		if (RepairPanel.transform.position.x != 1920f) {
			RepairPanel.transform.DOMoveX(1920f, 0.5f);
			Arrow.transform.localScale = new Vector3(-1f,1f,1f);
		} else {
			RepairPanel.transform.DOMoveX(2522.64f, 0.5f);
			Arrow.transform.localScale = new Vector3(1f, 1f, 1f);
		}
	}
}
