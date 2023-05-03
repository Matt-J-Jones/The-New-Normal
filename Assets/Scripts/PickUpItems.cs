using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    public Item Item; //Item to be deactivated
    public Item Item2; //Item to be activated
    public bool PlayerInTrigger = false; // Player is in collider
    public scoreUpdate score;
    
    void Start()
    {

    }
    
    void Update()
    {
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E)) // check that player is in range and has pressed 'E' Key
      {
        Item2.gameObject.SetActive(true); // Activate held object
      }
    }

    void OnTriggerEnter(Collider other) // Player has entered collider
    {
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit(Collider other) // Player leaves collider
    {
      PlayerInTrigger = false; //unset variable
      if (Item2.isActiveAndEnabled)
      {
        Item2.gameObject.SetActive(false);
        Item.gameObject.SetActive(false); // Deactivate world object
        score.artifactCount++;
      }
    }
}
