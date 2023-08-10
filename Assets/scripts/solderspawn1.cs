using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class solderspawn1 : MonoBehaviour
{
    public GameObject spawn1;
   
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("collider1")) 
        {
            Vector3 collisionPoint = collision.contacts[0].point;
            Instantiate(spawn1, collisionPoint, Quaternion.identity, collision.transform);
        }
        
    }
}
