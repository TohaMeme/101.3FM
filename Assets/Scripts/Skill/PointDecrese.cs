using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using PixelCrushers;
using PixelCrushers.DialogueSystem;
using UnityEngine.UI;

public class PointDecrese : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI point_relig;
    [SerializeField] TMPro.TextMeshProUGUI point_mystic;
    [SerializeField] TMPro.TextMeshProUGUI point_geek;
    [SerializeField] TMPro.TextMeshProUGUI point_bachelor;
    [SerializeField] TMPro.TextMeshProUGUI point_empath;
    [SerializeField] TMPro.TextMeshProUGUI point_crybaby;
    [SerializeField] TMPro.TextMeshProUGUI point_soul;
    [SerializeField] TMPro.TextMeshProUGUI point_hypomania;
    [SerializeField] TMPro.TextMeshProUGUI point_comrade;
    [SerializeField] TMPro.TextMeshProUGUI point_office;
    [SerializeField] TMPro.TextMeshProUGUI point_anecdot;
    [SerializeField] TMPro.TextMeshProUGUI point_trickster;

    [SerializeField] TMPro.TextMeshProUGUI skill_esoteric_amount;
    [SerializeField] TMPro.TextMeshProUGUI skill_duchnila_amount;
    [SerializeField] TMPro.TextMeshProUGUI skill_melancholic_amount;
    [SerializeField] TMPro.TextMeshProUGUI skill_bimbo_amount;
    [SerializeField] TMPro.TextMeshProUGUI skill_workman_amount;
    [SerializeField] TMPro.TextMeshProUGUI skill_silly_amount;

    private void Start()
    {
        //relig_amount = DialogueLua.GetVariable("Level.Perk.Religious").asInt;
        //skill_esoteric = DialogueLua.GetVariable("Status.Esoteric").asInt;
        UpdateUI();
    }

    private void UpdateUI()
    {
        //point_relig.text = ChangePoint.Religious.ToString();
        /*point_mystic.text = ChangePoint.Mystic.ToString();
        point_geek.text = ChangePoint.Geek.ToString();
        point_bachelor.text = ChangePoint.Bachelor.ToString();
        point_empath.text = ChangePoint.Empath.ToString();
        point_crybaby.text = ChangePoint.Crybaby.ToString();
        point_soul.text = ChangePoint.Soul.ToString();
        point_hypomania.text = ChangePoint.Hypomania.ToString();
        point_comrade.text = ChangePoint.Comrade.ToString();
        point_office.text = ChangePoint.Office.ToString();
        point_anecdot.text = ChangePoint.Anecdot.ToString();
        point_trickster.text = ChangePoint.Trickster.ToString();*/


        skill_esoteric_amount.text = ChangePoint.Esoteric.ToString();  
        skill_duchnila_amount.text = ChangePoint.Duchnila.ToString();
        skill_melancholic_amount.text = ChangePoint.Melancholic.ToString();
        skill_bimbo_amount.text = ChangePoint.Bimbo.ToString();
        skill_workman_amount.text = ChangePoint.Workman.ToString();
        skill_silly_amount.text = ChangePoint.Silly.ToString();
    }

    public void GetRelig()
    {
        if (ChangePoint.Esoteric > 0) 
        {
            ChangePoint.Religious++;
            ChangePoint.Esoteric--;
            point_relig.text = ChangePoint.Religious.ToString();
            UpdateUI();
        }
    }        

    public void GetMystic()
    {
        if (ChangePoint.Esoteric > 0)
        {
            ChangePoint.Mystic++;
            ChangePoint.Esoteric--;
            point_mystic.text = ChangePoint.Mystic.ToString();
            UpdateUI();
        }
    }

    public void GetGeek()
    {
        if (ChangePoint.Duchnila > 0)
        {
            ChangePoint.Geek++;
            ChangePoint.Duchnila--;
            point_geek.text = ChangePoint.Geek.ToString();
            UpdateUI();
        }
    }

    public void GetBachelor()
    {
        if (ChangePoint.Duchnila > 0)
        {
            ChangePoint.Bachelor++;
            ChangePoint.Duchnila--;
            point_bachelor.text = ChangePoint.Bachelor.ToString();
            UpdateUI();
        }
    }

    public void GetEmpath()
    {
        if (ChangePoint.Melancholic > 0)
        {
            ChangePoint.Empath++;
            ChangePoint.Melancholic--;
            point_empath.text = ChangePoint.Empath.ToString();
            UpdateUI();
        }
    }

    public void GetCry()
    {
        if (ChangePoint.Melancholic > 0)
        {
            ChangePoint.Crybaby++;
            ChangePoint.Melancholic--;
            point_crybaby.text = ChangePoint.Crybaby.ToString();
            UpdateUI();
        }
    }

    public void GetSoul()
    {
        if (ChangePoint.Bimbo > 0)
        {
            ChangePoint.Soul++;
            ChangePoint.Bimbo--;
            point_soul.text = ChangePoint.Soul.ToString();
            UpdateUI();
        }
    }

    public void GetHypo()
    {
        if (ChangePoint.Bimbo > 0)
        {
            ChangePoint.Hypomania++;
            ChangePoint.Bimbo--;
            point_hypomania.text = ChangePoint.Hypomania.ToString();
            UpdateUI();
        }
    }

    public void GetComrade()
    {
        if (ChangePoint.Workman > 0)
        {
            ChangePoint.Comrade++;
            ChangePoint.Workman--;
            point_comrade.text = ChangePoint.Comrade.ToString();
            UpdateUI();
        }
    }
    public void GetOffice()
    {
        if (ChangePoint.Workman > 0)
        {
            ChangePoint.Office++;
            ChangePoint.Workman--;
            point_office.text = ChangePoint.Office.ToString();
            UpdateUI();
        }
    }

    public void GetAnec()
    {
        if (ChangePoint.Silly > 0)
        {
            ChangePoint.Anecdot++;
            ChangePoint.Silly--;
            point_anecdot.text = ChangePoint.Anecdot.ToString();
            UpdateUI();
        }
    }

    public void GetDark()
    {
        if (ChangePoint.Silly > 0)
        {
            ChangePoint.Trickster++;
            ChangePoint.Silly--;
            point_trickster.text = ChangePoint.Trickster.ToString();
            UpdateUI();
        }
    }

}
 
