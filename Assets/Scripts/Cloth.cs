using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloth : MonoBehaviour
{
    [SerializeField]
    private Material wetMaterial;
    private bool isWet = false;
    private void OnTriggerEnter(Collider other) {
    if(other.gameObject.name == "WaterHitbox"){
            Debug.Log("Cloth is wet!");
            //change objectgrab color to blue
            this.gameObject.GetComponent<MeshRenderer>().material = wetMaterial;
            isWet = true;
            //change objectgrab tag or update variable
        }
    if(other.gameObject.name == "Fire" && isWet == true){
			Debug.Log("Fire extinguished!");
			Destroy(other.gameObject);
		}
   }
   
}