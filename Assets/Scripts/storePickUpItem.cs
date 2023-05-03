using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storePickUpItem : MonoBehaviour
{
    public Item Item; //current mission waypoint to be deactivated
    public Item Item2; //next mission waypoint to be activated
    public bool PlayerInTrigger = false; // Player is in collider
    public Text missionText;
    public string newMission;
    
    void Start()
    {

    }
    
    void Update()
    {
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E)) // check that player is in range and has pressed 'E' Key
      {
        Item.gameObject.SetActive(false);
        Item2.gameObject.SetActive(true); // Activate held object
        missionText.text=newMission;
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
