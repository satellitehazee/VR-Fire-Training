using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseIndicator : MonoBehaviour
{
    [SerializeField]
    private Material indicatorOff;
    public Fuse fuseStatus;
    public void SwitchOff()
    {
        if (fuseStatus.isFuseOff == true){
            this.gameObject.GetComponent<MeshRenderer>().material = indicatorOff;
        }
    }
}