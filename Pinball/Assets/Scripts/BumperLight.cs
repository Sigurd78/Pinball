using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperLight : MonoBehaviour
{
    static private BumperLight BL;
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        BL = this;
        Transform BLTrans = transform.Find("Light");
        light = BLTrans.gameObject;
        light.SetActive(true);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            light.SetActive(true);
        }
    }
}
