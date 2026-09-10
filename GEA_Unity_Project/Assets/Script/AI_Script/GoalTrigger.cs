using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Player 본체 또는 Player의 자식 Collider 모두 대응
        if (other.CompareTag("Player") ||
            other.transform.root.CompareTag("Player"))
        {
            if (JumpMapManager.Instance != null)
            {
                JumpMapManager.Instance.ClearLevel();
            }
        }
    }
}