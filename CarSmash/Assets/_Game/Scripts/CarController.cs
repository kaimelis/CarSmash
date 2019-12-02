using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float _speed = 5.0f;
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Driving forward");
        }
    }

}
