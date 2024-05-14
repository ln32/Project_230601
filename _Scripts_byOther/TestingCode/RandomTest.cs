using System;
using UnityEngine;

public class RandomTest: MonoBehaviour
{


    // �־��� ��հ� ǥ�� ������ ���� ���� ������ ������ ���� ���� �����Ͽ� ��ȯ�ϴ� �޼ҵ�
    public static double GetRandomNumber(double mean, double standardDeviation)
    {
        System.Random random = new System.Random();
        double u1 = 1.0 - random.NextDouble(); // ���� ����
        double u2 = 1.0 - random.NextDouble();
        double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); // ���� ������ ������ �� ����
        double randNormal = mean + standardDeviation * randStdNormal; // ��հ� ǥ�� ���� ����

        // ��� ���� �ּ� 50%, �ִ� 200%�� ���� ����
        randNormal = Mathf.Clamp((float)randNormal, (float)(mean * 0.5), (float)(mean * 2));

        return randNormal;
    }

    private void Start()
    {
        double mean = 100; // ���
        double standardDeviation = 10; // ǥ�� ����

        for (int i = 0; i < 100; i++)
        {
            double randomValue = GetRandomNumber(mean, standardDeviation);
            Debug.Log("���� ��: " + randomValue);
        }
    }
}