using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour 
{
    private string direction;
    private float speedTranslation, angle;

	// Use this for initialization
	void Awake () 
    {
        direction = "right";
        speedTranslation = 0.1f;
        angle = 0;
	}
	
	// Update is called once per frame
	void Update () 
    {
       MoveBehaviour();
	}

    private void MoveBehaviour()
    {
        if (direction.Equals("right") && this.transform.localPosition.z >= 24) direction = "up";
        else if (direction.Equals("up") && this.transform.localPosition.y >= 8) direction = "left";
        else if (direction.Equals("left") && this.transform.localPosition.z <= 0) direction = "down";
        else if (direction.Equals("down") && this.transform.localPosition.y <= 0) direction = "right";

        switch (direction)
        {
            case "right": Transformations(Vector3.forward, 5.0f); break;
            case "up":    Transformations(Vector3.up, 0.0f);      break;
            case "left":  Transformations(Vector3.back, -5.0f);   break;
            case "down":  Transformations(Vector3.down, 0.0f);    break;
        }
    }

    private void Transformations(Vector3 direction, float newAngle)
    {
        this.transform.localPosition += direction * speedTranslation;
        angle += newAngle;
        this.transform.localEulerAngles = new Vector3(angle, 0, 0);
    }
}









