using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        #region test
        //if (other.name == "Fireball")
        //{
        //    var enemyControl = other.transform.parent.parent.parent.GetComponent<EnemyControl>();
        //    if (enemyControl.IsAttack)
        //    {
        //        hpPlayer--;
        //    }
        //}
        #endregion
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"OnCollisionEnter = {collision.gameObject.tag}");

    }
}
