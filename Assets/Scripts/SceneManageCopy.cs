using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManageCopy: MonoBehaviour
{


	string[] region = { "Asia", "Europe", "SouthAmerica", "NorthAmerica", "Africa", "Oceania" };
	public string[] selectedregions = new string[2];

	string stay;
	Sprite stayAfricaSprite;
	Sprite stayAsiaSprite;
	Sprite stayEuropeSprite;
	Sprite stayNorthAmericaSprite;
	Sprite stayOceaniaSprite;
	Sprite staySouthAmericaSprite;
	int index;

	public Text regiontext1;
	public Text regiontext2;


	//bool isPlaying = true;


	public Sprite[] africaSprite;
	Sprite[] selectedAfricaSprits = new Sprite[6];

	public Sprite[] asiaSprite;
	Sprite[] selectedAsiaSprits = new Sprite[6];

	public Sprite[] europeSprite;
	Sprite[] selectedEuropeSprits = new Sprite[6];

	public Sprite[] northAmericaSprite;
	Sprite[] selectedNorthAmericaSprits = new Sprite[6];

	public Sprite[] oceaniaSprite;
	Sprite[] selectedOceaniaSprits = new Sprite[6];

	public Sprite[] southAmericaSprite;
	Sprite[] selectedSouthAmericaSprits = new Sprite[6];



	public GameObject[] selectedBean1 = new GameObject[6];
	SpriteRenderer[] beanSprite1 = new SpriteRenderer[6];

	public GameObject[] selectedBean2 = new GameObject[6];
	SpriteRenderer[] beanSprite2 = new SpriteRenderer[6];



	public GameObject dish0;
	public GameObject dish1;






	void Start ()
	{
		//最初に各豆のSpriteRendererをgetcomponent
		for (int i = 0; i < selectedBean1.Length; i++) {
			beanSprite1 [i] = selectedBean1[i].GetComponent<SpriteRenderer> ();
		}

		for (int i = 0; i < selectedBean2.Length; i++) {
			beanSprite2 [i] = selectedBean2[i].GetComponent<SpriteRenderer> ();
		}
	
		regionShuffle ();//地域をシャッフル



		dish0.tag = selectedregions [0];
		dish1.tag = selectedregions [1];


		for (int i = 0; i < selectedBean1.Length; i++) {
			selectedBean1[i].tag = selectedregions [0];
		}
		for (int i = 0; i < selectedBean2.Length; i++) {
			selectedBean2[i].tag = selectedregions [1];
		}



		if (selectedregions [0] == "Asia") {
			Debug.Log ("1つ目がアジア");
			asiaSprite = Resources.LoadAll<Sprite> ("National Flag/asia");
			asiaShuffle (0);
		} else if (selectedregions [0] == "Africa") {
			Debug.Log ("1つ目がアフリカ");
			africaSprite = Resources.LoadAll<Sprite> ("National Flag/africa");
			africaShuffle (0);
		} else if (selectedregions [0] == "Europe") {
			Debug.Log ("1つ目がヨーロッパ");
			europeSprite = Resources.LoadAll<Sprite> ("National Flag/europe");
			europeShuffle (0);
		} else if (selectedregions [0] == "NorthAmerica") {
			Debug.Log ("1つ目が北アメリカ");
			northAmericaSprite = Resources.LoadAll<Sprite> ("National Flag/northAmerica");
			northAmericaShuffle (0);
		} else if (selectedregions [0] == "Oceania") {
			Debug.Log ("1つ目オセアニア");
			oceaniaSprite = Resources.LoadAll<Sprite> ("National Flag/oceania");
			oceaniaShuffle (0);
		} else if (selectedregions [0] == "SouthAmerica") {
			Debug.Log ("1つ目が南アメリカ");
			southAmericaSprite = Resources.LoadAll<Sprite> ("National Flag/southAmerica");
			southAmericaShuffle (0);
		}



		if (selectedregions [1] == "Asia") {
			Debug.Log ("2つ目がアジア");
			asiaSprite = Resources.LoadAll<Sprite> ("National Flag/Asia");
			asiaShuffle (1);
		} else if (selectedregions [1] == "Africa") {
			Debug.Log ("2つ目がアフリカ");
			africaSprite = Resources.LoadAll<Sprite> ("National Flag/Africa");
			africaShuffle (1);
		} else if (selectedregions [1] == "Europe") {
			Debug.Log ("2つ目がヨーロッパ");
			europeSprite = Resources.LoadAll<Sprite> ("National Flag/Europe");
			europeShuffle (1);
		} else if (selectedregions [1] == "NorthAmerica") {
			Debug.Log ("2つ目北アメリカ");
			northAmericaSprite = Resources.LoadAll<Sprite> ("National Flag/NorthAmerica");
			northAmericaShuffle (1);
		} else if (selectedregions [1] == "Oceania") {
			Debug.Log ("2つ目がオセアニア");
			oceaniaSprite = Resources.LoadAll<Sprite> ("National Flag/Oceania");
			oceaniaShuffle (1);
		} else if (selectedregions [1] == "SouthAmerica") {
			Debug.Log ("2つ目が南アメリカ");
			southAmericaSprite = Resources.LoadAll<Sprite> ("National Flag/SouthAmerica");
			southAmericaShuffle (1);
		}
		






	}
		



	void regionShuffle ()
	{
		for (int i = region.Length - 1; i > 0; i--) {
			index = Random.Range (0, i + 1);
			stay = region [i];
			region [i] = region [index];
			region [index] = stay;
		}

		for (int i = 0; i < selectedregions.Length; i++) {
			selectedregions [i] = region [i];
		}

		regiontext1.text = selectedregions [0];
		regiontext2.text = selectedregions [1];
		Debug.Log (selectedregions [0]);
		Debug.Log (selectedregions [1]);

		PlayerPrefs.SetString ("region0", selectedregions [0]);
		PlayerPrefs.SetString ("region1", selectedregions [1]);
	}

	void africaShuffle (int x)
	{

		//配列シャッフル
		for (int i = africaSprite.Length - 1; i > 0; i--) {
			index = Random.Range (0, i + 1);
			stayAfricaSprite = africaSprite [i];
			africaSprite [i] = africaSprite [index];
			africaSprite [index] = stayAfricaSprite;
		}

		//ここでregion配列の前から二個をselectedregion配列に表示
		for (int i = 0; i < selectedAfricaSprits.Length; i++) {
			selectedAfricaSprits [i] = africaSprite [i];
		}


		if (x == 0) {
			for (int i = 0; i < beanSprite1.Length; i++) {
				beanSprite1 [i].sprite = selectedAfricaSprits [i];
			}
		} else {
			for (int i = 0; i < beanSprite2.Length; i++) {
				beanSprite2 [i].sprite = selectedAfricaSprits [i];
			}
		}

		//選ばれた6つの国旗名をplayerprefsに保存→NextSceneでそれをgetしてその名前のspriteをResorce.Loadし、spriteに挿入
		for(int i = 0;i < selectedAfricaSprits.Length;i++){
			PlayerPrefs.SetString ("Africa" + i.ToString(), selectedAfricaSprits [i].name);
		
		}

	}

	void asiaShuffle (int x)
	{
		for (int i = asiaSprite.Length - 1; i > 0; i--) {
			index = Random.Range (0, i + 1);
			stayAsiaSprite = asiaSprite [i];
			asiaSprite [i] = asiaSprite [index];
			asiaSprite [index] = stayAsiaSprite;
		}
		for (int i = 0; i < selectedAsiaSprits.Length; i++) {
			selectedAsiaSprits [i] = asiaSprite [i];
		}
			
		if (x == 0) {
			for (int i = 0; i < beanSprite1.Length; i++) {
				beanSprite1 [i].sprite = selectedAsiaSprits [i];
			}
		} else {
			for (int i = 0; i < beanSprite2.Length; i++) {
				beanSprite2 [i].sprite = selectedAsiaSprits [i];
			}
		}

		//選ばれた6つの国旗名をplayerprefsに保存→NextSceneでそれをgetしてその名前のspriteをResorce.Loadし、spriteに挿入
		for(int i = 0;i < selectedAsiaSprits.Length;i++){
			PlayerPrefs.SetString ("Asia" + i.ToString(), selectedAsiaSprits [i].name);
		}

	}

	void europeShuffle (int x)
	{
		for (int i = europeSprite.Length - 1; i > 0; i--) {
			index = Random.Range (0, i + 1);
			stayEuropeSprite = europeSprite [i];
			europeSprite [i] = europeSprite [index];
			europeSprite [index] = stayEuropeSprite;
		}

		for (int i = 0; i < selectedEuropeSprits.Length; i++) {
			selectedEuropeSprits [i] = europeSprite [i];
		}

		if (x == 0) {
			for (int i = 0; i < beanSprite1.Length; i++) {
				beanSprite1 [i].sprite = selectedEuropeSprits [i];
			}
		} else {
			for (int i = 0; i < beanSprite2.Length; i++) {
				beanSprite2 [i].sprite = selectedEuropeSprits [i];
			}
		}

		//選ばれた6つの国旗名をplayerprefsに保存→NextSceneでそれをgetしてその名前のspriteをResorce.Loadし、spriteに挿入
		for(int i = 0;i < selectedEuropeSprits.Length;i++){
			PlayerPrefs.SetString ("Europe" + i.ToString(), selectedEuropeSprits [i].name);

		}

	}

	void northAmericaShuffle (int x)
	{
		for (int i = northAmericaSprite.Length - 1; i > 0; i--) {
			index = Random.Range (0, i + 1);
			stayNorthAmericaSprite = northAmericaSprite [i];
			northAmericaSprite [i] = northAmericaSprite [index];
			northAmericaSprite [index] = stayNorthAmericaSprite;
		}

		for (int i = 0; i < selectedNorthAmericaSprits.Length; i++) {
			selectedNorthAmericaSprits [i] = northAmericaSprite [i];
		}

		if (x == 0) {
			for (int i = 0; i < beanSprite1.Length; i++) {
				beanSprite1 [i].sprite = selectedNorthAmericaSprits [i];
			}
		} else {
			for (int i = 0; i < beanSprite2.Length; i++) {
				beanSprite2 [i].sprite = selectedNorthAmericaSprits [i];
			}
		}

		//選ばれた6つの国旗名をplayerprefsに保存→NextSceneでそれをgetしてその名前のspriteをResorce.Loadし、spriteに挿入
		for(int i = 0;i < northAmericaSprite.Length;i++){
			PlayerPrefs.SetString ("NorthAmerica" + i.ToString(), northAmericaSprite [i].name);

		}

	}

	void oceaniaShuffle (int x)
	{
		for (int i = oceaniaSprite.Length - 1; i > 0; i--) {
			index = Random.Range (0, i + 1);
			stayOceaniaSprite = oceaniaSprite [i];
			oceaniaSprite [i] = oceaniaSprite [index];
			oceaniaSprite [index] = stayOceaniaSprite;
		}

		for (int i = 0; i < selectedOceaniaSprits.Length; i++) {
			selectedOceaniaSprits [i] = oceaniaSprite [i];
		}

		if (x == 0) {
			for (int i = 0; i < beanSprite1.Length; i++) {
				beanSprite1 [i].sprite = selectedOceaniaSprits [i];
			}
		} else {
			for (int i = 0; i < beanSprite2.Length; i++) {
				beanSprite2 [i].sprite = selectedOceaniaSprits [i];
			}
		}

		//選ばれた6つの国旗名をplayerprefsに保存→NextSceneでそれをgetしてその名前のspriteをResorce.Loadし、spriteに挿入
		for(int i = 0;i < selectedOceaniaSprits.Length;i++){
			PlayerPrefs.SetString ("Oceania" + i.ToString(), selectedOceaniaSprits [i].name);

		}

	}

	void southAmericaShuffle (int x)
	{
		for (int i = southAmericaSprite.Length - 1; i > 0; i--) {
			index = Random.Range (0, i + 1);
			staySouthAmericaSprite = southAmericaSprite [i];
			southAmericaSprite [i] = southAmericaSprite [index];
			southAmericaSprite [index] = staySouthAmericaSprite;
		}

		for (int i = 0; i < selectedSouthAmericaSprits.Length; i++) {
			selectedSouthAmericaSprits [i] = southAmericaSprite [i];
		}

		if (x == 0) {
			for (int i = 0; i < beanSprite1.Length; i++) {
				beanSprite1 [i].sprite = selectedSouthAmericaSprits [i];
			}
		} else {
			for (int i = 0; i < beanSprite2.Length; i++) {
				beanSprite2 [i].sprite = selectedSouthAmericaSprits [i];
			}
		}

		//選ばれた6つの国旗名をplayerprefsに保存→NextSceneでそれをgetしてその名前のspriteをResorce.Loadし、spriteに挿入
		for(int i = 0;i < selectedSouthAmericaSprits.Length;i++){
			PlayerPrefs.SetString ("SouthAmerica" + i.ToString(), selectedSouthAmericaSprits [i].name);

		}

	}
}