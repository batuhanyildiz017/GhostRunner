using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;
    private float timeBtwSpawn;
    public float starttimeBtwSpawn;
    public float decreaseTime; //azaltma zaman�
    public float minTime = 0.65f;
    int rand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameOver==false) { //oyun bitmediyse can 0lanmad�ysa
            rand = Random.Range(0, obstaclePatterns.Length);  //patterns dizisi uzunlu�unda random de�er
            if (timeBtwSpawn <= 0)
            {
                Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);  //rastgele pattern olu�turma
                                                                                               //bu olu�turdu�umuz objenin i�inde spawnpoint scripti var onunla obstacle � olu�turuyoz
                timeBtwSpawn = starttimeBtwSpawn;
                if (starttimeBtwSpawn > minTime)
                    starttimeBtwSpawn -= decreaseTime;
            }
            else
            {
                timeBtwSpawn -= Time.deltaTime;
            }
        }
        
    }
}
