using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChopstickControlller : MonoBehaviour
{

	public Sprite openStick;
	public Sprite closeStick;
	public Sprite catchStick;

	SpriteRenderer chopsticksSprite;

	public bool isMovable = false;
	public bool isOpening = false;

	Vector3 preMousePos;

	float speed = 10.0f;

	public GameObject sentanObj;
	public GameObject sticksTouchedBean;

	ChopsticksColliderScript chopsticksColliderScript;
	Rigidbody2D touchedBeanRigid;

	public bool isCatching = false;


	// Use this for initialization
	void Start ()
	{
		chopsticksSprite = this.GetComponent<SpriteRenderer> ();
		chopsticksColliderScript = GetComponentInChildren<ChopsticksColliderScript> ();
	}
		
	// Update is called once per frame
	void Update ()
	{
		if (isMovable) {
			Move ();
		}

		if (isOpening) {
			chopsticksSprite.sprite = openStick;
		} else {
			if (!isCatching) {
				chopsticksSprite.sprite = closeStick;
			}
		} 
	}

	void OnMouseDown ()
	{
		isMovable = true;
		if (!isCatching) {
			isOpening = true;
		}
	}

	void OnMouseUp ()
	{
		isMovable = false;
		isOpening = false;	

		if (chopsticksColliderScript.touchedBean != null) {

			if (isCatching) {
				Debug.Log ("まめ離すよ");
				chopsticksColliderScript.touchedBean.transform.parent = null;
				touchedBeanRigid.gravityScale = 1;
				touchedBeanRigid.constraints = RigidbodyConstraints2D.None;
				isOpening = true;
				chopsticksColliderScript.touchedBean = null;

				isCatching = false;
			} else {
				//豆を掴んでいる時の処理
				Debug.Log ("まめ掴んでるよ");
				chopsticksSprite.sprite = catchStick;
				chopsticksColliderScript.touchedBean.transform.parent = this.transform;
				chopsticksColliderScript.touchedBean.transform.localPosition = new Vector3 (-3.6f, -3.4f, 0);
				touchedBeanRigid = chopsticksColliderScript.touchedBean.GetComponent<Rigidbody2D> ();
				touchedBeanRigid.gravityScale = 0;
				touchedBeanRigid.constraints = RigidbodyConstraints2D.FreezeAll;

//				float timer;
//				timer += Time.deltaTime;
//
//				if (timer > 5.0f) {
//					isCatching = false;
//				}

				isCatching = true;
			}
		}
	}



		

	void Move ()
	{
		if (Input.GetMouseButtonDown (0)) {
			preMousePos = Input.mousePosition;
		}
		if (Input.GetMouseButton (0)) {
			Vector3 mousePosDiff = Input.mousePosition - preMousePos;
			preMousePos = Input.mousePosition;
			Vector3 newPos = this.transform.position + new Vector3 (mousePosDiff.x / Screen.width, mousePosDiff.y / Screen.width, 0) * speed;
			this.transform.position = newPos;
		}
	}











}
