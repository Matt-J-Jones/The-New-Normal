using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorTrigger : MonoBehaviour
{
    public Item toActivate;
    public bool PlayerInTrigger = false;

    // Update is called once per frame
    void Update()
    {
        if (PlayerInTrigger)
        {
            toActivate.gameObject.SetActive(true);
        }
    }
    
    void OnTriggerEnter(Collider other) // Player has entered collider
    {
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit(Collider other) // Player leaves collider
    {
      PlayerInTrigger = false; //unset variable
    }
}
