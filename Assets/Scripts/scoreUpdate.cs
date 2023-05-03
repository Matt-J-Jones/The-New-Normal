using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpdate : MonoBehaviour
{
    public Text scoreText;
    public int artifactCount = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Artifacts Found: " + artifactCount;
    }
}
