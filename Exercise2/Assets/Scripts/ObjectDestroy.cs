using UnityEngine;
using System.Collections;

public class ObjectDestroy : MonoBehaviour 
{	
	void Update () 
    {
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
} 