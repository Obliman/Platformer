using UnityEngine;
using System.Collections;

public class PlayerWave : MonoBehaviour {

    public GameObject wave;
	
	void FixedUpdate () {
	    if(Input.GetMouseButtonDown(0) && PlayerMove.charges > 0){
            Instantiate(wave,transform.position,Quaternion.identity);
            PlayerMove.charges--;

            var dir = Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
            //transform.rigidbody2D.velocity = -dir/Vector2.Distance(transform.position,Camera.main.ScreenToWorldPoint(Input.mousePosition))*5.0f;
            transform.rigidbody2D.AddForce(-dir/Vector2.Distance(transform.position,Camera.main.ScreenToWorldPoint(Input.mousePosition))*300.0f);
        }
	}
}
