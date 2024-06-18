using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scp_TrashColection : MonoBehaviour
{

    private int Trash = 0;

    public TextMeshProUGUI trashText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Collectible")
        {
            Trash ++;
            trashText.text = "Trash acumulated: " + Trash.ToString();
            Debug.Log(Trash);
            Destroy(other.gameObject);


        }



    }





}
