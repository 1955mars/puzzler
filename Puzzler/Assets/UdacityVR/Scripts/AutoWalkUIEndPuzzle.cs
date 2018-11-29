using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AutoWalkUIEndPuzzle : MonoBehaviour, IGvrPointerHoverHandler // Implement Interface for Gaze hoover method
{
    public Slider slider;
    public float gazeTime = 2.0f;
    public GameLogic gameLogic;
    private bool locked;

    public void Start()
    {
        slider.gameObject.SetActive(false);
        slider.value = 0f;
        slider.maxValue = gazeTime;
        locked = false;
    }

    public void EnterButton()
    {
        slider.gameObject.SetActive(true);
        slider.value = 0f;
        locked = false;
    }

    public void LeavesButton()
    {
        slider.gameObject.SetActive(false);
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
                gameLogic.ResetPuzzle();
                locked = true;
            }
        }
    }
}