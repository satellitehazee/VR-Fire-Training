using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireWater : MonoBehaviour
{
	
	private void OnTriggerEnter(Collider collision) {
		if(collision.gameObject.CompareTag("ObjectGrab")){
			Debug.Log("Fire extinguished!");
			Destroy(GameObject.FindWithTag("ObjectFire"));
		}
		
		
	}
	
}
