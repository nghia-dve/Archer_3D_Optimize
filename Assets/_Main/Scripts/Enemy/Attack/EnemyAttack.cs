using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : NghiaMonoBehaviour
{
    [SerializeField]
    private ParticleSystem fireball;
    [SerializeField]
    private EnemyControl enemyControl;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Attack();
    }
    public void Attack()
    {


        fireball.Play();

    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        fireball = transform.parent.Find("Model").Find("SpawnFireBall").Find("Fireball 02 Shuriken").GetComponent<ParticleSystem>();
        enemyControl = transform.parent.GetComponent<EnemyControl>();
    }
}
