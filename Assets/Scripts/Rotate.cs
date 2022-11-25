using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
