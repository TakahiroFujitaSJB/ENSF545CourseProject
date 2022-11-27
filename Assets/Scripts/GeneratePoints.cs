using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePoints : MonoBehaviour
{
    public GameObject other;


    private void OnTriggerEnter(Collider collision)
    {
        other.SetActive(true);
        gameObject.SetActive(false);
    }
}
