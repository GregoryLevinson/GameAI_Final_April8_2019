using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_AudioForPlayerEnterZone3 : MonoBehaviour
{
    [SerializeField]
    AudioSource zone3audio;

    // Start is called before the first frame update
    void Start()
    {
        zone3audio.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Audio for Zone_3_ Played");
            zone3audio.Play();
        }
        else
        {
            Debug.Log("Audio for Zone_3_ Idle");
        }
    }
}
