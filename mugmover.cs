using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mugmover : MonoBehaviour
{   
    private Touch touch;
    private float speedModifier;
    // Start is called before the first frame update
    void Start()
    {
        speedModifier=0.01f;
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.touchCount >0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position  = new Vector3(
                    transform.position.x +touch.deltaPosition.x *speedModifier ,
                    transform.position.y,
                    transform.position.z +touch.deltaPosition.y *speedModifier
                );
            }

             if (touch.phase == TouchPhase.Ended)
                {
                    // Restore the regular size of the cube.
                    transform.localScale = new Vector3(0.40f, 0.0f, 0.15f);
                }
            // if (transform.position.x==0.07 && transform.position.y==0.07 && transform.position.z==0.07){
            //     transform.rotation.z = 60;
            // }
        }
    }
}
