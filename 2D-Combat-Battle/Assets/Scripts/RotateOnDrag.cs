using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnDrag : MonoBehaviour
{
    // Start is called before the first frame update
    private float SceneWidth;
    private Vector3 PressPoint;
    private Quaternion StartRotation;
    void Start()
    {
        SceneWidth = Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PressPoint = Input.mousePosition;
            StartRotation = transform.rotation;
        }
        else if (Input.GetMouseButton(0))
        {
            float CurrentDistanceBetweenPosition = (Input.mousePosition - PressPoint).x;
            transform.rotation = StartRotation * Quaternion.Euler(Vector3.up * (-CurrentDistanceBetweenPosition / SceneWidth) * 360);
        }
    }
   
}
