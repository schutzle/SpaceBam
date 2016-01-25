using UnityEngine;
using System.Collections;

public class SpawnOnContact : MonoBehaviour {

	public GameObject[] enemies;
	public float spawnWait;
	public float startWait;
	public Transform spawnPosition;

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag ("Boundary")) {
			StartCoroutine (SpawnEnemies (transform));
		}
	}

	IEnumerator SpawnEnemies (Transform transform)
	{
		yield return new WaitForSeconds (startWait);
		foreach (GameObject enemy in enemies) {
			Instantiate (enemy, transform.position, transform.rotation);
			yield return new WaitForSeconds (spawnWait);
		}
	}
}
