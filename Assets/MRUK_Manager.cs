using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Meta.XR.MRUtilityKit;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class MRUK_Manager : MonoBehaviour
{
    private MRUKRoom room;

    [SerializeField] private Transform _positionHolder;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void LoadMiniatureRoom()
    {
        
        room = GameObject.FindObjectOfType<MRUKRoom>();
        room.gameObject.transform.localScale = Vector3.one * 0.05f;
        room.gameObject.transform.position = new Vector3(0.0f, -0.4f, 0.4f);
        if (room == null)
        {
            Debug.LogError("MRUK_Manager: room couldn't be found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if (room != null && _positionHolder != null)
        // {
        //     room.gameObject.transform.position = _positionHolder.position;
        // }
    }
}
