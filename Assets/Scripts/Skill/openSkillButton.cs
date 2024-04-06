using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSkillButton : MonoBehaviour
{
    [SerializeField] public GameObject skillCanvas;
    [SerializeField] private bool skillCanvasActivated;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && skillCanvasActivated)
        {
            Time.timeScale = 1;
            skillCanvas.SetActive(false);
            skillCanvasActivated = false;
        }

        else if (Input.GetKeyDown(KeyCode.L) && !skillCanvasActivated)
        {
            Time.timeScale = 0;
            skillCanvas.SetActive(true);
            skillCanvasActivated = true;
        }
    }
}
