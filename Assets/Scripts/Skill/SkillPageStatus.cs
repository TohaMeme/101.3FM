using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using PixelCrushers;
using PixelCrushers.DialogueSystem;

public class SkillPageStatus : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI s_esoteric;
    [SerializeField] TMPro.TextMeshProUGUI s_duchnila;
    [SerializeField] TMPro.TextMeshProUGUI s_melancholic;
    [SerializeField] TMPro.TextMeshProUGUI s_bimbo;
    [SerializeField] TMPro.TextMeshProUGUI s_workman;
    [SerializeField] TMPro.TextMeshProUGUI s_silly;

    [SerializeField] TMPro.TextMeshProUGUI p_relig;
    [SerializeField] TMPro.TextMeshProUGUI p_mystic;
    [SerializeField] TMPro.TextMeshProUGUI p_geek;
    [SerializeField] TMPro.TextMeshProUGUI p_bachelor;
    [SerializeField] TMPro.TextMeshProUGUI p_empath;
    [SerializeField] TMPro.TextMeshProUGUI p_crybaby;
    [SerializeField] TMPro.TextMeshProUGUI p_soul;
    [SerializeField] TMPro.TextMeshProUGUI p_hypomania;
    [SerializeField] TMPro.TextMeshProUGUI p_comrade;
    [SerializeField] TMPro.TextMeshProUGUI p_office;
    [SerializeField] TMPro.TextMeshProUGUI p_anecdot;
    [SerializeField] TMPro.TextMeshProUGUI p_trickster;

    private void Start()
    {
       UpdateUI();

    }

    public void UpdateUI()
    {
        s_esoteric.text = ChangePoint.Esoteric.ToString();
        s_duchnila.text = ChangePoint.Duchnila.ToString();
        s_melancholic.text = ChangePoint.Melancholic.ToString();
        s_bimbo.text = ChangePoint.Bimbo.ToString();
        s_workman.text = ChangePoint.Workman.ToString();
        s_silly.text = ChangePoint.Silly.ToString();

        /*p_relig.text = ChangePoint.Religious.ToString();
        p_mystic.text = ChangePoint.Mystic.ToString();
        p_geek.text = ChangePoint.Geek.ToString();
        p_bachelor.text = ChangePoint.Bachelor.ToString();
        p_empath.text = ChangePoint.Empath.ToString();
        p_crybaby.text = ChangePoint.Crybaby.ToString();
        p_soul.text = ChangePoint.Soul.ToString();
        p_hypomania.text = ChangePoint.Hypomania.ToString();
        p_comrade.text = ChangePoint.Comrade.ToString();
        p_office.text = ChangePoint.Office.ToString();
        p_anecdot.text = ChangePoint.Anecdot.ToString();
        p_trickster.text = ChangePoint.Trickster.ToString();*/

        /*s_esoteric.text = DialogueLua.GetVariable("Status.Esoteric").asString;
        s_duchnila.text = DialogueLua.GetVariable("Status.Duchnila").asString;
        s_melancholic.text = DialogueLua.GetVariable("Status.Melancholic").asString;
        s_bimbo.text = DialogueLua.GetVariable("Status.Bimbo").asString;
        s_workman.text = DialogueLua.GetVariable("Status.Workman").asString;
        s_silly.text = DialogueLua.GetVariable("Status.Silly").asString;*/

    }
}
