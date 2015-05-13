using UnityEngine;
using System.Collections;

public class Spike : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Player"){
            SpawnManager.respawns += 1;
        }
        Destroy(other.gameObject);
    }
}
