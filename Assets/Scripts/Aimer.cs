using UnityEngine;
using System.Collections;

public class Aimer : MonoBehaviour {

	void FixedUpdate () {
        var dir = Camera.main.ScreenToWorldPoint(Input.mousePosition)-PlayerMove.position;
        var angle = Mathf.Atan2(dir.y,dir.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle+180,Vector3.forward);
        transform.localPosition = new Vector2(0.3f*Mathf.Cos(angle*Mathf.Deg2Rad),0.3f*Mathf.Sin(angle*Mathf.Deg2Rad));
	}
}
