using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour {

	publi int AttackDamage;

	private void OnTrigerEnter(Collider other)
		{
			EnemyStats = other.gameObject.GetComponent<EnemyStats>();

			if (enemystats != null)
			{
					enemystats.UpdateHealth(AttackDamage)
			}

		}

	}
