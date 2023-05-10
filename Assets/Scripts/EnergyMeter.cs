using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyMeter : MonoBehaviour
{
    public bool Energyturnedon;
    public float EnergyLevel;
    public float MWH;

    void Start()
    {
        Energyturnedon = false;
        //StartCoroutine(Waiter());
    }


    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(1);
        EnergyLevel += MWH;
        StartCoroutine(Waiter());
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            if (Input.GetKey(KeyCode.E))
            {
                Energyturnedon = !Energyturnedon;
                if (Energyturnedon)
                {
                    StartCoroutine(Waiter());
                }
                else
                {
                    StopAllCoroutines();
                }
            }
        }
    }
}

