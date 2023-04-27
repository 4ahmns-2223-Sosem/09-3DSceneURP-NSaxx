using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MissionUpdate : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    [TextArea]
    public string[] lines;
    public float textSpeed;


    public int index;
    void Start()
    {
        textComponent.text = string.Empty;
        StartMissionText();
    }

    void Update()
    {

    }

    public void StartMissionText()
    {
        textComponent.text = "";
        StopAllCoroutines();
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

    }
}
