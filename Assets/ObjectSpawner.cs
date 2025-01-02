using System;
using System.Collections;
using System.Collections.Generic;
using Meta.XR.MRUtilityKit;
using Oculus.Interaction.Input;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectSpawner : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Button _button;
    [SerializeField] private GameObject _objectPrefab;
    [SerializeField] private Transform _objectParent;
    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
    }
  
    public void Spawn()
    {
        GameObject obj = Instantiate(_objectPrefab, _objectParent.position, Quaternion.identity);
        obj.GetComponent<Rigidbody>().isKinematic = true;
        obj.transform.parent = GameObject.FindObjectOfType<MRUKRoom>().transform;

    }
    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Spawn();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _button.OnPointerUp(eventData);
        
    }
}
