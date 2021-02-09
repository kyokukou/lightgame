using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLight : MonoBehaviour
{
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
    	if (other.tag == "Player") {
    		Destroy(trigger);
    	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
