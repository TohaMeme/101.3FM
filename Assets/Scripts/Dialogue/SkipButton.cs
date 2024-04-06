using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class SkipButton : MonoBehaviour
{

    public bool skip;

    private AbstractDialogueUI dialogueUI;

    private void Awake()
    {
        dialogueUI = GetComponentInChildren<AbstractDialogueUI>();
    }

    public void SkipToResponseMenu()
    {
        skip = true;
        dialogueUI.OnContinue();
    }

    void OnConversationLine(Subtitle subtitle)
    {
        if (skip) StartCoroutine(ContinueAtEndOfFrame());
    }

    IEnumerator ContinueAtEndOfFrame()
    {
        yield return new WaitForEndOfFrame();
        dialogueUI.OnContinue();
    }

    void OnConversationResponseMenu(Response[] responses)
    {
        skip = false;
    }

    void OnConversationEnd(Transform actor)
    {
        skip = false;
    }

}
