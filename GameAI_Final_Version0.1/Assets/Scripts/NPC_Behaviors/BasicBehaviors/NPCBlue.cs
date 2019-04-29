using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBlue : MonoBehaviour
{
    [SerializeField]
    GameObject NPCtoBeDestroyed;
    [SerializeField]
    GameObject NPCtoBeDestroyed2;
    [SerializeField]
    GameObject NPCtoBeDestroyed3;
    [SerializeField]
    GameObject NPCtoBeDestroyed4;
    [SerializeField]
    GameObject NPCtoBeDestroyed5;
    [SerializeField]
    GameObject NPCtoBeDestroyed6;
    [SerializeField]
    GameObject NPCtoBeDestroyed7;
    [SerializeField]
    GameObject NPCtoBeDestroyed8;


    private void OnTriggerEnter(Collider other)
    {

        Destroy(NPCtoBeDestroyed);
        Destroy(NPCtoBeDestroyed2);
        Destroy(NPCtoBeDestroyed3);
        Destroy(NPCtoBeDestroyed4);
        Destroy(NPCtoBeDestroyed5);
        Destroy(NPCtoBeDestroyed6);
        Destroy(NPCtoBeDestroyed7);
        Destroy(NPCtoBeDestroyed8);
        NPCYellow.redDestroyed = true;
    }

}
