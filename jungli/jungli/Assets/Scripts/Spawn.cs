using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    public float timestart = 30;
    public Text timertext;
    public GameObject GamePanel;
    public GameObject EGPanel;
    public float Timee;
    public GameObject[] pref;

    private void Start()
    {
        StartCoroutine(SpawnObj());
        timertext.text = timestart.ToString();
    }
    void Repeat()
    {
        StartCoroutine(SpawnObj());
    }
    private void Update()
    {
        if (timestart > 0)
        {
            timestart -= Time.deltaTime;
            timertext.text = Mathf.Round(timestart).ToString();
        }
        else
        {
            EGPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    IEnumerator SpawnObj()
    {
        yield return new WaitForSeconds(Timee);
        float randX = Random.Range(-161f, -20f);
        Vector3 wheretospawn = new Vector3(randX, transform.position.y, transform.position.z);
        int randObj = Random.Range(0, pref.Length);
        GameObject obj = Instantiate(pref[randObj], wheretospawn, Quaternion.identity);
        Repeat();

    }
}
