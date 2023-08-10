using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solderspawn3 : MonoBehaviour
{
   
    public GameObject spawn3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameObject2"))
        {
            Vector3 collisionPoint = collision.contacts[0].point;
            Instantiate(spawn3, collisionPoint, Quaternion.identity, collision.transform);
        }
            
    }
}
