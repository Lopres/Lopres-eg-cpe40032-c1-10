﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(25, 0, 5); // Challenge#4: reposition the camera besides the plane

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Challenge#5: offset the main camera to follow the player's plane
        transform.position = plane.transform.position + offset;
    }
}