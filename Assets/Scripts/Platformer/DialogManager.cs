using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentences;

    public Text nameText;
    public Text dialogText;

    public Animator anim;
    public GameObject panel;
    void Start()
    {
        sentences = new Queue<string>();
        anim.SetBool("IsOpen", true);
    }

    public void StartDialog (Dialog dialog)
    {
        
        nameText.text = dialog.name;
        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentences();

    }

    public void DisplayNextSentences()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentences(sentence));
    }

    IEnumerator TypeSentences (string sentence)
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
    }

    void EndDialog()
    {
        panel.SetActive(false);
        anim.SetBool("IsOpen", false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
