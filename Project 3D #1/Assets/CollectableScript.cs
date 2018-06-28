using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour {

	HUD_Manager hudmanager;
	public int points;
	
	// Use this for initialization
	void Start () {
		hudmanager = GameObject.FindGameObjectWithTag("Player").GetComponent<HUD_Manager>();
	}

	// Update is called once per frame
	void Update () {

	}

void OnTriggerEnter(Collider other)
{
	if (other.gameObject.CompareTag("Player")) {
		gameObject.SetActive(false);
		hudmanager.UpdateScore(points);
		}

	}

}
