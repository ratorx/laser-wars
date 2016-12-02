using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        var move = Input.GetAxis("Vertical") * transform.up;
        // transform.Rotate(10 * Vector3.forward * Time.deltaTime);
        transform.position += move * speed * Time.deltaTime;

        //Vector3 v3 = new Vector3(0, Input.GetAxis("Horizontal"), 0);
        transform.Rotate(0.0f , 0.0f, -Input.GetAxis("Horizontal") * speed);
        // transform.Rotate(v3 * speed * Time.deltaTime);
    }
}