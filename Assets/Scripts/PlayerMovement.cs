using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;

	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
            
            { rb.AddForce(sidewaysForce,0,0 * Time.deltaTime); }
        if (Input.GetKey("a"))
           { rb.AddForce(-sidewaysForce, 0, 0 * Time.deltaTime); }
        if (rb.position.y < -20f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
	}
}
            // || Input.GetTouch(0).position.x > Screen.width / 2)
