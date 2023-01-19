using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloth : MonoBehaviour
{
    [SerializeField]
    private Material wetMaterial;
    [SerializeField]
    private Material defaultMaterial;
    [SerializeField]
    private Vector3 defaultPosition;

    private bool isWet = false;
    public Fuse MyFuse;
    public Gas MyGas;
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("ObjectWater")){
            Debug.Log("Cloth is wet!");
            //change objectgrab color to blue
            this.gameObject.GetComponent<MeshRenderer>().material = wetMaterial;
            isWet = true;
            //change objectgrab tag or update variable
        }

        if(other.gameObject.CompareTag("ObjectFire")){
            if(isWet == true && MyGas.isRegulatorOff == true)
            {
                Debug.Log("Fire extinguished!");
                Destroy(other.gameObject);
            }
			else
            {
                ResetCloth();
            }
		} 


        if(other.gameObject.CompareTag("ObjectFireElectrical")) {
            if(isWet == true && MyFuse.isFuseOff == true)
            {
                Debug.Log("Fire extinguished! (Electrical)");
                Destroy(other.gameObject);
            }
            else
            {
                ResetCloth();
            }
            
        }
   }
   
    private void ResetCloth()
    {
        Debug.Log("Cloth resetted!");
        this.gameObject.GetComponent<MeshRenderer>().material = defaultMaterial;
        isWet = false;
        this.gameObject.transform.position = defaultPosition;
    }
}
