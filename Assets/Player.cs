using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 5f;
	public Sprite stop = Resources.Load("Sadrocket", typeof(Sprite)) as Sprite;
	public Sprite start = Resources.Load("churchill", typeof(Sprite)) as Sprite;
    void Update()
    {
		SpriteRenderer spriteRenderer = gameObject.GetComponent<Renderer>() as SpriteRenderer;
		int multiplier = 1;
		if (Input.GetAxis ("Vertical") > 0)
			multiplier = 3;
		
        var move = Input.GetAxis("Vertical") * transform.up;
        // transform.Rotate(10 * Vector3.forward * Time.deltaTime);
		transform.position += move * speed * Time.deltaTime * multiplier;
		if (Input.GetAxis ("Vertical") <= 0) {
			spriteRenderer.sprite = Resources.Load ("Sadrocket", typeof(Sprite)) as Sprite;
		} else {
			spriteRenderer.sprite = Resources.Load ("churchillrocket", typeof(Sprite)) as Sprite;
		}
        //Vector3 v3 = new Vector3(0, Input.GetAxis("Horizontal"), 0);
        transform.Rotate(0.0f , 0.0f, -Input.GetAxis("Horizontal") * speed);
        // transform.Rotate(v3 * speed * Time.deltaTime);
    }
}
