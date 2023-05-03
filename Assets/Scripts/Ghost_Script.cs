using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Script : MonoBehaviour
{
    public Item GhostStatic;
    public Item GhostActive;
    bool Trigger = false;

    void Update()
    {
        if (Trigger)
        {
           GhostStatic.gameObject.SetActive(false);
           GhostActive.gameObject.SetActive(true); 
        }
    }

    void OnTriggerEnter(Collider other)
    {
      Trigger = true; //Set variable
    }
}
