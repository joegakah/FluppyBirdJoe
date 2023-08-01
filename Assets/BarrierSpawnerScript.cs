using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawnerScript : MonoBehaviour
{
    public GameObject barrier;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 4;
    // Start is called before the first frame update
    void Start()
    {
        spawnBarrier();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnBarrier();
            timer = 0;
            
        }
    }

    void spawnBarrier()
    {
        float highestPoint = transform.position.y + 10;
        float lowestPoint = transform.position.y - 10;
        Instantiate(barrier, new Vector3(transform.position.x, Random.Range(highestPoint, lowestPoint), 0), transform.rotation);

    }
}
