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
    public bool isRegulatorOff = false;
    private void Start()
    {
        indicatorOn = indicatorLight.GetComponent<MeshRenderer>().material;
    }

    public void ToggleFuse()
    {
        switch (isFuseOff)
        {
            case false:
            Debug.Log("Fuse is off!");
            indicatorLight.GetComponent<MeshRenderer>().material = indicatorOff;
            isFuseOff = true;
            break;
            
            case true:
            Debug.Log("Fuse is on");
            indicatorLight.GetComponent<MeshRenderer>().material = indicatorOn;
            isFuseOff = false;
            break;

        }
    }
    public void TurnOffRegulator()
    {
        isRegulatorOff = true;
    }
    
}
