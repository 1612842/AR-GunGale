using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour
{
    private Transform targetFocus;

    // Start is called before the first frame update
    void Start()
    {
        targetFocus = GameObject.FindGameObjectWithTag("target").transform;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = targetFocus.position - this.transform.position;

        transform.LookAt(targetFocus.transform);
    }
}
