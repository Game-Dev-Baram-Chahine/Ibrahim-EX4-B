using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject playerObject;
    private float horizontalInput;
    public float spawnTime;
    public int spawnPosition;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0)
        {
            SpawnCar();
            spawnTime = 4;
        }
    }

    void SpawnCar()
    {
        Vector3 rsp = new Vector3(
            playerObject.transform.position.x + spawnPosition,
            playerObject.transform.position.y,
            playerObject.transform.position.z
        );
        Instantiate(
            carPrefab,
            rsp,
            transform.rotation
                * Quaternion.Euler(
                    playerObject.transform.rotation.x,
                    -90,
                    playerObject.transform.rotation.z
                )
        );
        ScoreManager.points++;
    }
}
