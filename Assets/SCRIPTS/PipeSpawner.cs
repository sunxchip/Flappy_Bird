using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnTime = 1.5f;
    public float timer; // 변수 초가화시 자동으로 할당
    public float height = 0.45f;


    void Update()
    {
        if(timer > spawnTime)
        {
        SpawnPipe();
        timer =0;
        }
        timer += Time.deltaTime;
    }

    void SpawnPipe()
    {
        Vector3 spawnPosition = pipePrefab.transform.position + Vector3.up * Random.Range(-height,height);
        GameObject newPipe = Instantiate(pipePrefab,
        spawnPosition,
        Quaternion.identity);

        Destroy(newPipe,10f);
    }
}
