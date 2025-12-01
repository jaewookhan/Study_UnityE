using UnityEngine;

public class Control : MonoBehaviour
{
    public int a;
    public int b;
    public string fruit;
    public int[] arr2 = new int[3];
    public char[,] ch2 = new char[3,3];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        if (a > b)
        {
            Debug.Log("a가 b보다 큽니다.");
        }
        else if (a < b)
        {
            Debug.Log("b가 a보다 큽니다.");
        }
        else
        {
            Debug.Log("a와 b는 같습니다.");
        }

        switch (this.fruit)
        {
            case "사과":
                Debug.Log("사과는 빨간색입니다.");
                break;

            case "바나나":
                Debug.Log("바나나는 노란색입니다.");
                break;

            case "포도":
                Debug.Log("포도는 보라색입니다.");
                break;

            default:
                Debug.Log("알 수 없는 과일입니다.");
                break;
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log("i의 값: " + i);
        }

        while (a < 10)
        {
            Debug.Log("a의 값: " + a);
            a++;
        }

        do
        {
            Debug.Log("b의 값: " + b);
            b--;
        } while (b < 10);
        */

        string[] array = new string[5];
        array[0] = "첫 번째";
        array[1] = "두 번째";
        array[2] = "세 번째";
        array[3] = "네 번째";
        array[4] = "다섯 번째";


        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        int[] scores = { 90, 85, 78, 92, 88 };

        for (int j = 0; j < arr2.Length; j++)
        {
            Debug.Log("배열의 값" + j + ": " + arr2[j]);
        }

        /*
        string[,] zoo = new string[3, 3];

        zoo[0, 0] = "사자";
        zoo[0, 1] = "호랑이";
        zoo[0, 2] = "곰";
        zoo[1, 0] = "원숭이";
        zoo[1, 1] = "기린";
        zoo[1, 2] = "코끼리";
        zoo[2, 0] = "펭귄";
        zoo[2, 1] = "바다사자";
        zoo[2, 2] = "물개";
        */

        int[,] samsam = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
