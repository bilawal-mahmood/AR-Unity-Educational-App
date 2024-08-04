using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class interaction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void print()
    {
        Debug.Log("birds");
    }
    public void Scene1()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
