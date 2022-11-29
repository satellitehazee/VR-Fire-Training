using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabInteract : MonoBehaviour
{
	
	private void OnTriggerEnter(Collider collision) {
		if(collision.gameObject.CompareTag("ObjectGrab")){
			Debug.Log("hit success");
		}
		
	}
	
}
