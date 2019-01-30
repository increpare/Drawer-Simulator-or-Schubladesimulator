using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcer : MonoBehaviour
{
    public Rigidbody rb;

    public Vector3 hdir=Vector3.right;
    public Vector3 vdir=Vector3.forward;

    public float hthrust;
    public float vthrust;
    
    public Transform forcepos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
         var fh = hdir*hthrust*h;
         var fv = vdir*vthrust*v;
         
         rb.AddForceAtPosition((fh+fv)*Time.deltaTime,forcepos.position);
         Debug.DrawRay(transform.position,fh,Color.red);
         Debug.DrawRay(transform.position,fv,Color.green);
         Debug.DrawRay(transform.position,fh+fv,Color.yellow);
        
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.R)){
            Application.LoadLevel(1);
        }
        if (Input.GetKeyDown(KeyCode.M)){            
            AudioListener.volume=1-AudioListener.volume;
        }
    }
}
