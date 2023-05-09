using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixRotator : MonoBehaviour
{

    public float rotationSpeed;

    public void Update()
    {

        if (Input.GetMouseButton(0))
        {

            float mouseX = Input.GetAxisRaw("Mouse X");
            transform.Rotate(transform.position.x, -mouseX * rotationSpeed * Time.deltaTime, transform.position.z);

        }

    }

}
