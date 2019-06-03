using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueButtonManager : MonoBehaviour {

    DialogueManager NPC;
    List<Dialogue> dialogues;
    [SerializeField]
    List<Text> buttonText;
    

    public void SetNPC(DialogueManager npc) {
        NPC = npc;
    }

    public void SetDialogues(List<Dialogue> _dialogues) {
        dialogues = _dialogues;
        PopulateWithSummaryText();
    }

    void PopulateWithSummaryText() {
        for(int i = 0; i < dialogues.Count; ++i) {
            if (dialogues[i].status == DialogueStatus.READY) {
                buttonText[i].text = dialogues[i].summary;
            }
        }
    }
}
