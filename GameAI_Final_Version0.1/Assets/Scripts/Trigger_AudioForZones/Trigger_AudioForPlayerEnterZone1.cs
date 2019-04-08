﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_AudioForPlayerEnterZone1 : MonoBehaviour
{
    [SerializeField]
    AudioSource zone1audio;

    // Start is called before the first frame update
    void Start()
    {
        zone1audio.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Audio for Zone_1_ Played");
            zone1audio.Play();
        }
        else
        {
            Debug.Log("Audio for Zone_1_ Idle");
        }
    }
}