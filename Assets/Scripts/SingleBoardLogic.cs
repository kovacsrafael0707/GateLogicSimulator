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
    }
}
