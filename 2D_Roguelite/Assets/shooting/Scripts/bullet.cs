using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;

    /*
        OnCollisionEnter2d =
        Sent when an incoming collider makes contact with this object's collider (2D physics only).
        https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html
     */
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Creates an effect when gameobject collides with a another object
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //  Destroys the effect
        Destroy(effect, 5f);
        // Destroys the gameobject
        Destroy(gameObject);
    }

}
