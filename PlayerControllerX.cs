﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogSpawnInterval = 1;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        while (Input.GetKeyDown(KeyCode.Space) && dogSpawnInterval ==1)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogSpawnInterval = 0;
            Invoke("ResetInterval", 1);
        }
    }


    void ResetInterval()
    {
        dogSpawnInterval = 1;
    }
}
