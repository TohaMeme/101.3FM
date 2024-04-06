using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTabs : MonoBehaviour
{
    public GameObject[] tabs;

    public void TurnOnTab(int tab)
    {
        for (int i = 0; i < tabs.Length; i++)
        {
            tabs[i].SetActive(false);
        }
        tabs[tab - 1].SetActive(true);
    }
}
