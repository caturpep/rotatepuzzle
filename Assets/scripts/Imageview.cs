using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imageview : MonoBehaviour {


	public GameObject gambar1;

	void Start()
	{

		gambar1.SetActive (false);

	}

	public void aktifgambar()
	{
		gambar1.SetActive (true);
	}
		
	public void tidakaktif()
	{
		gambar1.SetActive (false);
	}





}
