using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public SliderValue sliderValue;

    public float forwardForce = 7000;
    public float sideForce = 90;

    public void AdjustSpeed(float newSpeed)
    {
	forwardForce = newSpeed;
	Debug.Log(forwardForce);
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d")) {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a")) {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
	if (rb.position.y < -3f) {
	    FindObjectOfType<GameManager>().EndGame();
	}
    }
}
