using UnityEngine;
using System.Collections;

public class spawnAlien : MonoBehaviour
{
	public GameObject prefab;

	void Start()
	{
		for (int i = 0; i < 10; i++)
			Instantiate(prefab, new Vector3(Random.Range(-8f, 8f), Random.Range(-5f, 5f), 0), Quaternion.identity);
	}
}