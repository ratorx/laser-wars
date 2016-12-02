using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
  public float speed = 5f;
	public Sprite stop = Resources.Load("Sadrocket", typeof(Sprite)) as Sprite;
	public Sprite start = Resources.Load("churchillrocket", typeof(Sprite)) as Sprite;
  void Update()
    {
		SpriteRenderer spriteRenderer = gameObject.GetComponent<Renderer>() as SpriteRenderer;
		int multiplier = 1;
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
        // transform.Rotate(v3 * speed * Time.deltaTime);
    } // Dun goofed.
}
