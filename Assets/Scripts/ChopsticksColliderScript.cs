using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopsticksColliderScript : MonoBehaviour {

	public GameObject touchedBean;
	ChopstickControlller chopstickcontroller;

	void Start(){
		chopstickcontroller = GetComponentInParent<ChopstickControlller>();
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag != null && col.GetComponent<CircleCollider2D>() != null) {
			Debug.Log ("catch!!");
			touchedBean = col.gameObject;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if (col.gameObject.tag != null && col.GetComponent<CircleCollider2D>() != null) {
			if (!chopstickcontroller.isCatching) {
				touchedBean = null;
			}
		}
	}

}
