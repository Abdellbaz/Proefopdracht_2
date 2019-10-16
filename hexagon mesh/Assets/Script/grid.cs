using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour
{
    public GameObject cube;
    GameObject[,] objs = new GameObject[7,7];


    void Start()
    {
        
    

        for (int row = 0; row < objs.GetLength(0); row++)
        {
            for (int col = 0; col < objs.GetLength(1); col++)
            {   if(col % 2 == 0) {
                objs[row, col] = (GameObject)Instantiate(cube, new Vector3(1.1f * row, 0.85f * col, 0), Quaternion.identity);
                }
                else
                {
                 objs[row, col] = (GameObject)Instantiate(cube, new Vector3(1.1f * row + 0.55f, 0.85f * col , 0), Quaternion.identity);
                }
                objs[row, col].transform.parent = gameObject.transform;

            }
        }


    }

}
