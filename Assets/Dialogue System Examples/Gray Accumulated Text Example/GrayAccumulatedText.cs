/*using UnityEngine;
using PixelCrushers.DialogueSystem;

public class GrayAccumulatedText : MonoBehaviour
{

    public Color oldTextColor = Color.gray;

    public void OnConversationLine(Subtitle subtitle)
    {
        if (string.IsNullOrEmpty(subtitle.formattedText.text)) return;
        SetAccumulatedTextGray();
    }

    private void SetAccumulatedTextGray()
    { 
        var subtitlePanel = DialogueManager.StandardDialogueUI.conversationUIElements.defaultNPCSubtitlePanel;
        // Remove color tags from old accumulated text:
        if (subtitlePanel.accumulatedText.StartsWith("<color="))
        {
            var tagLength = subtitlePanel.accumulatedText.IndexOf(">") + 1;
            subtitlePanel.accumulatedText = subtitlePanel.accumulatedText.Remove(0, tagLength);
            var endTagPos = subtitlePanel.accumulatedText.LastIndexOf("</color>");
            subtitlePanel.accumulatedText = subtitlePanel.accumulatedText.Remove(endTagPos, "</color>".Length);
        }
        // Wrap accumulated text in gray:
        subtitlePanel.accumulatedText = UITools.WrapTextInColor(subtitlePanel.accumulatedText, oldTextColor);
    }
}*/
