using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        

        if (playerInventory != null)
        {
            playerInventory.PaperCollected();
            gameObject.SetActive(false);
        }
    }
}
