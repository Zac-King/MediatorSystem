using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour
{
    private float EnemySpawnTimer = 5;
    private float timer = 0f;
    private int incramentor = 0;

    public GameObject EnemyToSpawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;

        if(timer > EnemySpawnTimer)
        {
            Instantiate(EnemyToSpawn, new Vector3(incramentor,0,0), new Quaternion (0,0,0,0));
            incramentor++;
            timer = 0;
        }
	}
}
