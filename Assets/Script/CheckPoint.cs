using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CheckPoint : MonoBehaviour
{
    public TextMeshProUGUI WinTex;
    public GameObject panel;

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            WinTex.gameObject.SetActive(true);
            panel.SetActive(true);
            GetComponent<AudioSource>().Play();
        }

    }
}
