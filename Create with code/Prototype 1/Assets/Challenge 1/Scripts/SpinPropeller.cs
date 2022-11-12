using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    const float rotationsPerSecond = 10f;

    void Update()
    {
        transform.RotateAround(transform.position,
                                                  transform.forward,
                                                  rotationsPerSecond * 360 * Time.deltaTime);
    }
}
