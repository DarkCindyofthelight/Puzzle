using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixerPieces : MonoBehaviour
   

{

    public bool InRightPosition;
    private Vector3 RightPosition;
    
    void Start()
    {

        RightPosition = transform.position;
        transform.position = new Vector3(x: Random.Range(49,2f),y:Random.Range(-26.6f, 36.8f));

    }

    
    void Update()
    {
        if (Vector3.Distance(a:transform.position, b:RightPosition) < 0f)
        {
        transform.position = RightPosition;
            InRightPosition = true;



        }



    }
}
