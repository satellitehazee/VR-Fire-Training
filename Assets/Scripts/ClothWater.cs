using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothWater : MonoBehaviour
{
	private void OnTriggerEnter(Collider collision) {
		if(collision.gameObject.CompareTag("ObjectGrab")){
			Debug.Log("Cloth is wet!");
			//change objectgrab color to blue
			collision.gameObject.GetComponent<Renderer>().material.SetColor("Cloth",Color.blue);
			//change objectgrab tag or update variable
		}
		
	}
}
