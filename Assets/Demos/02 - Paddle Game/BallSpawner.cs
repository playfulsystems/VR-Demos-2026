using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject BallPrefab;
    float spawnRate = 3f;
    float spawnTime;
    Material material;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTime = spawnRate;
        material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < 0.5)
        {
            material.color = Color.red;
        }

        if (spawnTime < 0)
        {
            GameObject ball = Instantiate(BallPrefab);
            ball.transform.position = transform.position;
            spawnTime = spawnRate;
            material.color = Color.gray;
        }

        spawnTime -= Time.deltaTime;
    }
}
