using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCYellow : MonoBehaviour
{
    [SerializeField]
    Transform targetToBeFleedFrom;
    [SerializeField]
    int fleeSpeed = 5;
    [SerializeField]
    Transform positionOfNPCs;
    [SerializeField]
    Transform targetToFollow;
    [SerializeField]
    Transform targetToWatch;
    [SerializeField]
    int followSpeed;
    public static bool redDestroyed = false;

    //void FollowRED()
    //{
    //    transform.LookAt(targetToFollow);
    //    transform.Translate(Vector3.forward * followSpeed * Time.deltaTime);
    //}

    //void FleeAfterRedDead()
    //{
    //    transform.LookAt(targetToBeFleedFrom);
    //    transform.Translate(Vector3.back * fleeSpeed * Time.deltaTime);
    //}


    // Update is called once per frame
    void Update()
    {
       
            transform.LookAt(targetToFollow);
            transform.Translate(Vector3.forward * followSpeed * Time.deltaTime);
         if (!redDestroyed) {
            Debug.Log("RED Destroyed");
            transform.LookAt(targetToBeFleedFrom);
            transform.Translate(Vector3.back * fleeSpeed * Time.deltaTime);
        }

    }
}
