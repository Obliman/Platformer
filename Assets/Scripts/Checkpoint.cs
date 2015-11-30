using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

    bool trig = false;
    public ParticleSystem sys;
    Vector3 pos;

    void Start(){
        pos = new Vector3(transform.position.x,transform.position.y,0.0f);
        sys.enableEmission = false;
    }

    void OnTriggerEnter2D(){
        if(!trig && SpawnManager.spawnPos != pos){
            SpawnManager.spawnPos = pos;
            trig = true;
            sys.enableEmission = true;
        }
    }
}
