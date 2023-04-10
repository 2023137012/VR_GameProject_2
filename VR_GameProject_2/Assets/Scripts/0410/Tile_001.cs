using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_001 : MonoBehaviour
{
    public GameObject tile_002;
    public GameObject tile_003;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile_002);
                temp.transform.position = new Vector3(i, 0, j);
            }

            for (int j = 10; j < 20; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile_003);
                temp.transform.position = new Vector3(i, 0, j);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
