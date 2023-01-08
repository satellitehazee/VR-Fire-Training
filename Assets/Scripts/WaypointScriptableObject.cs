using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWaypointData", menuName = "ScriptableObjects/WaypointData", order = 1)]
public class WaypointScriptableObject : ScriptableObject
{
    [TextArea]
    public string WaypointDetails;
    public Vector3 SpawnPosition;
    public WaypointScriptableObject nextWaypoint;
}
