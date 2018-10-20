using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour {

	public float spawnRatePerSec;  //每秒重生機率
	public GameObject[] cube;  //重生的敵人種類

	void Start()
	{
		//每秒呼叫一次SpawnEnemy
		InvokeRepeating ("cube", 1f, 1f);
	}

	void SpawnEnemy()
	{
		//一定機率重生隨機一個敵人
		if (Random.value < spawnRatePerSec) {
			Instantiate (cube [Random.Range (0, cube.Length)], transform.position, Quaternion.identity);
		}
	}
}
