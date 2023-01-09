using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
    public bool isFuseOff = false;
    
    void Start()
    {
        isFuseOff = false;
    }

    public void TurnOffFuse()
    {
        Debug.Log("Fuse is off!");
        isFuseOff = true;
    }
}
