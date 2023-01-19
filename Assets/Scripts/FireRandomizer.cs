using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireRandomizer : MonoBehaviour
{
	[SerializeField]
	private Vector3[] fireGasPositions;
	[SerializeField]
	private Vector3[] fireElectricalPositions;
	private float timer;
	private int scaleCount = 0;
	Transform[] allchild;

	public bool FireElectrical;
	public bool isExtinguishable;
	public bool isClear;

	public GameObject particleFire;
	public GameObject particleFireDark;

	
	private void RandomizeGasPosition(int min, int max){
		this.transform.position = fireGasPositions[Random.Range(min,max)];
	}
	
	private void RandomizeElectricalPosition(int min, int max){
		this.transform.position = fireElectricalPositions[Random.Range(min,max)];
	}
	private void Start() {
		isExtinguishable = true;
		isClear = false;
		timer = 15.0f;
		allchild = this.transform.GetChild(0).GetComponentsInChildren<Transform>();
		if(Random.value >= 0.5) FireElectrical = true;
		else FireElectrical = false;

		switch (FireElectrical)
		{
			case true:
				this.transform.tag = "ObjectFireElectrical";
				RandomizeElectricalPosition(0, fireElectricalPositions.Length);
				break;

			case false:
				this.transform.tag = "ObjectFire";
				RandomizeGasPosition(0, fireGasPositions.Length);
				break;
		}

	}
	private void Update()
	{
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			for (int i = 0; i < allchild.Length; i++)
			{
				if (scaleCount < 8)
				{
					allchild[i].transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
					particleFireDark.SetActive(true);
				}
				else if (scaleCount < 12)
				{
					allchild[i].transform.localScale += new Vector3(0.12f, 0.12f, 0.12f);
				}
				else if (scaleCount < 20)
				{
					allchild[i].transform.localScale += new Vector3(0.15f, 0.15f, 0.15f);
					particleFire.SetActive(true);
				}
				else if (scaleCount < 35)
				{
					allchild[i].transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
				}
				else if (scaleCount < 45)
				{
					allchild[i].transform.localScale += new Vector3(1f, 1f, 1f);
					isExtinguishable = false;
				}
				else if (scaleCount >= 50)
				{
					allchild[i].transform.localScale += new Vector3(2f, 2f, 2f);

				}
			}
			timer = 3.0f;
			scaleCount++;
			if (scaleCount == 35)
			{
				Debug.Log("Evacuate!");
			}
		}
	}
}
