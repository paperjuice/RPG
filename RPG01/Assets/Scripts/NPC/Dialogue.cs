using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DialogueStatus {
    READY,
    SAID,
    UNAVAILABLE
}

[System.Serializable]
public class Dialogue {
    public int id = 0;
    public DialogueStatus status =  DialogueStatus.UNAVAILABLE;
    public int childOf = 0;
    public int questId = 0;

    [TextArea(3, 10)]
    public string summary;
    [TextArea(3, 10)]
    public string question;
    [TextArea(3, 10)]
    public string answer;
}
