using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MissionUpdate : MonoBehaviour
{
    public TextMeshProUGUI textComp;
    [TextArea]
    public string[] line;
    public float textSped;


    public int index;
    void Start()
    {
        textComp.text = string.Empty;
        StartMissionText();
    }


    public void StartMissionText()
    {
        textComp.text = "";
        StopAllCoroutines();
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in line[index].ToCharArray())
        {
            textComp.text += c;
            yield return new WaitForSeconds(textSped);
        }

    }
}