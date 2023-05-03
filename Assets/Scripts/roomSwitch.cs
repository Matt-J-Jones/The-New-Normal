using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomSwitch : MonoBehaviour
{
    public Item SpaceRoom; //Item to be deactivated
    public Item NormalRoom; //Item to be activated
    public bool PlayerInTrigger = false; // Player is in collider

    
    void Update()
    {
        if (PlayerInTrigger)
        {
            SpaceRoom.gameObject.SetActive(true);
            NormalRoom.gameObject.SetActive(false);
        }

        else 
        {
            SpaceRoom.gameObject.SetActive(false);
            NormalRoom.gameObject.SetActive(true);
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
