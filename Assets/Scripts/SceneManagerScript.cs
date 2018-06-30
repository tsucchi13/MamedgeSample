using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{

	string[] country = new string[50];
	string[] region = { "Asia", "Europe", "Americans", "NorthAmerica", "Africa", "Oceania" };
	string[] selectedregions = new string[2];

	string stay;
	int index;

	public Text regiontext1;
	public Text regiontext2;



	public Sprite[] countrySprite;
	Sprite[] selectedCountrySprite = new Sprite[6];
	Sprite staySprite;


	public GameObject[] mame = new GameObject[6];
	SpriteRenderer[] mamesprite = new SpriteRenderer[6];

//	SpriteRenderer mamesprite1;


	void Start ()
	{
		countrySprite = Resources.LoadAll<Sprite>("Sprites");

		for (int i = 0; i < mame.Length; i++) {
			mamesprite[i] = mame[i].GetComponent<SpriteRenderer> ();
		}


		regionShuffle ();





//
//		//配列シャッフル
//		for (int i = countrySprite.Length - 1; i > 0; i--) {
//			index = Random.Range (0, i + 1);
//			staySprite = countrySprite [i];
//			countrySprite [i] = countrySprite [index];
//			countrySprite [index] = staySprite;
//		}
//
//
//		//ここでregion配列の最初の2個をselectedregions配列に入れてる
//		for (int i = 0; i < selectedCountrySprite.Length; i++) {
//			selectedCountrySprite [i] = countrySprite [i];
//		}
//
//		for (int i = 0; i < mame.Length; i++) {
//			mamesprite[i].sprite = selectedCountrySprite[i];
//		}
//			

	}

	void Update ()
	{
		
	}

	void regionShuffle(){
		
		//配列シャッフル
		for (int i = region.Length - 1; i > 0; i--) {
			index = Random.Range (0, i + 1);
			stay = region [i];
			region [i] = region [index];
			region [index] = stay;
		}


		//ここでregion配列の最初の2個をselectedregions配列に入れてる
		for (int i = 0; i < selectedregions.Length; i++) {
			selectedregions [i] = region [i];
		}

		//ここでUnityのゲーム画面のTextに表示
		regiontext1.text = selectedregions [0];
		regiontext2.text = selectedregions [1];

	}

}
