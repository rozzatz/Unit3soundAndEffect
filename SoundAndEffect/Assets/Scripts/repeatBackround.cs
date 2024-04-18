using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatBackround : MonoBehaviour
{
    private Vector3 startpos;
    private float repeatWidth;
    void Start()
    {
        startpos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startpos.x - repeatWidth) 
        {
            transform.position = startpos;
        }
    }
}
