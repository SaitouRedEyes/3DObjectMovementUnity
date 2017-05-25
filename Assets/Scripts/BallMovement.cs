using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour 
{
    private Vector3 direction;
    private float speedTranslation;

	void Start () 
    {
        direction = Vector3.forward;
        speedTranslation = 0.2f;
	}
	
	void Update () 
    {
        MoveBehaviour();
	}

    private void MoveBehaviour()
    {
        if (direction.Equals(Vector3.forward) && this.transform.localPosition.z > 24) direction = Vector3.left;
        else if (direction.Equals(Vector3.left) && this.transform.localPosition.x < -24) direction = Vector3.up;
        else if (direction.Equals(Vector3.up) && this.transform.localPosition.y > 6) direction = Vector3.back;
        else if (direction.Equals(Vector3.back) && this.transform.localPosition.z < 0) direction = Vector3.down;
        else if (direction.Equals(Vector3.down) && this.transform.localPosition.y < 3 && this.transform.localPosition.x < 0) direction = Vector3.right;
        else if (direction.Equals(Vector3.right) && this.transform.localPosition.x > 0) direction = Vector3.down;
        else if (direction.Equals(Vector3.down) && this.transform.localPosition.y < 0) direction = Vector3.forward;

        this.transform.localPosition += direction * speedTranslation;
    }
}









