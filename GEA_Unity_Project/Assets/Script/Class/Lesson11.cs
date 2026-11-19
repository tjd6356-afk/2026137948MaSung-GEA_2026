using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    [ContextMenu("배열")]
    void ArrayLoop()
    {
        int[] scores = { 90, 75, 60, 88 };
        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        Debug.Log("합 " + sum);
        Debug.Log("평균 " + (float)sum / scores.Length);
    }




}
