using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

    public KeyCode upCharacter;
    public KeyCode downCharacter;
    public KeyCode leftCharacter;
    public KeyCode rightCharacter;

    public KeyCode buttonOneCharacter;
    public KeyCode buttonTwoCharacter;
    public KeyCode buttonThreeCharacter;
    public KeyCode buttonFourCharacter;
    public KeyCode buttonFiveCharacter;
    public KeyCode buttonSixCharacter;

    public GameObject upLight;
    public GameObject downLight;
    public GameObject leftLight;
    public GameObject rightLight;

    public GameObject buttonOneLight;
    public GameObject buttonTwoLight;
    public GameObject buttonThreeLight;
    public GameObject buttonFourLight;
    public GameObject buttonFiveLight;
    public GameObject buttonSixLight;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        // check for joystick presses
        if (Input.GetKey(upCharacter)) upLight.SetActive(false);
        else upLight.SetActive(true);

        if (Input.GetKey(downCharacter)) downLight.SetActive(false);
        else downLight.SetActive(true);

        if (Input.GetKey(leftCharacter)) leftLight.SetActive(false);
        else leftLight.SetActive(true);

        if (Input.GetKey(rightCharacter)) rightLight.SetActive(false);
        else rightLight.SetActive(true);

        // check for button presses
        if (Input.GetKey(buttonOneCharacter)) buttonOneLight.SetActive(false);
        else buttonOneLight.SetActive(true);

        if (Input.GetKey(buttonTwoCharacter)) buttonTwoLight.SetActive(false);
        else buttonTwoLight.SetActive(true);

        if (Input.GetKey(buttonThreeCharacter)) buttonThreeLight.SetActive(false);
        else buttonThreeLight.SetActive(true);

        if (Input.GetKey(buttonFourCharacter)) buttonFourLight.SetActive(false);
        else buttonFourLight.SetActive(true);

        if (Input.GetKey(buttonFiveCharacter)) buttonFiveLight.SetActive(false);
        else buttonFiveLight.SetActive(true);

        if (Input.GetKey(buttonSixCharacter)) buttonSixLight.SetActive(false);
        else buttonSixLight.SetActive(true);
	}
}
