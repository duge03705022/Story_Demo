using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameParameter gameParameter;
    public string[] RFIDTag;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < RFIDTag.Length; i++)
        {
            gameParameter.characterDic.Add(RFIDTag[i], gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayClip()
    {
        GetComponent<AudioSource>().Play();
    }
}
