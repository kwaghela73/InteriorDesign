using UnityEngine;
using Oculus.Interaction;
using Oculus.Interaction.Input;

public class RayColorChanger : MonoBehaviour
{
    [SerializeField] private RayInteractor _rayInteractor;
    [SerializeField] private Color _colorToChange = Color.red;

    void Update()
    {
        // Check if the player pressed the 'A' or 'X' button
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            ChangeHitObjectColor();
        }
    }

    private void ChangeHitObjectColor()
    {
        // Check if Ray Interactor currently has a collision/hit
        if (_rayInteractor.CollisionInfo != null)
        {
            Debug.Log("Ray Interactor:" + _rayInteractor.CollisionInfo);
            // Transform hitTransform = _rayInteractor.CollisionInfo;
            //
            // // Try get a renderer from the hit object
            // Renderer rend = hitTransform.GetComponent<Renderer>();
            // if (rend != null)
            // {
            //     // Change the material's color
            //     // Make sure the material/shader supports color changes. 
            //     // If using a standard shader, ensure it's not opaque or switch to one that supports color changes.
            //     Material mat = rend.material; 
            //     mat.color = _colorToChange;
           // }
        }
    }
}