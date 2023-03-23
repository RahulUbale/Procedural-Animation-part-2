using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegStepper : MonoBehaviour
{
    [SerializeField] Transform homeTransform;
    [SerializeField] float wantStepAtDistance = .1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, homeTransform.position);


        if(distance > wantStepAtDistance )
        {
            transform.position = homeTransform.position;
            transform.rotation = homeTransform.rotation;
        }

    }
}
