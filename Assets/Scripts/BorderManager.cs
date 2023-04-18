using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BorderManager : MonoBehaviour
{
    public GameObject leftBorder;
    public GameObject rightBorder;
    public GameObject playerCar;

    void Update()
    {
        if (
            playerCar.transform.position.z > leftBorder.transform.position.z
            || playerCar.transform.position.z < rightBorder.transform.position.z
        )
        {
            int index = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(index);
        }
    }
}
