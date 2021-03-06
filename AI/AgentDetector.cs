using Manicomio.ActionableObjects;
using UnityEngine;

public class AgentDetector : MonoBehaviour
{
    [Tooltip("The actionable object this detector controls")]
    [SerializeField] ActionableObject actionableGameObject;

    public IActionableObject GetActionableObject() {
        return actionableGameObject;
    }
}
