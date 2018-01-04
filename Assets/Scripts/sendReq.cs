using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendReq : MonoBehaviour {

    void Start()
    {
        string url = "127.0.0.1:8080/getCart";
        Debug.Log("before request");
        WWW www = new WWW(url);
        StartCoroutine(WaitForRequest(www));
    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            Debug.Log("WWW Ok!: " + www.text);
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }
}
