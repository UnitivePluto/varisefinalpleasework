using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solderhormove : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if(!Input.GetKey(KeyCode.LeftShift))
        {
            float horizontalinput = Input.GetAxis("Vertical");
            Vector3 movementdirection = new Vector3(horizontalinput, 0, 0).normalized;
            transform.Translate(movementdirection * speed * Time.deltaTime);
        }
        
    }
}
