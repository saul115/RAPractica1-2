using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorRotation : MonoBehaviour
{

    Transform rotation;

    // Start is called before the first frame update
    void Start()
    {
        rotation = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        rotation.Rotate(Vector3.forward * 4.0f);
    }
}
