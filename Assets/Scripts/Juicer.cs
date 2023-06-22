using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juicer : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Plate")
        {
            Debug.Log("Yuhuuu");
            Destroy(this.gameObject);
        }

    }
}