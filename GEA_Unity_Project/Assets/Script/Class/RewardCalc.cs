using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;

    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void Play()
    {
        int hour = playSeconds / 60 / 60;
        int min = playSeconds / 60 % 60;
        int Seconds = playSeconds % 60;

        Debug.Log(hour + ":" + min + ":" + Seconds);

        Debug.Log("1인당" + gold / members + ", 리더보너스" + gold % members);

        Debug.Log(kills*expPerKill*expRate+"("+"기본"+kills*expPerKill+")");
    }


}
