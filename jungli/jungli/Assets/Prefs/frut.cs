using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class frut : MonoBehaviour
{
    
    public int ScoreAdd;
    public GameObject obj;
    uicontroller uicontr;
    private bool Pausedd;
    Spawn spawnnn;

    GameManager gamemanager;

    private void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
        uicontr = FindObjectOfType<uicontroller>();
        spawnnn = FindObjectOfType<Spawn>();
    }

    public void OnMouseDown()
    {
        if (uicontr.isPaused) return;
        if (spawnnn.EGPanel.activeSelf) return;
        gamemanager.AddScore(ScoreAdd);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Destroy(obj);
        }
    }
}
