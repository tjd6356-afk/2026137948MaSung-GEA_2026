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

        int KillExp = (int)(kills * expPerKill * expRate);

        int levelUPNeedLevelExp = 100;
        int Level = 1;
        int NowLevel = KillExp / levelUPNeedLevelExp + Level;
        int NowLevelExp = KillExp % levelUPNeedLevelExp;

        Debug.Log(hour + ":" + min + ":" + Seconds);

        Debug.Log("1인당" + gold / members + ", 리더보너스" + gold % members);

        Debug.Log("경험치" + KillExp + "(" + "기본" + kills * expPerKill + ")");

        Debug.Log("Lv" + NowLevel + ", 다음 레벨까지" + (levelUPNeedLevelExp - NowLevelExp));

        Debug.Log("평균 데미지" +(float)totalDamage / hits);
    }


}
