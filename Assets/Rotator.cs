using UnityEngine;

public class Rotator : MonoBehaviour {

    public float speed;

	void Update () 
    {
        transform.Rotate(speed, speed, speed * Time.deltaTime);
	}
}
