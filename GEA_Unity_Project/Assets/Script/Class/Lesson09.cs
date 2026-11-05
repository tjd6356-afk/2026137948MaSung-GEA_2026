using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    public int attack = 10;
    int KillCount = 0;

    [ContextMenu("처치")]
    void CountKill()
    {
        int defence = 3;
        KillCount = KillCount + 1;
        Debug.Log(attack - defence);
        Debug.Log(KillCount);
    }

    [ContextMenu("Hello")]
    void Hello()
    {
        Debug.Log("Hello");
    }
    [ContextMenu("테스트1")]
    void Test1()
    {
        int hp = 10;
        Debug.Log(hp);
    }

    [ContextMenu("테스트2")]
    void Test2()
    {
        int hp = 7;
        Debug.Log(hp);
    }

    public int gold = 100;

    [ContextMenu("골드 보기")]
    void ShowGold()
    {
        Debug.Log(gold);
    }

    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 10;
        hp = hp - 3;
        Debug.Log(hp);
        hp = 20;
        Debug.Log(hp);
        int maxHp = hp;
        hp = 5;
        Debug.Log(maxHp);
    }

    [ContextMenu("예측 2")]
    void Predict2()
    {
        int hp = 7;
        int maxHp = 10;
        Debug.Log(hp / maxHp);
        Debug.Log((float)hp / maxHp);
        Debug.Log(hp / 2);
        Debug.Log(hp / 2f);
        Debug.Log(hp % 2);
    }

    [ContextMenu("예측 3")]
    void Predict3()
    {
        int a = 1;
        int b = 2;
        Debug.Log("합: " + a + b);
        Debug.Log("합: " + (a + b));
        Debug.Log(a + b + "점");
        Debug.Log("HP " + 7 / 2);
    }


    [ContextMenu("오버플로")]
    void Overflow()
    {
        int gold = int.MaxValue;
        Debug.Log(gold);
        gold = gold + 1;
        Debug.Log(gold);
        byte red = 255;
        red++;
        Debug.Log(red);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(attack);
    }

    void Hit()
    {
        KillCount = KillCount + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
