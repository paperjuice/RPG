using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Dialogue {
    public int id;
    public bool isRead = false;
    public bool isQuest = false;
    public int afterDialogueWithId = 0;

    [TextArea(3, 10)]
    public string question;
    [TextArea(3, 10)]
    public string answer;
}

public class DialogSystem : MonoBehaviour {
    [SerializeField]
    List<Dialogue> dialogues = new List<Dialogue>();
    
    void ShowQuestions() {
        foreach(Dialogue dialogue in dialogues) {
            //if(!dialogue.isRead && ()
        }
    }












    List<string> quest01 = new List<string>() {
    "It's everything alright?",
    "Well, not really. My wife, Melisa, been missing for two days now. I don't know what to do.",
    "Did she say where she go?",
    "She went to visit her ill mother in a town west from here, called 'Simin'",
    "I will go look for her", // Start quest,
    "Would you do that?! Thank you so much!",
    };

    List<string> reward01 = new List<string>() {
        "I managed to find your wife. She got attacked by wolves and couldn't walk. We walked together to Simin. She is now safe, taking care of her mother.",
        "Blessed be, adventurer! I owe you my life."  // Receive reward
    };

    List<string> disc01 = new List<string>() {
        "Hello, how are you?",
        "Crops are growing and family is healthy. Life's good."
    };
}
