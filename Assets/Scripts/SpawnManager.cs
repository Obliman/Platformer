using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    public static Vector3 spawnPos;
    public static int respawns;
    int last;
    public GameObject Player;

	void Start () {
        respawns = 0;
        last = 0;
        spawnPos = PlayerMove.position;
	}
	
    void FixedUpdate(){
        if(spawnPos == new Vector3(0.0f,0.0f,0.0f)){
            spawnPos = PlayerMove.position;
        }
        if(respawns != last){
            Instantiate(Player,spawnPos,Quaternion.identity);
            last = respawns;
        }
    }
}
