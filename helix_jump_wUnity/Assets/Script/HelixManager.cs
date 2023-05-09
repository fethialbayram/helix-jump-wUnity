using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixManager : MonoBehaviour
{

    public GameObject[] rings;

    public int noOfRings = 10;
    public float ringDistance = 5f;
    float yPos;

    void SpawnRings(int index)
    {

        GameObject newRing = (rings[index],new Vec (transform.position))

    }

}
