using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextSceneManager : MonoBehaviour
{

	public Text regionText1;
	public Text regionText2;

	public GameObject[] selectedBean0 = new GameObject[6];
	SpriteRenderer[] beanSprite0 = new SpriteRenderer[6];

	public GameObject[] selectedBean1 = new GameObject[6];
	SpriteRenderer[] beanSprite1 = new SpriteRenderer[6];


	public Text scoreText;

	int correctBeanScore;

	void Start ()
	{

		regionText1.text = PlayerPrefs.GetString ("region0");
		regionText2.text = PlayerPrefs.GetString ("region1");

		//最初に各豆のSpriteRendererをgetcomponent
		for (int i = 0; i < selectedBean0.Length; i++) {
			beanSprite0 [i] = selectedBean0 [i].GetComponent<SpriteRenderer> ();
		}

		for (int i = 0; i < selectedBean1.Length; i++) {
			beanSprite1 [i] = selectedBean1 [i].GetComponent<SpriteRenderer> ();
		}

		displayCountries (0);

		displayCountries (1);



//
//		correctBeanScore = PlayerPrefs.GetInt ("correctBeanScore" , 0);
//		Debug.Log (correctBeanScore);

//		scoreText.text = PlayerPrefs.GetInt ("correctBeanScore").ToString ();





	}
	

	//選ばれた6つの国旗名をplayerprefsに保存→NextSceneでそれをgetしてその名前のspriteをResorce.Loadし、spriteに挿入
	void displayCountries (int x)
	{
		if (x == 0) {
			if (PlayerPrefs.GetString ("region0") == "Asia") {
				for (int i = 0; i < 6; i++) {
					beanSprite0 [i].sprite = Resources.Load<Sprite> ("National Flag/asia/" + PlayerPrefs.GetString ("Asia" + i.ToString ()));
				}
			} else if (PlayerPrefs.GetString ("region0") == "Africa") {
				for (int i = 0; i < 6; i++) {
					beanSprite0 [i].sprite = Resources.Load<Sprite> ("National Flag/africa/" + PlayerPrefs.GetString ("Africa" + i.ToString ()));
				}
			} else if (PlayerPrefs.GetString ("region0") == "Europe") {
				for (int i = 0; i < 6; i++) {
					beanSprite0 [i].sprite = Resources.Load<Sprite> ("National Flag/europe/" + PlayerPrefs.GetString ("Europe" + i.ToString ()));
				}
			} else if (PlayerPrefs.GetString ("region0") == "NorthAmerica") {
				for (int i = 0; i < 6; i++) {
					beanSprite0 [i].sprite = Resources.Load<Sprite> ("National Flag/northAmerica/" + PlayerPrefs.GetString ("NorthAmerica" + i.ToString ()));
				}
			} else if (PlayerPrefs.GetString ("region0") == "Oceania") {
				for (int i = 0; i < 6; i++) {
					beanSprite0 [i].sprite = Resources.Load<Sprite> ("National Flag/oceania/" + PlayerPrefs.GetString ("Oceania" + i.ToString ()));
				}
			} else if (PlayerPrefs.GetString ("region0") == "SouthAmerica") {
				for (int i = 0; i < 6; i++) {
					beanSprite0 [i].sprite = Resources.Load<Sprite> ("National Flag/southAmerica/" + PlayerPrefs.GetString ("SouthAmerica" + i.ToString ()));
				}
			}



		} else {
			if (PlayerPrefs.GetString ("region1") == "Asia") {
				for (int i = 0; i < 6; i++) {
					beanSprite1 [i].sprite = Resources.Load<Sprite> ("National Flag/asia/" + PlayerPrefs.GetString ("Asia" + i.ToString ()));
				}
			} else if (PlayerPrefs.GetString ("region1") == "Africa") {
				for (int i = 0; i < 6; i++) {
					beanSprite1 [i].sprite = Resources.Load<Sprite> ("National Flag/africa/" + PlayerPrefs.GetString ("Africa" + i.ToString ()));
				}
			} else if (PlayerPrefs.GetString ("region1") == "Europe") {
				for (int i = 0; i < 6; i++) {
					beanSprite1 [i].sprite = Resources.Load<Sprite> ("National Flag/europe/" + PlayerPrefs.GetString ("Europe" + i.ToString ()));
				}
			} else if (PlayerPrefs.GetString ("region1") == "NorthAmerica") {
				for (int i = 0; i < 6; i++) {
					beanSprite1 [i].sprite = Resources.Load<Sprite> ("National Flag/northAmerica/" + PlayerPrefs.GetString ("NorthAmerica" + i.ToString ()));
				}
			} else if (PlayerPrefs.GetString ("region1") == "Oceania") {
				for (int i = 0; i < 6; i++) {
					beanSprite1 [i].sprite = Resources.Load<Sprite> ("National Flag/oceania/" + PlayerPrefs.GetString ("Oceania" + i.ToString ()));
				}
			} else if (PlayerPrefs.GetString ("region1") == "SouthAmerica") {
				for (int i = 0; i < 6; i++) {
					beanSprite1 [i].sprite = Resources.Load<Sprite> ("National Flag/southAmerica/" + PlayerPrefs.GetString ("SouthAmerica" + i.ToString ()));
				}
			}
				

		}


	}




}
