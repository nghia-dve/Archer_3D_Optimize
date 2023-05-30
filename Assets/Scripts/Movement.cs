using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement : NghiaMonoBehaviour
{
    [SerializeField]
    protected float rotationSpeed = 720;
    protected void LookAtTaget(GameObject gameObject, Vector3 direction)
    {
        Quaternion toRatation = Quaternion.LookRotation(direction, Vector3.up);
        gameObject.transform.rotation = Quaternion.RotateTowards(gameObject.transform.rotation,
            toRatation, rotationSpeed * Time.deltaTime);
    }
}
