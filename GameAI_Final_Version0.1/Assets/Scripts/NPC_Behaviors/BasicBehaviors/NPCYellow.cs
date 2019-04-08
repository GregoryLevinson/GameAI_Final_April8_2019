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

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetToBeFleedFrom);
        transform.Translate(Vector3.back * fleeSpeed * Time.deltaTime);
    }
}
