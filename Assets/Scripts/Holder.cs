using UnityEngine;
using System.Collections;

public class Holder : MonoBehaviour {

    Quaternion angle;

	void Start () {
        angle = transform.rotation;    
	}
	
	void FixedUpdate () {
        transform.rotation = angle;
	}
}
