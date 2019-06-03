using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour {
    [SerializeField] List<Dialogue> dialogues;

    DialogueButtonManager dialogueButtonManager;

    private void Awake() {
        dialogueButtonManager =
            GameObject.FindGameObjectWithTag("DialoguePanel").GetComponent<DialogueButtonManager>();
    }

    private void Start() {
        dialogueButtonManager.SetDialogues(dialogues);
    }
}
