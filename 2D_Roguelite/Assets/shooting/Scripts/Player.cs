using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Camera cam;

    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        /*
        Camera.ScreenToWorldPoint =
        Transforms position from screen space into world space.
        Screenspace is defined in pixels.The bottom-left of the screen is (0, 0); 
        the right-top is (pixelWidth, pixelHeight).The z position is in world units from the camera.
        https://docs.unity3d.com/ScriptReference/Camera.ScreenToWorldPoint.html
        */
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    /*
    Frame-rate independent MonoBehaviour.FixedUpdate message for physics calculations.
    https://docs.unity3d.com/ScriptReference/MonoBehaviour.FixedUpdate.html
    */
    private void FixedUpdate()
    {
        /*
        Ridgidbody tracks mouse
        Returns the angle in radians whose Tan is y/x.
        Return value is the angle between the x-axis and a 2D vector starting at zero and terminating at (x,y).
        https://docs.unity3d.com/ScriptReference/Mathf.Atan2.html
        */
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
