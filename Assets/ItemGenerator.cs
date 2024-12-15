using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    public GameObject unityChan;
    private int startPos = 80;
    private int goalPos = 360;
    private float posRange = 3.4f;
    private float generatePosZ;
    private int interval = 15;
    // Start is called before the first frame update
    void Start()
    {
        unityChan = GameObject.Find("unitychan");
        generatePosZ = startPos;        
    }

    // Update is called once per frame
    void Update()
    {
        //«lesson6@”­“W‰Û‘è
        float i = unityChan.transform.position.z + 60f;
        if (i >= startPos && i < goalPos) {
            if (i >= generatePosZ + interval) {
                Generate(i);
                generatePosZ = i;
            }
        }
    }

    void Generate(float i) {
        {
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {
                for (int j = -1; j <= 1; j++)
                {
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-5, 6);
                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
        }
    }
}