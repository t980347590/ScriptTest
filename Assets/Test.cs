using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{

    //int型の変数mpを宣言し、53で初期化

    private int mp = 53;

    //mpを消費して魔法攻撃をするMagic関数。
    //Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示。
    //mpが足りない場合、「MPが足りないため魔法が使えない。」と表示。

    public void magic()
    {

        
        if (mp < 5) { Debug.Log("MPが足りないため魔法が使えない。"); }
        else { Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            mp -= 5;
        }
    }
}

public class Test : MonoBehaviour {


    // Use this for initialization
    void Start () {





        //課題

        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] Array = { 0, 1, 2, 3, 4 };

        //for文を使い、配列の各要素の値を順番に表示

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(Array[i]);
        }



        //for文を使い、配列の各要素の値を逆順に表示

        for (int i = 0; i < 5; i++)
        {

            Debug.Log(Array[4 - i]);
        }


        //課題は以上。


        //発展課題

        //Magic関数を呼び出して、魔法を使用
        //Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認



        Boss lastboss = new Boss();
        for (int i = 1; i < 12; i++)
        {
            lastboss.magic();
        }

        //発展課題は以上。

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
