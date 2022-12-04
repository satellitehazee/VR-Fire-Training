using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothWater : MonoBehaviour
{
	[SerializeField]
    private Material wetCloth;
    private void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.CompareTag("ObjectGrab")){
            Debug.Log("Cloth is wet!");
            //change objectgrab color to blue
            collision.gameObject.GetComponent<MeshRenderer>().material = wetCloth;

            //change objectgrab tag or update variable
        }
        
    }
}
