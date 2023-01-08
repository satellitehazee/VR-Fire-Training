using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWaypointData", menuName = "ScriptableObjects/WaypointData", order = 1)]
public class WaypointScriptableObject : ScriptableObject
{
    public string WaypointName;
    public GameObject SpawnParent;
    public Vector3 SpawnPosition;
    public WaypointScriptableObject nextWaypoint;
    public WaypointScriptableObject prevWaypoint;
}
