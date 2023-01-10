using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
    
    [SerializeField]
    private GameObject indicatorLight;
    [SerializeField]
    private Material indicatorOff;
    private Material indicatorOn;
    public bool isFuseOff = false;
    private void Start() {
        indicatorOn = indicatorLight.GetComponent<MeshRenderer>().material;
    }

    public void ToggleFuse()
    {
        if(isFuseOff == false){
            Debug.Log("Fuse is off!");
            indicatorLight.GetComponent<MeshRenderer>().material = indicatorOff;
            isFuseOff = true;
        }
        else{
            Debug.Log("Fuse is on");
            indicatorLight.GetComponent<MeshRenderer>().material = indicatorOn;
            isFuseOff = false;
        }
    }
    
}
