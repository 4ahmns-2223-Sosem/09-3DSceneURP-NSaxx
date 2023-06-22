using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer : MonoBehaviour
{
    public GameObject Orange;
    public GameObject Mixeraudio;
    public GameObject Blendsoundon;
    public GameObject Blendsoundoff;
    public GameObject prefabJuice;
    public Material MyMaterial;
    public Color OrangeIN = new Color(0F, 0F, 0F);
    public Color Empty = new Color(0F, 0F, 0F);
    public bool orangeInside;
    public bool isOneDone;
    public EnergyMeter script;

    void Start()
    {
        MyMaterial.color = Empty;
        isOneDone = false;
        Mixeraudio.SetActive(false);
        Blendsoundon.SetActive(false);
        Blendsoundoff.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Orange")
        {
            Orange.SetActive(false);
            MyMaterial.color = OrangeIN;
            orangeInside = true;
        }

    }

    private void Update()
    {

        if(orangeInside == true)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                Blendsoundon.SetActive(true);
                script.Energyturnedon = true;
                Debug.Log("+++++++++");
                StartCoroutine(Juicespawner());
                orangeInside = false;
                Mixeraudio.SetActive(true);
            }
        }

        if (isOneDone == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Blendsoundoff.SetActive(true);
                script.Energyturnedon = false;
                Debug.Log("----------");
                StopAllCoroutines();
                MyMaterial.color = Empty;
                Mixeraudio.SetActive(false);
            }
        }
    }

    IEnumerator Juicespawner ()
    {
            yield return new WaitForSeconds(2);
            Instantiate(prefabJuice, new Vector3(-2.43f, 1.5955f, 0.545f), Quaternion.identity);
            StartCoroutine(Juicespawner());
            isOneDone = true;
    }

    
}
