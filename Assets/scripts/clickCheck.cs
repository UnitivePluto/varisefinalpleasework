using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject Solder;

    private void Start()
    {
         Solder = GameObject.Find(Solder.name);
    }
    private void Update()
    {
        // Check for left mouse button click
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (Input.GetMouseButtonDown(0) /*&& collision.gameObject.tag == "Test"*/)
        {
            // Cast a ray from this GameObject in the forward direction
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0, 0, 0));
            RaycastHit hit;

            // Visualize the ray
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 100f))
                Debug.DrawRay(ray.direction * 100f, hit.point, Color.red);

            // Check if the ray hits an object with the specified tag
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 100f) && hit.collider.CompareTag("plate"))
            {
                // Spawn the prefab at the point of collision
                Instantiate(prefabToSpawn, hit.point, Quaternion.identity);
            }
        }
    }
}