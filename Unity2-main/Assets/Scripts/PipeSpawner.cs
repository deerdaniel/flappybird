using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    private float timer = 0;
    public float height = 5;
    public GameObject prefabPipe;
    public GameObject prefabPipeRed;
    public GameObject prefabCoin;

    // Update is called once per frame
    void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnPipe();
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        GameObject randomPipe;
        int randomPipeSpawn = Random.Range(0, 2);
        int randomCoinSpawn = Random.Range(0, 2);

        if (randomPipeSpawn == 0)
        {
            randomPipe = prefabPipe;
        }
        else
        {
            randomPipe = prefabPipeRed;
        }
        GameObject newPipe = Instantiate(randomPipe);
        GameObject newCoin;
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

        if(randomCoinSpawn == 0)
        {
            newCoin = Instantiate(prefabCoin);
            newCoin.transform.position = newPipe.transform.position + new Vector3(2, 1, 0);
        }
        
        Destroy(newPipe, 10f);
        
    }
}
