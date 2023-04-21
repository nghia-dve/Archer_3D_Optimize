using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    private string currentState;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public string ChangeCurrentState(string newState)
    {
        if (currentState == newState) return null;
        string s = "";
        for (int i = 0; i < newState.Length; i++)
        {
            if (newState[i].ToString().Contains(" "))
            {
                break;
            }
            s += newState[i];
        }
        currentState = newState;
        Debug.Log("currentState" + currentState);
        return currentState;
    }
}
