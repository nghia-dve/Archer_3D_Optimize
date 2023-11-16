using System;
using UnityEngine;


public class FireballButtonShuriken : MonoBehaviour
{
    //Example script

    public ParticleSystem fireball;		//Place fireball prefab
    public float speed = 1000.0f;

    public void OnMouseDown()
    {

        fireball.transform.position = new Vector3((float)UnityEngine.Random.Range(4, 4), 10.0f, (float)UnityEngine.Random.Range(13, 13));
        fireball.Play();

    }
}