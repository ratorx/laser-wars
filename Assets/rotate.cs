using UnityEngine;

public class rotate : MonoBehaviour 
{
	void Update() 
	{
		Vector3 all = new Vector3 (1, -3, 2);
		// Rotate the object around its local X axis at 1 degree per second
		transform.Rotate(50 * all * Time.deltaTime );
		// Random r = new Random ();
		float bound = 0.2f;
		Vector3 movement = new Vector3 (Random.Range(-bound, bound), Random.Range(-bound, bound), Random.Range(-bound, bound));
		transform.position += movement;

		// ...also rotate around the World's Y axis
		//transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}
}