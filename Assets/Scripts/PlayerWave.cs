using UnityEngine;
using System.Collections;

public class PlayerWave : MonoBehaviour {

    public GameObject wave;
    public ParticleSystem part;
    bool initPress = true;
    float useRate = 0.75f;
    float useTime = 0.0f;
    	
	void FixedUpdate () {
	    if(Input.GetMouseButtonDown(0) && PlayerMove.charges > 0){
            Instantiate(wave,transform.position,Quaternion.identity);
            PlayerMove.charges--;

            var dir = Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
            //transform.rigidbody2D.velocity = -dir/Vector2.Distance(transform.position,Camera.main.ScreenToWorldPoint(Input.mousePosition))*5.0f;
            transform.rigidbody2D.AddForce(-dir/Vector2.Distance(transform.position,Camera.main.ScreenToWorldPoint(Input.mousePosition))*300.0f);
        }

        if(Input.GetMouseButton(1) && PlayerMove.charges > 0){
            if(initPress){
                PlayerMove.charges--;
                initPress = false;
            }
            
            useTime += Time.deltaTime;
            
            if(useTime <= useRate){
                transform.rigidbody2D.gravityScale = 0.0f;
                part.enableEmission = true;
            }else{
                transform.rigidbody2D.gravityScale = 1.0f;
                useTime = 0.0f;
                PlayerMove.charges--;
            }
        }else{
            initPress = true;
            transform.rigidbody2D.gravityScale = 1.0f;
            part.enableEmission = false;
            useTime = 0.0f;
        }
	}
}
