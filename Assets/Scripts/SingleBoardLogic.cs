using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.ARStarterAssets;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class SingleBoardLogic : MonoBehaviour
{
    [SerializeField] private ObjectSpawner spawner;
    [SerializeField] private ARInteractorSpawnTrigger spawnTrigger;
    
    private void OnEnable()
    {
        spawner.objectSpawned += OnBoardSpawned;
    }

    private void OnDisable()
    {
        spawner.objectSpawned -= OnBoardSpawned;
    }

    private void OnBoardSpawned(GameObject board)
    {
        spawnTrigger.enabled = false;

        if (Mathf.Abs(Vector3.Dot(board.transform.up, Vector3.up)) < 0.9f)
        {
            Vector3 wallFix = Vector3.ProjectOnPlane(Vector3.up, board.transform.up).normalized;
            board.transform.rotation = Quaternion.LookRotation(wallFix, board.transform.up);
        }
    }
}
