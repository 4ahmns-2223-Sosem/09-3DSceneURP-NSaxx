using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour
{
    public GameObject rawbacon;
    public GameObject cookedbacon;
    public GameObject burnedbacon;
    public GameObject Pansound;
    public GameObject Pansoundon;
    public GameObject Pansoundoff;
    public EnergyMeter script;
    public void Start()
    {
        Pansound.SetActive(false);
        cookedbacon.SetActive(false);
        burnedbacon.SetActive(false);
        Pansoundon.SetActive(false);
        Pansoundoff.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "RawBacon")
        {
            if (Input.GetKey(KeyCode.P))
            {
                Pansoundon.SetActive(true);
                Debug.Log("+++++++++");
                Pansound.SetActive(true);
                StartCoroutine(BaconCooker());
            }
        }
        if (other.gameObject.tag == "CookedBacon")
        {
            if (Input.GetKey(KeyCode.O))
            {
                Pansoundoff.SetActive(true);
                Pansound.SetActive(false);
                StopAllCoroutines();
                script.Energyturnedon = false;
            }
        }
        if (other.gameObject.tag == "Baconburned")
        {
            if (Input.GetKey(KeyCode.O))
            {
                Pansoundoff.SetActive(true);
                Pansound.SetActive(false);
                script.Energyturnedon = false;
            }
        }
    }

    IEnumerator BaconCooker()
    {
        script.Energyturnedon = true;
        yield return new WaitForSeconds(6);
        rawbacon.SetActive(false);
        cookedbacon.SetActive(true);
        yield return new WaitForSeconds(6);
        cookedbacon.SetActive(false);
        burnedbacon.SetActive(true);

    }
}
