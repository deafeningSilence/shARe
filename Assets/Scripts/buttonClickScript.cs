using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class buttonClickScript : MonoBehaviour {
    public void button1()        {
        //GameObject.Find("cake").active = false;
        GameObject.Find("cake").transform.localScale = new Vector3(0.002F, 0.002F, 0.002F);
        GameObject.Find("sushi").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("salad").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("menu").transform.localScale = new Vector3(0, 0, 0);
    }
    public void button2()    {
        GameObject.Find("sushi").transform.localScale = new Vector3(0.5F, 0.5F, 0.5F);
        GameObject.Find("cake").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("salad").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("menu").transform.localScale = new Vector3(0, 0, 0);
    }
    public void button3()    {
        GameObject.Find("salad").transform.localScale = new Vector3(0.2F, 0.2F, 0.2F);
        GameObject.Find("cake").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("sushi").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("menu").transform.localScale = new Vector3(0, 0, 0);
    }
    public void backToMenuButton() {
        Debug.Log("SB");
        GameObject.Find("menu").transform.localScale = new Vector3(2, 2, 2);
        GameObject.Find("salad").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("cake").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("sushi").transform.localScale = new Vector3(0, 0, 0);
    }

    public void saladATC() {
        string ourPostData = "{\"TABLE_ID\":74, \"DISH_NAME\":\"Salad\", \"PRICE\":150}";
        byte[] pData = Encoding.ASCII.GetBytes(ourPostData.ToCharArray());
        string url = "http://127.0.0.1:8080/addToCart";
        Debug.Log("before request");
        Hashtable headers = new Hashtable();
        headers.Add("Content-Type", "application/json");
        headers.Add("Cookie", "Our session cookie");
        WWW www = new WWW(url, pData, headers);
        StartCoroutine(WaitForRequest(www));
    }

    public void cakeATC() {
        string ourPostData = "{\"TABLE_ID\":74, \"DISH_NAME\":\"Cake\", \"PRICE\":50}";
        byte[] pData = Encoding.ASCII.GetBytes(ourPostData.ToCharArray());
        string url = "http://127.0.0.1:8080/addToCart";
        Debug.Log("before request");
        Hashtable headers = new Hashtable();
        headers.Add("Content-Type", "application/json");
        headers.Add("Cookie", "Our session cookie");
        WWW www = new WWW(url, pData, headers);
        StartCoroutine(WaitForRequest(www));
    }
    public void sushiATC() {
        string ourPostData = "{\"TABLE_ID\":74, \"DISH_NAME\":\"Sushi\", \"PRICE\":100}";
        byte[] pData = Encoding.ASCII.GetBytes(ourPostData.ToCharArray());
        string url = "http://127.0.0.1:8080/addToCart";
        Debug.Log("before request");
        Hashtable headers = new Hashtable();
        headers.Add("Content-Type", "application/json");
        headers.Add("Cookie", "Our session cookie");
        WWW www = new WWW(url, pData, headers);
        StartCoroutine(WaitForRequest(www));
    }
    IEnumerator WaitForRequest(WWW www)    {
        yield return www;
        if (www.error == null)  {  Debug.Log("WWW Ok!: " + www.text);  }
        else  { Debug.Log("WWW Error: " + www.error); }
    }
}
