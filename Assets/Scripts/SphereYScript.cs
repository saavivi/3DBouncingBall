using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereYScript : MonoBehaviour
{
    private float sphereYPosition;
    public GameObject textDisplay;

    // Update is called once per frame
    void Update()
    {
        sphereYPosition = GameObject.Find("Sphere").transform.position.y;
        textDisplay.GetComponent<Text>().text = "Height: " + sphereYPosition.ToString();
    }
}
