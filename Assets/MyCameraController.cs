using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    private GameObject unitychan;
    private float difference;
    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z-difference);
        
        GameObject coin = GameObject.FindGameObjectWithTag("CoinTag");
        if (this.transform.position.z > coin.transform.position.z)
        {
            Destroy(coin);
        }

        GameObject car = GameObject.FindGameObjectWithTag("CarTag");
        if (this.transform.position.z > car.transform.position.z)
        {
            Destroy(car);
        }

        GameObject cone = GameObject.FindGameObjectWithTag("TrafficConeTag");
        if (this.transform.position.z > cone.transform.position.z)
        {
            Destroy(cone);
        }
    }
}
