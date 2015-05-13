using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public static int charges = 8;
    public static Vector3 position;
	float chargeTime = 0.0f;
	float genTime = 0.5f;
	int maxCharges = 8;
    public Sprite[] img;

    void Start(){
        position = transform.position;
    }

	void FixedUpdate () {
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
