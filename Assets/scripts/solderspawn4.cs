using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solderspawn4 : MonoBehaviour
{
    
    public GameObject spawn4;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameObject2"))
        {
            Vector3 collisionPoint = collision.contacts[0].point;
            Instantiate(spawn4, collisionPoint, Quaternion.identity, collision.transform);
        }
            
    }
}
