using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Anim : NghiaMonoBehaviour
{
    private string currentState;
    [SerializeField]
    protected Animator animator;

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
        Debug.Log("currentState" + currentState);
        if (currentState == newState)
        {
            currentState = null;
            return null;
        }
        //string s = "";
        //for (int i = 0; i < newState.Length; i++)
        //{
        //    if (newState[i].ToString().Contains(" "))
        //    {
        //        break;
        //    }
        //    s += newState[i];
        //}
        currentState = newState;

        return currentState;
    }
}
