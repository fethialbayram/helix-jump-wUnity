using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{

    public Transform player;
    public GameObject[] childRings;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {

        if (transform.position.y > player.position.y)
        {
            for (int i = 0; i < childRings.Length; i++)
            {
                childRings[i].GetComponent<Rigidbody>().isKinematic = false;
                childRings[i].GetComponent<Rigidbody>().useGravity = true;

            }


        }
        
    }

}
