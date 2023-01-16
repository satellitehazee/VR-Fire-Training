using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireRandomizer : MonoBehaviour
{
	[SerializeField]
	private Vector3[] arrayPositions;
	public bool FireElectrical;
	
	private void RandomizePosition(int min, int max){
		this.transform.position = arrayPositions[Random.Range(min,max)];
	}
	private void Start() {
		RandomizePosition(0,arrayPositions.Length);
		
		if(Random.value >= 0.5) FireElectrical = true;
		else FireElectrical = false;

		switch (FireElectrical)
		{
			case true:
			this.transform.tag = "ObjectFireElectrical";
			break;

			case false:
			this.transform.tag = "ObjectFire";
			break;
		}
	}
}
