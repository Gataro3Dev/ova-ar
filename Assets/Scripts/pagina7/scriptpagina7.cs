using UnityEngine;
using System.Collections;

public class scriptpagina7 : MonoBehaviour {
	public static int puntos;
	public GameObject interfaz;
	private string objeto;
	bool bandera;
	// Use this for initialization
	void Start () {
		bandera = true;
	}

	// Update is called once per frame
	void Update () {
		if(bandera){
			StartCoroutine (carga_Interfaz());
			bandera = false;
		}
	}

	public IEnumerator carga_Interfaz(){
		yield return new WaitForSeconds (2f);
		GameObject newinterfaz = Instantiate (interfaz);
	}

	public void BtnCubo1(){			
		objeto = "cubo1";
	}

	public void BtnCubo2(){			
		objeto = "cubo2";
	}

	public void BtnCubo3(){			
		objeto = "cubo3";
	}

	public void BtnCubo4(){			
		objeto = "cubo4";
	}

	public void BtnRotarXP(){
		if(objeto == "cubo1"){
			GameObject.Find("cubo1").transform.Rotate(45, 0, 0);
		}
		if(objeto == "cubo2"){
			GameObject.Find("cubo2").transform.Rotate(45, 0, 0);
		}
		if(objeto == "cubo3"){
			GameObject.Find("cubo3").transform.Rotate(45, 0, 0);
		}
		if(objeto == "cubo4"){
			GameObject.Find("cubo4").transform.Rotate(45, 0, 0);
		}
	}

	public void BtnRotarXN(){
		if(objeto == "cubo1"){
			GameObject.Find("cubo1").transform.Rotate(-45, 0, 0);
		}
		if(objeto == "cubo2"){
			GameObject.Find("cubo2").transform.Rotate(-45, 0, 0);
		}
		if(objeto == "cubo3"){
			GameObject.Find("cubo3").transform.Rotate(-45, 0, 0);
		}
		if(objeto == "cubo4"){
			GameObject.Find("cubo4").transform.Rotate(-45, 0, 0);
		}
	}

	public void BtnRotarZP(){
		if(objeto == "cubo1"){
			GameObject.Find("cubo1").transform.Rotate(0, 0, 45);
		}
		if(objeto == "cubo2"){
			GameObject.Find("cubo2").transform.Rotate(0, 0, 45);
		}
		if(objeto == "cubo3"){
			GameObject.Find("cubo3").transform.Rotate(0, 0, 45);
		}
		if(objeto == "cubo4"){
			GameObject.Find("cubo4").transform.Rotate(0, 0, 45);
		}
	}

	public void BtnRotarZN(){
		if(objeto == "cubo1"){
			GameObject.Find("cubo1").transform.Rotate(0, 0, -45);
		}
		if(objeto == "cubo2"){
			GameObject.Find("cubo2").transform.Rotate(0, 0, -45);
		}
		if(objeto == "cubo3"){
			GameObject.Find("cubo3").transform.Rotate(0, 0, -45);
		}
		if(objeto == "cubo4"){
			GameObject.Find("cubo4").transform.Rotate(0, 0, -45);
		}
	}
}
