using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyMeter : MonoBehaviour
{
    public bool Energyturnedon;
    public int EnergyLevel;
    public int MWH;

    void Start()
    {
        Energyturnedon = false;
    }


    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(1);
        EnergyLevel += MWH;
        StartCoroutine(Waiter());
    }


    private void Update()
    {
        if(Energyturnedon == true)
        {
            StartCoroutine(Waiter());
        }

        if (Energyturnedon == false)
        {
            StopAllCoroutines();
        }
    }
}

