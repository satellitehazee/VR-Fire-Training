using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireRandomizer : MonoBehaviour
{
	[SerializeField]
	private Vector3[] arrayPositions;
	
	private void RandomizePosition(int min, int max){
		this.transform.position = arrayPositions[Random.Range(min,max)];
	}
	private void Start() {
		RandomizePosition(0,arrayPositions.Length);
	}
}
