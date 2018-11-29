using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AutoWalkUISelect : MonoBehaviour, IGvrPointerHoverHandler // Implement Interface for Gaze hoover method
{
    public Canvas canvas;
    public Slider slider;
    public float gazeTime = 2.0f;
    public LightUp lightUp;
    private bool locked;

    public void Start()
    {
        canvas.gameObject.SetActive(false);
        slider.value = 0f;
        slider.maxValue = gazeTime;
        locked = false;
    }

    public void EnterButton()
    {
        canvas.gameObject.SetActive(true);
        slider.value = 0f;
        locked = false;
    }

    public void LeavesButton()
    {
        canvas.gameObject.SetActive(false);
        slider.value = 0f;
        locked = false;
    }

    public void OnGvrPointerHover(PointerEventData eventData)
    {
        Debug.Log("OnGVRPointerHover called");
        if (!locked)
        {
            slider.value += Time.deltaTime;

            if (slider.value >= gazeTime)
            {
                slider.value = 0f;
                lightUp.PlayerSelection();
                locked = true;
            }
        }
    }
}