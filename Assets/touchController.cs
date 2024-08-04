using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Video;

public class touchController : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 startPos;
    public Vector2 direction;
    public GameObject placedPrefeb;
    public GameObject CanvasObject;
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
            Vector3 p = placedPrefeb.transform.position;
            p.y += direction.y * 0.0001f;
            placedPrefeb.transform.position = p;

            Vector3 q = CanvasObject.transform.position;
            q.y += direction.y * 0.0001f;
            CanvasObject.transform.position = q;



        }
    }
}
