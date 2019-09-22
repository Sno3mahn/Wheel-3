using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class pointer : MonoBehaviour
{
    public GameObject arrowHead;
    public void ArrowHead()
    {
        arrowHead.SetActive(true);
    }
  public void LoadGame1()
{
    SceneManager.LoadScene("prague");
}
public void LoadGame2()
{
    SceneManager.LoadScene("gateway");
}
public void LoadGame3()
{
    SceneManager.LoadScene("south mumbai");
}
public void LoadGame4()
{
    SceneManager.LoadScene("chi");
}
public void LoadGame5()
{
    SceneManager.LoadScene("ctr");
}
public void LoadGame6()
{
    SceneManager.LoadScene("bel");
}
public void LoadGame7()
{
    SceneManager.LoadScene("petra");
}
public void LoadGame8()
{
    SceneManager.LoadScene("wel");
}
public void LoadGame9()
{
    SceneManager.LoadScene("krj");
}
public void LoadGame10()
{
    SceneManager.LoadScene("maldives");
}

void OnTriggerEnter(Collider col){

     if(col.gameObject.tag == "error") {
     Debug.Log ("PLEASE SPIN AGAIN!");

     }
     else if (col.gameObject.tag == "red")
    {
        LoadGame1();
    }
    else if (col.gameObject.tag == "orange")
    {
        LoadGame2();
    }
    else if (col.gameObject.tag == "yellow")
    {
        LoadGame3();
    }
    else if (col.gameObject.tag == "lgreen")
    {
        LoadGame4();
    }
    else if (col.gameObject.tag == "dgreen")
    {
        LoadGame5();
    }
    else if (col.gameObject.tag == "lblue")
    {
        LoadGame6();
    }
    else if (col.gameObject.tag == "dblue")
    {
        LoadGame7();
    }
    else if (col.gameObject.tag == "purple")
    {
        LoadGame8();
    }
    else if (col.gameObject.tag == "voilet")
    {
        LoadGame9();
    }
    else if (col.gameObject.tag == "pink")
    {
        LoadGame10();
    }

    Debug.Log(col.gameObject.name);
 }

}
