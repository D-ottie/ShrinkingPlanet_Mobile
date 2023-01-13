using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour
{
    public int avgFrameRate;
    public Text display_Text;
    // Start is called before the first frame update

    void Awake()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        avgFrameRate = (int)(1f / Time.unscaledDeltaTime);
        display_Text.text = avgFrameRate.ToString() + " FPS"; 
    }
}

