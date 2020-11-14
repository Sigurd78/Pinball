using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rujnuj : MonoBehaviour
{
    public Transform spawnpoint;
    public GameObject ballPrefab;
    public int Balls = 4;

    /*private void Awake()
    {
        Transform launchPointTrans = transform.Find("SpawnPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPos = launchPointTrans.position;

    }*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        
        
        if (collidedWith.tag == "Ball")
        {
            Balls -= 1;
            if (Balls > 0)
            {
                BallDrop();
            }

            Destroy(collidedWith);
            //Balls--;
        }

    }
    void BallDrop()
    {
        /* ballPrefab = Instantiate<GameObject>(ballPrefab);
         ballPrefab.transform.position = launchPos;
         ballRigidbody = ballPrefab.GetComponent<Rigidbody>();
         ballRigidbody.isKinematic = true;*/
        Instantiate(ballPrefab, spawnpoint.transform.position, Quaternion.identity);

    }
}
