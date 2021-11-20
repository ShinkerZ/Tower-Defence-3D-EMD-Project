using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovamant : MonoBehaviour
{
    public Transform Base;
    float speed = 5f;

    int[] numbers = new int[4];

    List<int> numbers2 = new List<int>(); //List Numbers

    List<GameObject> soldiers = new List<GameObject>();


    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); //Move Enemy

        numbers[0] = 5;
        numbers[1] = 6;
        numbers[2] = 7;
        numbers[3] = 8;
        Avg(numbers);

        //LIst
        numbers2.Add(4);
        numbers2.Add(6);
        numbers2.Add(8);
        numbers2.Insert(2, 7);

        //numbers2.RemoveAt(1)

        foreach (int num in numbers2)
        {
            Debug.Log(num);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) //Move Enemy
        {

            agent.SetDestination(Base.position);
        }

    }
    public void Avg(int[] arr)
    {
        float sum = 0;
        int index = 0; //initialization
        while (index < arr.Length)//Stop conditions
        {
            sum += arr[index];
            index++;//promotion
        }
        float avg = sum / arr.Length;
        Debug.Log(avg);
    }

}
