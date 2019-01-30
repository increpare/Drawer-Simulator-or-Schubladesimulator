using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    private Vector3 initoff;
    // Start is called before the first frame update
    void Start()
    {
        initoff=transform.position-target.transform.position;;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position= target.transform.position+initoff;
    }
}
