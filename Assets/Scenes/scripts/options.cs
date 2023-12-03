using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class options : MonoBehaviour
{
    private bool isFullscreen = true;

    private void Start()
    {
        SetFullscreen(isFullscreen);
    }

    public void ToggleFullscreen()
    {
        isFullscreen = !isFullscreen;

        SetFullscreen(isFullscreen);
    }

    private void SetFullscreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }
}
