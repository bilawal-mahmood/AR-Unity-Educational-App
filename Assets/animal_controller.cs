using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;

using Unity.XR.CoreUtils;
using UnityEngine;

public class animal_controller : MonoBehaviour
{
    public GameObject cat;
    public GameObject Lion;
    public GameObject Dog;
    public int current = 0;
    public List<GameObject> names;
     
    void Start()
    {

        names.Add(cat);
        names.Add(Lion);
        names.Add(Dog);
        names[current].SetActive(true);
    }
    public void movenext()
    {
        if (current < names.Count-1)
        {
            Debug.Log(names.Count);
            names[current].SetActive(false);
            names[current + 1].SetActive(true);
            current++;
        }

    }
    public void moveback()
    {
        if (current > 0)
        {
            Debug.Log(names.Count);
            names[current].SetActive(false);
            names[current -1].SetActive(true);
            current--;
        }

    }

}
