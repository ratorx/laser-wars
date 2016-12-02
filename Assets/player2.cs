using UnityEngine;
using System.Collections;

public class player2 : MonoBehaviour
{
public float xMax = 10;
  public float yMax = 5;
  public float speed = 2f;
	public Sprite stop = Resources.Load("sadbadrocket", typeof(Sprite)) as Sprite;
	public Sprite start = Resources.Load("badrocket", typeof(Sprite)) as Sprite;
    public GameObject bullet;

    void Update()
    {
		SpriteRenderer spriteRenderer = gameObject.GetComponent<Renderer>() as SpriteRenderer;
		int multiplier = 1;
		if (Input.GetKey(KeyCode.I) == true)
			multiplier = 3;
        if (Input.GetKeyDown(KeyCode.N))
            GameObject.Instantiate(bullet, transform.position, transform.rotation);
        //var move = new Vector3(1,1,0);
        var move = (((Input.GetKey(KeyCode.I)) ? 1:0) - ((Input.GetKey(KeyCode.K))?1:0)) * transform.up;
        // transform.Rotate(10 * Vector3.forward * Time.deltaTime);
		transform.position += move * speed * Time.deltaTime * multiplier;
		if (Input.GetKey(KeyCode.I)) {
			spriteRenderer.sprite = Resources.Load ("badrocket", typeof(Sprite)) as Sprite;
		} else {
			spriteRenderer.sprite = Resources.Load ("sadbadrocket", typeof(Sprite)) as Sprite;
		}
        //Vector3 v3 = new Vector3(0, Input.GetAxis("Horizontal"), 0);
        transform.Rotate(0.0f , 0.0f, -(((Input.GetKey(KeyCode.L)) ? 1:0) - ((Input.GetKey(KeyCode.J))?1:0)) * speed);
	  if (transform.position.x > xMax) {
  transform.position = new Vector3(-xMax, transform.position.y, transform.position.z);
} else if (transform.position.x < -xMax) {
  transform.position = new Vector3(xMax, transform.position.y, transform.position.z);
}
if (transform.position.y > yMax) {
  transform.position = new Vector3(transform.position.x, -yMax, transform.position.z);
} else if (transform.position.y < -yMax) {
  transform.position = new Vector3(transform.position.x, yMax, transform.position.z);
}
        // transform.Rotate(v3 * speed * Time.deltaTime);
    } // Dun goofed.
}
