using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{

    [SerializeField]
    private Vector3 regulatorOffPosition;

    public bool isRegulatorOff = false;

    public GameObject regulator;
    private void Start()
    {
        
    }

    public void ToggleRegulator()
    {
        isRegulatorOff = true;
        Debug.Log("Regulator is off!");
        regulator.transform.position = regulatorOffPosition;

    }
    
}
