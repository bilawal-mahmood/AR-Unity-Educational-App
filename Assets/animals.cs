using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class animals : MonoBehaviour
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
    public void Scene3()
    {
        SceneManager.LoadScene("SampleScene3");
    }
}
