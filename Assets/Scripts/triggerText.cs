using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerText : MonoBehaviour
{
    
    public bool PlayerInTrigger=false;
    public Text missionText;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // Player has entered collider
    {
      PlayerInTrigger = true; //Set variable
      missionText.text= missionText.text + "\nGet home.";
    }

    void OnTriggerExit(Collider other) // Player leaves collider
    {
      PlayerInTrigger = false; //unset variable
    }
}
