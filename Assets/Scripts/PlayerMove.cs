using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public static int charges = 1;
    public static Vector3 position;
	float chargeTime = 0.0f;
	float genTime = 1.0f;
	int maxCharges = 8;
	//bool keyReleased = false;
    public Sprite[] img;

	void FixedUpdate () {
        /*
		if (Input.GetKeyDown (KeyCode.W) && charges > 0 && keyReleased) {
			transform.rigidbody2D.velocity = new Vector2 (transform.rigidbody2D.velocity.x, 5.0f);
			charges--;
			keyReleased = false;
		}
        if (Input.GetKeyUp (KeyCode.W)){
            keyReleased = true;
        }
		if (Input.GetKey (KeyCode.A)) {
			transform.rigidbody2D.velocity = new Vector2(-1.0f,transform.rigidbody2D.velocity.y);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.rigidbody2D.velocity = new Vector2(1.0f,transform.rigidbody2D.velocity.y);
		}
        */
        position = transform.position;
        GetComponent<SpriteRenderer>().sprite = img[charges];
	}

	void OnTriggerStay2D(){
        if(charges < maxCharges){
		    chargeTime += Time.deltaTime;
        }else{
            chargeTime = 0;
        }

		if (chargeTime >= genTime && charges < maxCharges) {
			charges++;
			chargeTime = 0;
		}
	}

	void OnTriggerExit2D(){
		chargeTime = 0;
	}
}
