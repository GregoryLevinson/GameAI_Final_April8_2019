using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRed : MonoBehaviour
{ 

    [SerializeField]
    Transform targetToBeFollowed;
    [SerializeField]
    int followSpeed = 5;
    [SerializeField]
    int stopSpeed = 0;
    [SerializeField]
    Transform positionOfNPCs;
    [SerializeField]
    Collider other;

    private void Update()
    {
        transform.LookAt(targetToBeFollowed);
        transform.Translate(Vector3.forward * followSpeed * Time.deltaTime);
        Debug.Log("entered zone 2 RED");
    }
}


    //void Start()
    //{
    //    other.gameObject.GetComponent<Collider>();
    //}

    //void OnTriggerEnter(Collider other)
        //{
        //    if (other.gameObject.tag == "Player")
        //    {
        //        transform.LookAt(targetToBeFollowed);
        //        transform.Translate(Vector3.forward * followSpeed * Time.deltaTime);
        //        Debug.Log("entered zone 2 RED");
        //    }
        //}

        //void OnTriggerExit(Collider other)
        //{
        //    if (gameObject.tag == "Player")
        //    {
        //        transform.LookAt(targetToBeFollowed);
        //        transform.Translate(Vector3.forward * stopSpeed * Time.deltaTime);
        //        Debug.Log("exited zone 2 RED");
        //    }
        //}