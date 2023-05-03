using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public string NewScene;
    public bool Trigger = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    { 
      if (Trigger && Input.GetKeyDown(KeyCode.E))
      {
        SceneManager.LoadScene(NewScene);
      }  
    }
    void OnTriggerEnter(Collider other)
    {
      Trigger = true; //Set variable
    }
    void OnTriggerExit(Collider other)
    {
      Trigger = false; //unset variable
    }


}
