using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShotHandler : MonoBehaviour
{
    public void CaptureScreen()
    {
        string imageName = "Frame_" + Time.frameCount.ToString() + ".png";
        ScreenCapture.CaptureScreenshot(imageName);
    }
}
