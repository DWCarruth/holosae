using Academy.HoloToolkit.Unity;
using UnityEngine;

/// <summary>
/// InteractibleAction performs custom actions when you gaze at the holograms.
/// </summary>
public class ShowHideAction : MonoBehaviour
{
    [Tooltip("Drag the descripion window asset you want to display.")]
    public GameObject DescriptionWindow;
    public Texture slide;

    void PerformTagAlong()
    {
        if (DescriptionWindow == null)
        {
            return;
        }
        
        // display window
        Renderer rend = DescriptionWindow.GetComponent<Renderer>();
        if(!rend.isVisible)
        {
            rend.enabled = true;
        }

        // update texture
        if(slide != null)
        {
            rend.material.mainTexture = slide;
        }
    }
}