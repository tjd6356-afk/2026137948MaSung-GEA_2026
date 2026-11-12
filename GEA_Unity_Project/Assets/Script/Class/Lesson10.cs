using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 0;
        bool hasShield = true;
        bool isDead = hp <= 0;
        Debug.Log(isDead);                // 이건 나오고 답 : True
        Debug.Log(isDead && !hasShield);  // 이건 나오고 답 : True && false
        Debug.Log(isDead || hasShield);   // 이건 나오고 답 : 
        Debug.Log(!(hp > 0) == isDead);   // 이건 오류 || 안 나온다.
    }

    [ContextMenu("계단")]
    void stay()
    {
        int height = 3;

        string resuit = "";

        for (int row = 1; row <= height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                resuit += "*";
            }
            resuit += "\n";
        }
        Debug.Log(resuit);
    }


}
