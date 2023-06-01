using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer : MonoBehaviour
{
    public GameObject Orange;
    public GameObject prefabJuice;
    public Material MyMaterial;
    public Color OrangeIN = new Color(0F, 0F, 0F);
    public Color Empty = new Color(0F, 0F, 0F);
    public bool orangeInside;
    public bool isOneDone;

    void Start()
    {
        MyMaterial.color = Empty;
        isOneDone = false;
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
                Debug.Log("+++++++++");
                StartCoroutine(Juicespawner());
                orangeInside = false;
            }
        }

        if (isOneDone == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("----------");
                StopAllCoroutines();
                MyMaterial.color = Empty;
            }
        }
    }

    IEnumerator Juicespawner ()
    {
            yield return new WaitForSeconds(1);
            Instantiate(prefabJuice, new Vector3(-2.43f, 1.5955f, 0.545f), Quaternion.identity);
            StartCoroutine(Juicespawner());
            isOneDone = true;
    }
}
