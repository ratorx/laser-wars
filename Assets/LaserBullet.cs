using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour {

    public GameObject prefab;
    // Use this for initialization
    void Start () {
        Destroy(gameObject, 2);
         }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.up*0.5f;
        
	}
}
