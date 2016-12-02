using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
public float xMax = 10;
  public float yMax = 5;
  public float speed = 2f;
	public Sprite stop = Resources.Load("Sadrocket", typeof(Sprite)) as Sprite;
	public Sprite start = Resources.Load("churchillrocket", typeof(Sprite)) as Sprite;
    public GameObject bullet;
    void Update()
    {
		SpriteRenderer spriteRenderer = gameObject.GetComponent<Renderer>() as SpriteRenderer;
		int multiplier = 1;
        if (Input.GetKeyDown(KeyCode.X))
            GameObject.Instantiate(bullet, transform.position, transform.rotation);
        if (Input.GetKey(KeyCode.W) == true)
			multiplier = 3;
		//var move = new Vector3(1,1,0);
    var move = (((Input.GetKey(KeyCode.W)) ? 1:0) - ((Input.GetKey(KeyCode.S))?1:0)) * transform.up;
        // transform.Rotate(10 * Vector3.forward * Time.deltaTime);
		transform.position += move * speed * Time.deltaTime * multiplier;
		if (Input.GetKey(KeyCode.W)) {
			spriteRenderer.sprite = Resources.Load ("churchillrocket", typeof(Sprite)) as Sprite;
		} else {
			spriteRenderer.sprite = Resources.Load ("Sadrocket", typeof(Sprite)) as Sprite;
		}
        //Vector3 v3 = new Vector3(0, Input.GetAxis("Horizontal"), 0);
        transform.Rotate(0.0f , 0.0f, -(((Input.GetKey(KeyCode.D)) ? 1:0) - ((Input.GetKey(KeyCode.A))?1:0)) * speed);
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
