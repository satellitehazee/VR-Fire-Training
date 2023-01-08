using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Waypoint : MonoBehaviour
{
    [SerializeField]
    private GameObject WaypointPrefab;
    private TMPro.TMP_Text WaypointDetails;
    [SerializeField]
    private WaypointScriptableObject _waypointData;

    // Start is called before the first frame update
    void Start()
    {
        SpawnWaypoint(_waypointData);
        //Debug.Log(_waypointData.WaypointDetails);
    }
    public void SpawnWaypoint(WaypointScriptableObject waypointData){
        if(GameObject.Find("WaypointTest(Clone)")){
            Destroy(GameObject.Find("WaypointTest(Clone)"));
        }
        GameObject Waypoint = Instantiate(WaypointPrefab);
        Transform _waypointPosition = Waypoint.GetComponent<Transform>();
        _waypointPosition.position = waypointData.SpawnPosition;
        TMPro.TMP_Text _questdetail = transform.GetChild(1).GetComponent<TMPro.TMP_Text>();
        _questdetail.text = waypointData.WaypointDetails;
    }
    
}
