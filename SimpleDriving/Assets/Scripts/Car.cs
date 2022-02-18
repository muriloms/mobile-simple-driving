using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float speedGainPerSecond = 0.02f;
    [SerializeField] private float turnSpeed = 200f;

    private int steerValue;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += speedGainPerSecond * Time.deltaTime;
        
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Steer(int value)
    {
        steerValue = value;
    }
}
