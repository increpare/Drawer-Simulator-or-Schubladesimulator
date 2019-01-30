using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawn : MonoBehaviour
{
    public ParticleSystem ps;
    public Camera maincam;
    public AudioSource asrc;

    public AudioClip ac;
    public float vol;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform schubladecam;

    ContactPoint[] points = new ContactPoint[10];
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag!="geraete"){
            return;
        }
        if (points.Length<collision.contactCount){
            points = new ContactPoint[collision.contactCount];
        }
        if (points.Length>0){         
            AudioSource.PlayClipAtPoint(ac,maincam.transform.position+maincam.transform.forward,vol);
        }
        // Debug.Log(collision.transform.name);
        // var count = collision.GetContacts(points);
        // for (var i=0;i<count;i++){
        //     var contact = points[i];
        //     ps.Emit(contact.point,-schubladecam.transform.forward,1.0f,1.0f,Color.white);
        //     Debug.DrawRay(contact.point, contact.normal*100, Color.white,1.0f);
        // }
    }
}
