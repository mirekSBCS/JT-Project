using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour {

	public int AttackDamage;

	void OnTriggerEnter(Collider other){
		HUD_Manager hudmanager = other.GetComponent<HUD_Manager>();

		hudmanager.UpdateHealth(AttackDamage);
	}
}
