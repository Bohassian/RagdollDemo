using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public float killRadius = 2f;
    public GameObject enemy1RagdollPrefab;
    public GameObject enemy2RagdollPrefab;

    GameObject enemy1;
    GameObject enemy2;
    float enemy1Distance;
    float enemy2Distance;

    private void Start()
    {
        enemy1 = EnemyManager.Instance.enemy1;
        enemy2 = EnemyManager.Instance.enemy2;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy1 != null)
        {
            enemy1Distance = Vector3.Distance(enemy1.transform.position, transform.position);

            if (enemy1Distance <= killRadius)
            {
                KillModel(enemy1);
            }
        }
        if (enemy2 != null)
        {
            enemy2Distance = Vector3.Distance(enemy2.transform.position, transform.position);

            if (enemy2Distance <= killRadius)
            {
                KillModel(enemy2);
            }
        }
    }

    void KillModel(GameObject enemy)
    {
        Debug.Log("Attempting to destroy enemy!");

        if (enemy == enemy1)
        {
            Instantiate<GameObject>(enemy1RagdollPrefab);
        }
        if (enemy == enemy2)
        {
            Instantiate<GameObject>(enemy2RagdollPrefab);
        }

        Destroy(enemy);
    }
}
