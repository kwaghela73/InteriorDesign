using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;

public class GrabeSettings : MonoBehaviour
{
    private Grabbable _grabbable;
    // Start is called before the first frame update
    void Start()
    {
        _grabbable = GetComponent<Grabbable>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
