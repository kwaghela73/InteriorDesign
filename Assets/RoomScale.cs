using System.Collections;
using System.Collections.Generic;
using Meta.XR.MRUtilityKit;
using Unity.VisualScripting;
using UnityEngine;

public class RoomScale : MonoBehaviour
{
    private MRUKRoom room;
    [SerializeField]private Material wallMat;
    [SerializeField]private Material floorMat;
    [SerializeField]private Material ceilingMat;

    // Start is called before the first frame update
    void Start()
    {
           }

    public void ScaleRoom()
    {
        GameObject.FindObjectOfType<MRUK>().EnableWorldLock = true;
        room = GameObject.FindObjectOfType<MRUKRoom>();
        room.gameObject.transform.localScale = Vector3.one; 
        SetMaterialsAlpha(0.0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void SetMaterialsAlpha(float alpha)
    {

        SetMaterialAlpha(wallMat, alpha);
        SetMaterialAlpha(floorMat, alpha);
        SetMaterialAlpha(ceilingMat, alpha);
    }

    private void SetMaterialAlpha(Material mat, float alpha)
    {
        if (mat == null) return;

        mat.SetColor("_BaseColor", new Color(1, 1, 1, 0));
        mat.SetColor("_Color", new Color(1, 1, 1, 0));

    }
}
