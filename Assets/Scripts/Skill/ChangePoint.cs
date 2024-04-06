using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePoint : MonoBehaviour
{
    //навыки
    public static int Religious
    {
        get { return DialogueLua.GetVariable("Points.Perk.Religious").asInt; }
        set 
        { 
            DialogueLua.SetVariable("Points.Perk.Religious", value);
            UpdateUI();
        }
    }

    public static int Mystic
    {
        get { return DialogueLua.GetVariable("Points.Perk.Mystic").asInt; }
        set
        {
            DialogueLua.SetVariable("Points.Perk.Mystic", value);
            UpdateUI();
        }
    }

    public static int Geek
    {
        get { return DialogueLua.GetVariable("Points.Perk.Geek").asInt; }
        set
        {
            DialogueLua.SetVariable("Points.Perk.Geek", value);
            UpdateUI();
        }
    }

    public static int Bachelor
    {
        get { return DialogueLua.GetVariable("Points.Perk.Bachelor").asInt; }
        set
        {
            DialogueLua.SetVariable("Points.Perk.Bachelor", value);
            UpdateUI();
        }
    }

    public static int Empath
    {
        get { return DialogueLua.GetVariable("Points.Perk.Empath").asInt; }
        set
        {
            DialogueLua.SetVariable("Points.Perk.Empath", value);
            UpdateUI();
        }
    }
    public static int Crybaby
    {
        get { return DialogueLua.GetVariable("Points.Perk.Crybaby").asInt; }
        set
        {
            DialogueLua.SetVariable("Points.Perk.Crybaby", value);
            UpdateUI();
        }
    }

    public static int Soul
    {
        get { return DialogueLua.GetVariable("Points.Perk.Soul").asInt; }
        set
        {
            DialogueLua.SetVariable("Points.Perk.Soul", value);
            UpdateUI();
        }
    }
    public static int Hypomania
    {
        get { return DialogueLua.GetVariable("Points.Perk.Hypomania").asInt; }
        set
        {
            DialogueLua.SetVariable("Points.Perk.Hypomania", value);
            UpdateUI();
        }
    }

    public static int Comrade
    {
        get { return DialogueLua.GetVariable("Points.Perk.Comrade").asInt; }
        set
        {
            DialogueLua.SetVariable("Points.Perk.Comrade", value);
            UpdateUI();
        }
    }

    public static int Office
    {
        get { return DialogueLua.GetVariable("Points.Perk.Office").asInt; }
        set
        {
            DialogueLua.SetVariable("Points.Perk.Office", value);
            UpdateUI();
        }
    }

    public static int Anecdot
    {
        get { return DialogueLua.GetVariable("Points.Perk.Anecdot").asInt; }
        set
        {
            DialogueLua.SetVariable("Points.Perk.Anecdot", value);
            UpdateUI();
        }
    }

    public static int Trickster
    {
        get { return DialogueLua.GetVariable("Points.Perk.Trickster").asInt; }
        set
        {
            DialogueLua.SetVariable("Points.Perk.Trickster", value);
            UpdateUI();
        }
    }



    //Скиллы
    public static int Esoteric
    {
        get { return DialogueLua.GetVariable("Status.Esoteric").asInt; }
        set 
        { 
            DialogueLua.SetVariable("Status.Esoteric", Mathf.Clamp(value, 0, 100)); 
            UpdateUI(); 
        }
    }

    public static int Duchnila
    {
        get { return DialogueLua.GetVariable("Status.Duchnila").asInt; }
        set
        {
            DialogueLua.SetVariable("Status.Duchnila", Mathf.Clamp(value, 0, 100));
            UpdateUI();
        }
    }
    public static int Melancholic
    {
        get { return DialogueLua.GetVariable("Status.Melancholic").asInt; }
        set
        {
            DialogueLua.SetVariable("Status.Melancholic", Mathf.Clamp(value, 0, 100));
            UpdateUI();
        }
    }
    
    public static int Bimbo
    {
        get { return DialogueLua.GetVariable("Status.Bimbo").asInt; }
        set
        {
            DialogueLua.SetVariable("Status.Bimbo", Mathf.Clamp(value, 0, 100));
            UpdateUI();
        }
    }

    public static int Workman
    {
        get { return DialogueLua.GetVariable("Status.Workman").asInt; }
        set
        {
            DialogueLua.SetVariable("Status.Workman", Mathf.Clamp(value, 0, 100));
            UpdateUI();
        }
    }

    public static int Silly
    {
        get { return DialogueLua.GetVariable("Status.Silly").asInt; }
        set
        {
            DialogueLua.SetVariable("Status.Silly", Mathf.Clamp(value, 0, 100));
            UpdateUI();
        }
    }


    public static void UpdateUI() 
    {
        var skillUI = FindObjectOfType<SkillPageStatus>();
        if (skillUI != null) skillUI.UpdateUI();
    }
}
