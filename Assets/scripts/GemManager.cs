using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemManager : MonoBehaviour
{
    private void Update()
    {
        AllGemCollected();
    }

    public void AllGemCollected()
    {
        if (transform.childCount==0)
        {
            Debug.Log("No quedan gemas, Ganaste!");
        }
    }
}
