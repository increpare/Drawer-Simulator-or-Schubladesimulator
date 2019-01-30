using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitelBildSchirm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Application.LoadLevel(1);
        }
        if (Input.GetKeyDown(KeyCode.M)){            
            AudioListener.volume=1-AudioListener.volume;
        }
    }
}
