using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Charecterselection : MonoBehaviour {

    private GameObject[] charecterlist;
    private int index = 0;

    private void Start()
    {
        
        charecterlist = new GameObject[transform.childCount];

        //fill the models in the array
        for(int i =0; i< transform.childCount; i++)
        {
            charecterlist[i] = transform.GetChild(i).gameObject;
        }
        //toggle  off their renderer
        foreach(GameObject go in charecterlist)
        {
            go.SetActive(false);
        }

        //toggle on thr first charecter
        if (charecterlist[0])
        {
            charecterlist[0].SetActive(true);
        }

        
    }

    public void toggleleft()
    {
        //toggle off the current charecter 
        charecterlist[index].SetActive(false);

        index--;
        if(index < 0)
        {
            index = charecterlist.Length - 1;
        }

        //toggle on the new model 

        charecterlist[index].SetActive(true);

    }

    public void toggleright()
    {
        //toggle off the current charecter 
        charecterlist[index].SetActive(false);

        index++;
        if (index == charecterlist.Length)
        {
            index = 0;
        }

        //toggle on the new model 

        charecterlist[index].SetActive(true);

    }

    public void conform()
    {
        SceneManager.LoadScene("");
    }
}

