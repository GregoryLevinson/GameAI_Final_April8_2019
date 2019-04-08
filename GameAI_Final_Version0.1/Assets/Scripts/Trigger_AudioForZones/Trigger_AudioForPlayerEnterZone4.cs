using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_AudioForPlayerEnterZone4 : MonoBehaviour
{
    [SerializeField]
    AudioSource zone4audio;

    // Start is called before the first frame update
    void Start()
    {
        zone4audio.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Audio for Zone_4_ Played");
            zone4audio.Play();
        }
        else
        {
            Debug.Log("Audio for Zone_4_ Idle");
        }
    }
}
