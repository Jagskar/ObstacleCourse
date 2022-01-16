using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitCounter = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hitCounter++;
            Debug.Log("You've bumped into a thing this many times: " + hitCounter + ". Object hit: " + other.gameObject);
        }
    }
}
