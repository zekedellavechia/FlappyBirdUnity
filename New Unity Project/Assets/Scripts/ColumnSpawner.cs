using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    public GameObject columnPrefab;

    public float minY, maxY;

    float timer;

    public float maxTime;

    // Start is called before the first frame update
    void Start()
    {
        //spawn a column
        SpawnColumn();

    }

    // Update is called once per frame
    void Update()
    {
        //spawn columns cada X seconds

        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            SpawnColumn();
            timer = 0;
        }
        
    }

    void SpawnColumn()
    {

        float randYpos = Random.Range(minY,maxY);

        GameObject newColumn = Instantiate(columnPrefab);
        newColumn.transform.position = new Vector3(
        transform.position.x, randYpos);

    }
}
