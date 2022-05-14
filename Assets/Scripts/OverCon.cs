using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverCon : MonoBehaviour
{
    [HideInInspector]
    public int[,] Map = new int[4, 4] {
                                        {0, 0, 0, 0} ,
                                        {0, 0, 0, 0} ,
                                        {0, 0, 0, 0} ,
                                        {0, 0, 0, 0} ,
                                        };
    public int[,] UpdateMap = new int[4, 4] {
                                            {0, 0, 0, 0} ,
                                            {0, 0, 0, 0} ,
                                            {0, 0, 0, 0} ,
                                            {0, 0, 0, 0} ,
                                            };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if(UpdateMap[i,j]!= Map[i, j])
                {
                    string l = i.ToString() + "," + j.ToString() + ":" + Map[i, j].ToString();
                    Debug.Log(l);
                    UpdateMap[i, j] = Map[i, j];
                }
                
            }
        }
    }
}
