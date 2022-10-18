using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    void Start ()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
