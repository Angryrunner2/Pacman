using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    int[,] levelMap =
     {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
        };
    
        // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        float r = 0; 
        float x = 0;
        //float increase = 1.39F;
        // float y = 0; 
        //  for (i = 0; i < 2; i++) ;
        //   Instantiate(GameObject.FindWithTag(levelMap[pos,pos]+""), new Vector3(0 + x, 0, 0), Quaternion.identity);
        // x += 1.39F;
        // pos += 1;
        // Debug.Log(x);
        //  Debug.Log(i);

        //for (i = 0; i < 2; i++); 
        Instantiate(GameObject.FindWithTag(levelMap[i, 0] + ""), new Vector3(x, 0, 0), Quaternion.identity);
        i ++;
        x += 1.39F;
        r -= 90;
        Instantiate(GameObject.FindWithTag(levelMap[i, 0] + ""), new Vector3(x, 0, 0), Quaternion.identity).transform.Rotate(0, 0, r, Space.Self); ;
        i++;
        x += 1.39F;
        Instantiate(GameObject.FindWithTag(levelMap[i, 0] + ""), new Vector3(x, 0, 0), Quaternion.identity).transform.Rotate(0, 0, r, Space.Self);
        i++;
        x += 1.39F;
        Instantiate(GameObject.FindWithTag(levelMap[i, 0] + ""), new Vector3(x, 0, 0), Quaternion.identity).transform.Rotate(0, 0, r, Space.Self); ;
        i++;
        x += 1.39F;
        Instantiate(GameObject.FindWithTag(levelMap[i, 0] + ""), new Vector3(x, 0, 0), Quaternion.identity).transform.Rotate(0, 0, r, Space.Self); ;
        i++;
        x += 1.39F;
        Instantiate(GameObject.FindWithTag(levelMap[i, 0] + ""), new Vector3(x, 0, 0), Quaternion.identity).transform.Rotate(0, 0, r, Space.Self); ;
        i++;
        x += 1.39F;
        Instantiate(GameObject.FindWithTag(levelMap[i, 0] + ""), new Vector3(x, 0, 0), Quaternion.identity).transform.Rotate(0, 0, r, Space.Self); ;
        i++;
        x += 1.39F;
        Instantiate(GameObject.FindWithTag(levelMap[i, 0] + ""), new Vector3(x, 0, 0), Quaternion.identity).transform.Rotate(0, 0, r, Space.Self); ;
        i++;
        x += 1.39F;
        Instantiate(GameObject.FindWithTag(levelMap[i, 0] + ""), new Vector3(x, 0, 0), Quaternion.identity).transform.Rotate(0, 0, r, Space.Self); ;
        i++;
        x += 1.39F;
        
        Instantiate(GameObject.FindWithTag(levelMap[8, 0] + ""), new Vector3(x, 0, 0), Quaternion.identity).transform.Rotate(0, 0, r, Space.Self); ;
        i++;
        x += 1.39F;
        Debug.Log(i);
        //pos =+ increase; 

    }

    // Update is called once per frameS
    void Update()
    {
        
    }
}
