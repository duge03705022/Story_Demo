using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameParameter : MonoBehaviour
{
    public Dictionary<string, GameObject> characterDic;

    // Start is called before the first frame update
    void Start()
    {
        characterDic = new Dictionary<string, GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
