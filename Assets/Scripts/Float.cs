using UnityEngine;
using System.Collections;

public class Float : MonoBehaviour {

	float pos = 0.0f;
	float angleTime = 0.0f;
	float Yo = 0.0f;
	float Xo = 0.0f;
	float speedMod = 0.0f;

	void Start(){
		Yo = transform.position.y;
		Xo = transform.position.x;
		speedMod = Random.Range (0.5f,1.0f);
	}

	void FixedUpdate(){
		angleTime += Time.deltaTime;
		pos = 1.0f+Mathf.Sin (angleTime*speedMod);
		transform.position = new Vector2(Xo,pos+Yo);
	}
}
