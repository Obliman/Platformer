using UnityEngine;
using System.Collections;

public class WaveMove : MonoBehaviour {

    float liveTime = 0.1f;

	void Start () {
        var dir = Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
        var angle = Mathf.Atan2(dir.y,dir.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
        transform.rigidbody2D.velocity = transform.right*20.0f;
	}

    void FixedUpdate(){
        liveTime -= Time.deltaTime;

        if(liveTime <= 0){
            Destroy(transform.gameObject);
        }
    }
}
