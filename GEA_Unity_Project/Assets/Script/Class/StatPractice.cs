using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName = "나는 키호테 거기에 고귀하다는 성을 붙여 돈 키호테";
    public int Level = 99;
    public float attack = 12.5f;
    public bool isBoss = true;

    [ContextMenu("스텟")]
    void ShowStat()
    {
        Debug.Log(playerName);
        Debug.Log(Level);
        Debug.Log(attack);
        Debug.Log(isBoss);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
