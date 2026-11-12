using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public int attack = 12;

    public int defense = 5;

    public bool isCritical;

    public bool targetIsBoss;

    [ContextMenu("데미지")]
    void Damege()
    {
        int Damege = attack - defense;

        if (Damege < 1)
        {
            Damege = 1;
        }


        if (isCritical)
        {
            Damege = Damege * 2 ;
        }
        if (targetIsBoss)
        {
            Damege = Damege / 2;
        }
        

        Debug.Log(Damege);
    }


}
