using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Video;
using static UnityEngine.GraphicsBuffer;


public class rotationY : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;
                case TouchPhase.Moved:
                    // Determine direction by comparing the current touch position with the initial one
                    direction = touch.position - startPos;

                    break;
                case TouchPhase.Ended:
                    // Report that the touch has ended when it ends

                    break;

            }
            this.transform.RotateAround(this.transform.position, Vector3.up, -direction.x*0.01f);


        }

    }
}

