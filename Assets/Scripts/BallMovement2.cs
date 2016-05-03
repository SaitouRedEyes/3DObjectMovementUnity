using UnityEngine;
using System.Collections;

public class BallMovement2 : MonoBehaviour 
{
    private string direction;
    private float speedTranslation, angle;

	void Start () 
    {
        direction = "foward";
        speedTranslation = 0.2f;
        angle = 0;
	}
	
	void Update () 
    {
        MoveBehaviour();
	}

    private void MoveBehaviour()
    {
        if (direction.Equals("foward") && this.transform.localPosition.z > 24) direction = "left";
        else if (direction.Equals("left") && this.transform.localPosition.x < -24) direction = "up";
        else if (direction.Equals("up") && this.transform.localPosition.y > 6) direction = "back";
        else if (direction.Equals("back") && this.transform.localPosition.z < 0) direction = "down";
        else if (direction.Equals("down") && this.transform.localPosition.y < 3 && this.transform.localPosition.x < 0) direction = "right";
        else if (direction.Equals("right") && this.transform.localPosition.x > 0) direction = "down";
        else if (direction.Equals("down") && this.transform.localPosition.y < 0) direction = "foward";

        switch (direction)
        {
            case "foward": Transformations(Vector3.forward, 5.0f); break;
            case "up": Transformations(Vector3.up, 0.0f); break;
            case "left": Transformations(Vector3.left, -5.0f); break;
            case "down": Transformations(Vector3.down, 0.0f); break;
            case "back": Transformations(Vector3.back, -5.0f); break;
            case "right": Transformations(Vector3.right, -5.0f); break;
        }
    }

    private void Transformations(Vector3 direction, float newAngle)
    {
        this.transform.localPosition += direction * speedTranslation;
        angle += newAngle;
        this.transform.localEulerAngles = new Vector3(angle, 0, 0);
    }
}









