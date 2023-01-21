using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeController : MonoBehaviour
{

    [Header("this is the final code\nUse numbers only")]
    public string code = "0000";
    public string currentText;
    TMP_Text textBox;
    [SerializeField ]TMP_Text nextPassText;
    public string correctMessage;
    public bool correct;
    // Start is called before the first frame update
    void Start()
    {
        textBox= GetComponent<TMP_Text>();
        textBox.text = currentText;
    }

    // Update is called once per frame
    void Update()
    {
        if (!correct)
        {
            textBox.text = currentText;
            if (currentText == code)
            {
                Solved();
            }
        }
    }

    void Solved()
    {
        correct = true;
        nextPassText.text = correctMessage;
    }
}
