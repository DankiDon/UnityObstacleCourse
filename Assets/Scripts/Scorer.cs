using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int iBumpScore = 0;
    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log(other);
        if(gameObject.tag != "Hit")
        {
            iBumpScore++;
        }
        Debug.Log("You've bumped into a thing this many times: " + iBumpScore);
    }
}
