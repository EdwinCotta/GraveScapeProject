using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ColectCoin : MonoBehaviour
{
    private int  coinVault = 0;
    public TextMeshProUGUI score;
    public GameObject innerKey;


    private void OnTriggerEnter(Collider objeto)
    {
        if (objeto.gameObject.CompareTag("Moeda"))
        {
            Destroy(objeto.gameObject);
            coinVault += 1;
            score.text = "Score: " + coinVault.ToString();
            GetComponent<AudioSource>().Play();

            if(coinVault == 121)
            {
                innerKey.gameObject.SetActive(true);
            }
        }
    }
}
