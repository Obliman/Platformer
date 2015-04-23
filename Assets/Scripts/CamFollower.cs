using UnityEngine;
using System.Collections;

public class CamFollower : MonoBehaviour {

    float depth = 0;

    void Start(){
        depth = transform.position.z;
    }

	void FixedUpdate () {
        transform.position = new Vector3(PlayerMove.position.x,PlayerMove.position.y,depth);
	}
}
