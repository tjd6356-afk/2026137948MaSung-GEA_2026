using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000;
    public int killCount = 3;

    [ContextMenu("레벨 계산")]
    void ClaculateLevel()
    {
        int level = 1;
        int exp = 0;

        for (int row = 1; row <= killCount; row++)
        {
            exp += expPerKill;

            while (exp > level * 10000)
            {
                exp -= level * 10000;
                level++;

                Debug.Log("레벨업! Lv" + level + "(" + row + "마리째)");
            }
        }
        Debug.Log("최종 Lv" + level + ", 경험치" + exp + " / 50000");

    }
}
