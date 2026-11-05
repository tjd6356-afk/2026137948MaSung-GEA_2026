using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public int currentHp = 7;
    public int maxHp = 10;

    [ContextMenu("체력")]
    void PrintHP()
    {
        Debug.Log("Hp" + (100/maxHp * currentHp) + "%");
    }

    [ContextMenu("체력")]
    void PrintHp()
    {
        int a = (int)((float)currentHp / maxHp * 100);           // 방법 1
        Debug.Log("HP " + a + "%");

        int b = currentHp * 100 / maxHp;                           // 방법 2
        Debug.Log("HP " + b + "%");
    }

}
