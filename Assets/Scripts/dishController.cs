using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class dishController : MonoBehaviour {

	int beanCount;
	int correctBeanCount;

	public GameObject chopsticks;
	//ChopstickControlller chopsticksController;

	public bool canPoint = false;


	float timer = 15.0f;
	public Text timerText;


	void Start(){
		//chopsticksController = chopsticks.GetComponent<ChopstickControlller> ();

	}

	void Update(){
		
		timer -= Time.deltaTime;
		timerText.text = timer.ToString ("f2");

//		if (timer < 0) {
//			Debug.Log ("最後は" + correctBeanCount);
//			PlayerPrefs.SetInt ("correctBeanScore", correctBeanCount);
//			SceneManager.LoadScene("NextScene");
//		}








		if (beanCount > 11) {
			Debug.Log("終了！！！！！");
		}

		if (chopsticks.transform.position.y > 4) {
			canPoint = true;
		} else {
			canPoint = false;
		}


	}

	void OnCollisionEnter2D(Collision2D col){

		if (canPoint) {


			beanCount += 1;

			if (col.gameObject.tag == this.gameObject.tag) {
				Debug.Log ("正解！");
				correctBeanCount += 1;
				col.gameObject.tag = "Finish";
//			Destroy (col.gameObject.GetComponent<Rigidbody2D> ());

				Debug.Log (correctBeanCount);
			}
		}



	}


}
