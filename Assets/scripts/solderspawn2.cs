using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solderspawn2 : MonoBehaviour
{
    public GameObject spawn2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("collider2"))
        {
            Vector3 collisionPoint = collision.contacts[0].point;
            Instantiate(spawn2, collisionPoint, Quaternion.identity, collision.transform);
        }
            
    }

}
