using System.Collections.Generic;
using UnityEngine;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        int criticalCount = 0;
        int damgesSum = 0;
        List<int> criticals = new List<int>();

        foreach (int dg in damages)
        {
            if (dg > 0)
            {
                damgesSum += dg;
            }

            if (dg >= criticalLine)
            {
                criticalCount++;

                criticals.Add(dg);
            }
        }
        Debug.Log("총 데미지" + damgesSum);
        Debug.Log("치명타" + criticalCount + "회");

        foreach (int cr in criticals)
        {
            Debug.Log("치명타" + cr);
        }
    }
}
