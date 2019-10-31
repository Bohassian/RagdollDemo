using UnityEngine;

public class RagdollManager : MonoBehaviour
{
    #region Singleton

    public static RagdollManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    #endregion

    public GameObject ragdoll1;
    public GameObject ragdoll2;
}
