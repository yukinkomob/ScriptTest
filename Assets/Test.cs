using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int mp = 53;
    private int power = 25;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Magic()
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
}

public class Kadai
{
    public void normalKadai()
    {
        string[] array = { "大逆転は、起こり得る。", "わたしは、その言葉を信じない。", "どうせ奇跡なんて起こらない。", "それでも人々は無責任に言うだろう。", "小さな者でも大きな相手に立ち向かえ。\n誰とも違う発想や工夫を駆使して戦え" };

        Debug.Log("### 同順で表示する");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        Debug.Log("### 逆順で表示する");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    public void hattenKadai()
    {
        Debug.Log("さぁ、とうとう最後のボスとの戦闘だ！");
        Boss lastBoss = new Boss();
        for (int i = 0; i < 10; i ++)
        {
            lastBoss.Magic();
        }
        Debug.Log("これが最後の魔法だ！");
        lastBoss.Magic();
    }
}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Kadai kadai = new Kadai();

        kadai.normalKadai();

        kadai.hattenKadai();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
