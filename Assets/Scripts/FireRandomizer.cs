using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireRandomizer : MonoBehaviour
{
	[SerializeField]
	private Vector3[] fireGasPositions;
	[SerializeField]
	private Vector3[] fireElectricalPositions;

	public bool FireElectrical;
	
	private void RandomizeGasPosition(int min, int max){
		this.transform.position = fireGasPositions[Random.Range(min,max)];
	}
	
	private void RandomizeElectricalPosition(int min, int max){
		this.transform.position = fireElectricalPositions[Random.Range(min,max)];
	}
	private void Start() {
		
		if(Random.value >= 0.5) FireElectrical = true;
		else FireElectrical = false;

		switch (FireElectrical)
		{
			case true:
				this.transform.tag = "ObjectFireElectrical";
				RandomizeElectricalPosition(0, fireElectricalPositions.Length);
				break;

			case false:
				this.transform.tag = "ObjectFire";
				RandomizeGasPosition(0, fireGasPositions.Length);
				break;
		}
	}
}
