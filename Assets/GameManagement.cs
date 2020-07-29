using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    private CanvasGroup Notes;
    public float NoteTransHide = 0;
    public float NoteTransShow = 1;


    // Start is called before the first frame update
    void Start()
    {
        Notes = GetComponent<CanvasGroup>();
        Notes.alpha = NoteTransHide;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Notes"))
        {
            Notes.alpha = NoteTransShow;
        }
        else
        {
            Notes.alpha = NoteTransHide;
        }
    }
}
