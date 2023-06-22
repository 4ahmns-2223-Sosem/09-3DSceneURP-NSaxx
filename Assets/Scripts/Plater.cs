using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Plater : MonoBehaviour
{
    public GameObject placedOrangeCup;
    public GameObject Player;
    public GameObject WinnerCam;
    public GameObject Missionupdater;
    public GameObject Wintext;
    public GameObject Winsound;
    public bool burnedBacon;
    public bool cookedBacon;
    public bool brot1;
    public bool brot2;
    public bool juice;
    public bool Won;
    public EnergyMeter script;
    public Text scoreText;
    public GameObject WinCanvas;

    //public GameObject placedBacon;
    //public GameObject placedBread;

    void Start()
    {
        placedOrangeCup.SetActive(false);
        burnedBacon = false;
        cookedBacon = false;
        brot1 = false;
        brot2 = false;
        juice = false;
        Won = false;
        WinnerCam.SetActive(false);
        WinCanvas.SetActive(false);
        Winsound.SetActive(false);
        scoreText.text = script.EnergyLevel.ToString() + " Points";
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Juicer")
        {
            placedOrangeCup.SetActive(true);
            juice = true;
        }

        if (other.gameObject.tag == "CookedBacon")
        {
            cookedBacon = true;
        }

        if (other.gameObject.tag == "Baconburned")
        {
            burnedBacon = true;
        }

        if (other.gameObject.tag == "DoneBread1")
        {
            brot1 = true;
        }

        if (other.gameObject.tag == "DoneBread2")
        {
            brot2 = true;
        }

    }

    private void Update()
    {
        scoreText.text = "Score: " + script.EnergyLevel.ToString() + " MW";

        if (juice == true && cookedBacon == true && brot1 == true && brot2 == true)
        {
            Winsound.SetActive(true);
            WinnerCam.SetActive(true);
            Player.SetActive(false);
            Missionupdater.SetActive(false);
            WinCanvas.SetActive(true);
            Won = true;
        }
        else
        {
            Won = false;
        }

        if (juice == true && burnedBacon == true && brot1 == true && brot2 == true)
        {
            Winsound.SetActive(true);
            WinnerCam.SetActive(true);
            Player.SetActive(false);
            Missionupdater.SetActive(false);
            WinCanvas.SetActive(true);
            Won = true;
        }
        else
        {
            Won = false;
        }

        if (Won == true)
        {
            if (Input.GetKey(KeyCode.V))
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
