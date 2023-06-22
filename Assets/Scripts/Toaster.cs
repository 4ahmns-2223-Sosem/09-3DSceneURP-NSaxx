using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toaster : MonoBehaviour
{
    public GameObject bread1;
    public GameObject bread2;
    public GameObject Breadintoaster1;
    public GameObject Breadintoaster2;
    public GameObject cookedbread1;
    public GameObject cookedbread2;
    public GameObject toasterinsound1;
    public GameObject toasterinsound2;
    public GameObject toasteroutsound;
    public bool bread1bool = false;
    public bool bread2bool = false;
    public EnergyMeter script;

    void Start()
    {
        Breadintoaster1.SetActive(false);
        Breadintoaster2.SetActive(false);
        cookedbread1.SetActive(false);
        cookedbread2.SetActive(false);
        toasterinsound1.SetActive(false);
        toasterinsound2.SetActive(false);
        toasteroutsound.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Bread1")
        {
            Breadintoaster1.SetActive(true);
            bread1.SetActive(false);
            bread1bool = true;
            toasterinsound1.SetActive(true);
        }
        if (other.gameObject.tag == "Bread2")
        {
            Breadintoaster2.SetActive(true);
            bread2.SetActive(false);
            bread2bool = true;
            toasterinsound2.SetActive(true);
        }
    }
    void Update()
    {
        if (bread1bool == true && bread2bool == true)
        {
            if (Input.GetKey(KeyCode.T))
            {
                StartCoroutine(Toastery());
                
            }
        }
    }
    IEnumerator Toastery()
    {
        script.Energyturnedon = true;
        yield return new WaitForSeconds(6);
        Breadintoaster2.SetActive(false);
        Breadintoaster1.SetActive(false);
        cookedbread1.SetActive(true);
        cookedbread2.SetActive(true);
        toasteroutsound.SetActive(true);
        script.Energyturnedon = false;
    }
}
