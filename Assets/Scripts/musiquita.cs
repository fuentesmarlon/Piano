using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musiquita : MonoBehaviour
{

    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public GameObject fire;
    private bool flag;
    // Start is called before the first frame update
    void Start()
    {

        MusicSource.clip = MusicClip;

        

    }
        // Update is called once per frame
        void Update()
        {
        if (flag == true)
        {
            Invoke("apagar", 2);

        }
    }
    public void yes() {
        MusicSource.Play();
    }
    public void active() {
        flag = true;
        fire.SetActive(true);
    }
    public void apagar()
    {
        flag = false;
        fire.SetActive(false);
    }
}   