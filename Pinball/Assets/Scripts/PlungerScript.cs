using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerScript : MonoBehaviour
{
    float power = 0f;
    //float minPower = 0f;
    public float maxPower = 100f;
    public Slider powerSlider;
    //public List<Rigidbody> ballList;
    Rigidbody ball;
    bool ballReady;
    public string shoot;
    
    // Start is called before the first frame update
    void Start()
    {
        powerSlider.minValue = 0f;
        powerSlider.maxValue = maxPower;
        //ballList = new List<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        powerSlider.value = power;
        if (ball != null)
        {
            if (Input.GetAxis(shoot) == 1)
            {
                if (power <= maxPower)
                {
                    power += 500 * Time.deltaTime;
                }
            }
            else
            {
                ball.AddForce(power * Vector3.forward);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            powerSlider.gameObject.SetActive(true);
            ball = other.gameObject.GetComponent<Rigidbody>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            powerSlider.gameObject.SetActive(false);
            ball = null;
            power = 0f;
        }
    }
}