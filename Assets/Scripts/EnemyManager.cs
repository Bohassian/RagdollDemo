using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    #region Singleton

    public static EnemyManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    #endregion

    public GameObject enemy1;
    public GameObject enemy2;
}
