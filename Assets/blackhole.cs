using UnityEngine;

public class blackhole : MonoBehaviour
{
	void Update()
	{
		float xMax = 10;
		float yMax = 5;
		// Rotate the object around its local X axis at 1 degree per second
		transform.Rotate(10 * Vector3.forward * Time.deltaTime );
		// Random r = new Random ();
		float bound = 0.3f;
		float xmovement = Random.Range(-bound, bound);
		float ymovement = Random.Range(-bound, bound);
	//transform.position = new Vector3(- xMax, transform.position.y, transform.position.z);
		if ((transform.position.x > xMax && xmovement > 0) || (transform.position.x < -xMax && xmovement < 0))
			xmovement = -xmovement;
		else if ((transform.position.y < -yMax && ymovement < 0) || (transform.position.y > yMax && ymovement > 0))
			ymovement = -ymovement;

		Vector3 movement = new Vector3 (xmovement, ymovement,0);
		transform.position += movement;
		// ...also rotate around the World's Y axis
		//transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}
}
