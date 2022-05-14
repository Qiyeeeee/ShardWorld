using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCon : MonoBehaviour
{
    private bool InMap = false;
    private bool Drag = false;
    private Vector2 LasteMousePosition;
    private Vector2 NewObjectPosition;
    private Vector2 PreviousObjectPosition;
    // Start is called before the first frame update

    [System.Serializable]
    public class Boundray
    {

        public float xMax;
        public float xMin;
        public float yMax;
        public float yMin;

    }

    public Boundray boundray;
    void Start()
    {
        


    }
    int judgePo()
    {
        NewObjectPosition = this.gameObject.transform.position;
        int[,] m = GameObject.Find("MAP").GetComponent<OverCon>().Map;
        int i = int.Parse(this.gameObject.name);

        if (NewObjectPosition.x >= -200 && NewObjectPosition.x <= -100)
        {
            if (NewObjectPosition.y >= -200 && NewObjectPosition.y <= -100)
            {
                if (m[0,0] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(-150f, -150f);
                    m[0, 0] = i;
                    return 1;
                }
            }
            else if (NewObjectPosition.y >= -100 && NewObjectPosition.y <= 0)
            {
                if (m[1, 0] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(-150f, -50f);
                    m[1, 0] = i;
                    return 1;
                }    
            }
            else if (NewObjectPosition.y >= 0 && NewObjectPosition.y <= 100)
            {
                if (m[2, 0] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(-150f, 50f);
                    m[2, 0] = i;
                    return 1;
                }
            }
            else if (NewObjectPosition.y >= 100 && NewObjectPosition.y <= 200)
            {
                if (m[3, 0] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(-150f, 150f);
                    m[3, 0] = i;
                    return 1;
                }     
            }
            else
            {
                return -1;
            }
        }
        else if (NewObjectPosition.x >= -100 && NewObjectPosition.x <= 0)
        {
            if (NewObjectPosition.y >= -200 && NewObjectPosition.y <= -100)
            {
                if (m[0, 1] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(-50f, -150f);
                    m[0, 1] = i;
                    return 1;
                }           
            }
            else if (NewObjectPosition.y >= -100 && NewObjectPosition.y <= 0)
            {
                if (m[1, 1] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(-50f, -50f);
                    m[1, 1] = i;
                    return 1;
                }        
            }
            else if (NewObjectPosition.y >= 0 && NewObjectPosition.y <= 100)
            {
                if (m[2, 1] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(-50f, 50f);
                    m[2, 1] = i;
                    return 1;
                }      
            }
            else if (NewObjectPosition.y >= 100 && NewObjectPosition.y <= 200)
            {
                if (m[3, 1] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(-50f, 150f);
                    m[3, 1] = i;
                    return 1;
                }          
            }
            else
            {
                return -1;
            }
        }
        else if (NewObjectPosition.x >= 0  && NewObjectPosition.x <= 100)
        {
            if (NewObjectPosition.y >= -200 && NewObjectPosition.y <= -100)
            {
                if (m[0, 2] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(50f, -150f);
                    m[0, 2] = i;
                    return 1;
                }    
            }
            else if (NewObjectPosition.y >= -100 && NewObjectPosition.y <= 0)
            {
                if (m[1, 2] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(50f, -50f);
                    m[1, 2] = i;
                    return 1;
                }         
            }
            else if (NewObjectPosition.y >= 0 && NewObjectPosition.y <= 100)
            {
                if (m[2, 2] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(50f, 50f);
                    m[2, 2] = i;
                    return 1;
                }        
            }
            else if (NewObjectPosition.y >= 100 && NewObjectPosition.y <= 200)
            {
                if (m[3, 2] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(50f, 150f);
                    m[3, 2] = i;
                    return 1;
                }      
            }
            else
            {
                return -1;
            }
        }
        else if (NewObjectPosition.x >= 100 && NewObjectPosition.x <= 200)
        {
            if (NewObjectPosition.y >= -200 && NewObjectPosition.y <= -100)
            {
                if (m[0, 3] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(150f, -150f);
                    m[0, 3] = i;
                    return 1;
                }          
            }
            else if (NewObjectPosition.y >= -100 && NewObjectPosition.y <= 0)
            {
                if (m[1, 3] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(150f, -50f);
                    m[1, 3] = i;
                    return 1;
                }          
            }
            else if (NewObjectPosition.y >= 0 && NewObjectPosition.y <= 100)
            {
                if (m[2, 3] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(150f, 50f);
                    m[2, 3] = i;
                    return 1;
                }         
            }
            else if (NewObjectPosition.y >= 100 && NewObjectPosition.y <= 200)
            {
                if (m[3, 3] != 0)
                {
                    return -1;
                }
                else
                {
                    this.gameObject.transform.position = new Vector2(150f, 150f);
                    m[3, 3] = i;
                    return 1;
                }          
            }
            else
            {
                return -1;
            }
        }
        else
        {
            return -1;
        }
    }

    int updatePo()
    {       
        int[,] m = GameObject.Find("MAP").GetComponent<OverCon>().Map;

        int judge = judgePo();

        if (judge == -1)
        {
            return judge;
        }
        else
        {
            if (PreviousObjectPosition.x >= -200 && PreviousObjectPosition.x <= -100)
            {
                if (PreviousObjectPosition.y >= -200 && PreviousObjectPosition.y <= -100)
                {
                    m[0, 0] = 0;                    
                }
                else if (PreviousObjectPosition.y >= -100 && PreviousObjectPosition.y <= 0)
                {                   
                    m[1, 0] = 0;                   
                }
                else if (PreviousObjectPosition.y >= 0 && PreviousObjectPosition.y <= 100)
                {                  
                    m[2, 0] = 0;
                }
                else if (PreviousObjectPosition.y >= 100 && PreviousObjectPosition.y <= 200)
                {                    
                    m[3, 0] = 0;
                }               
            }
            else if (PreviousObjectPosition.x >= -100 && PreviousObjectPosition.x <= 0)
            {
                if (PreviousObjectPosition.y >= -200 && PreviousObjectPosition.y <= -100)
                {
                    m[0, 1] = 0;
                }
                else if (PreviousObjectPosition.y >= -100 && PreviousObjectPosition.y <= 0)
                {
                    m[1, 1] = 0;
                }
                else if (PreviousObjectPosition.y >= 0 && PreviousObjectPosition.y <= 100)
                {                  
                    m[2, 1] = 0;
                }
                else if (PreviousObjectPosition.y >= 100 && PreviousObjectPosition.y <= 200)
                {                    
                    m[3, 1] = 0;
                }
            }
            else if (PreviousObjectPosition.x >= 0 && PreviousObjectPosition.x <= 100)
            {
                if (PreviousObjectPosition.y >= -200 && PreviousObjectPosition.y <= -100)
                {                    
                    m[0, 2] = 0;
                }
                else if (PreviousObjectPosition.y >= -100 && PreviousObjectPosition.y <= 0)
                {                   
                    m[1, 2] = 0;
                }
                else if (PreviousObjectPosition.y >= 0 && PreviousObjectPosition.y <= 100)
                {
                    m[2, 2] = 0;
                }
                else if (PreviousObjectPosition.y >= 100 && PreviousObjectPosition.y <= 200)
                {                   
                    m[3, 2] = 0;
                }
            }
            else if (PreviousObjectPosition.x >= 100 && PreviousObjectPosition.x <= 200)
            {
                if (PreviousObjectPosition.y >= -200 && PreviousObjectPosition.y <= -100)
                {                    
                    m[0, 3] = 0;
                }
                else if (PreviousObjectPosition.y >= -100 && PreviousObjectPosition.y <= 0)
                {                   
                    m[1, 3] = 0;
                }
                else if (PreviousObjectPosition.y >= 0 && PreviousObjectPosition.y <= 100)
                {                   
                    m[2, 3] = 0;
                }
                else if (PreviousObjectPosition.y >= 100 && PreviousObjectPosition.y <= 200)
                {                   
                    m[3, 3] = 0;
                }               
            }


            return judge;

        }
    }

    // Update is called once per frame
    void Update()
    {   if (InMap == false)
        {
            Vector2 Mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //�����������λ��


            if (Input.GetMouseButtonDown(0))
            {
                float Distance = ((Vector2)this.gameObject.transform.position - Mouseposition).magnitude;
                PreviousObjectPosition = this.gameObject.transform.position;
                if (Distance < 50.0f)
                {
                    Drag = true;
                    LasteMousePosition = Mouseposition;
                    //������λ�õ������λ�ã�����Ҫ�õ���           
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                Drag = false;
                NewObjectPosition = this.gameObject.transform.position;

                if (Mathf.Clamp(NewObjectPosition.x, boundray.xMin, boundray.xMax) == NewObjectPosition.x && Mathf.Clamp(NewObjectPosition.y, boundray.yMin, boundray.yMax) == NewObjectPosition.y)
                {
                    if (judgePo() == -1)
                    {
                        this.gameObject.transform.position = PreviousObjectPosition;
                        this.gameObject.transform.rotation = new Quaternion(0.0f, 0, 0, 0);
                        Debug.Log("Location occupied");
                    }
                    else 
                    {
                        this.gameObject.transform.rotation = new Quaternion(0.0f, 0, 0, 0);
                        InMap = true;
                    }
                                  
                }
                else
                {
                    this.gameObject.transform.position = PreviousObjectPosition;
                    this.gameObject.transform.rotation = new Quaternion(0.0f, 0, 0, 0);                   
                }
                
                                    
                
            }

            if (Drag)
            {
                Vector2 DeltaVec = Mouseposition - LasteMousePosition;
                //���λ��������λ�õ��������
              

                this.gameObject.transform.position = (Vector2)this.gameObject.transform.position + DeltaVec;
                //��굱ǰλ�ü�������֮��һ��ʼ�����λ�ã��õ�����ƶ�λ�ã��Ӷ�ȡ��������������ĵ�������ƶ�������

                LasteMousePosition = Mouseposition;
                //����ٶ��������λ�ý��и��£����򽫻���������ƶ�����һֱ�ƶ�

            }
        }

        else if (InMap == true)
        {
            Vector2 Mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //�����������λ��


            if (Input.GetMouseButtonDown(0))
            {
                float Distance = ((Vector2)this.gameObject.transform.position - Mouseposition).magnitude;
                PreviousObjectPosition = this.gameObject.transform.position;
                if (Distance < 50.0f)
                {
                    Drag = true;
                    LasteMousePosition = Mouseposition;
                    //������λ�õ������λ�ã�����Ҫ�õ���

                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                Drag = false;
                //NewObjectPosition = this.gameObject.transform.position;
                int i = updatePo();
                if(i == 1)
                {
                    this.gameObject.transform.rotation = new Quaternion(0.0f, 0, 0, 0);
                }
                else
                {
                    this.gameObject.transform.position = PreviousObjectPosition;
                    this.gameObject.transform.rotation = new Quaternion(0.0f, 0, 0, 0);
                    
                }

            }

            if (Drag)
            {
                Vector2 DeltaVec = Mouseposition - LasteMousePosition;


                //���λ��������λ�õ��������
                NewObjectPosition = (Vector2)this.gameObject.transform.position + DeltaVec;

                if (Mathf.Clamp(NewObjectPosition.x, boundray.xMin, boundray.xMax) == boundray.xMax)
                {
                    NewObjectPosition.x = boundray.xMax;
                }
                if (Mathf.Clamp(NewObjectPosition.x, boundray.xMin, boundray.xMax) == boundray.xMin)
                {
                    NewObjectPosition.x = boundray.xMin;
                }
                if (Mathf.Clamp(NewObjectPosition.y, boundray.yMin, boundray.yMax) == boundray.yMax)
                {
                    NewObjectPosition.y = boundray.yMax;
                }
                if (Mathf.Clamp(NewObjectPosition.y, boundray.yMin, boundray.yMax) == boundray.yMin)
                {
                    NewObjectPosition.y = boundray.yMin;
                }


                this.gameObject.transform.position = NewObjectPosition;
                //��굱ǰλ�ü�������֮��һ��ʼ�����λ�ã��õ�����ƶ�λ�ã��Ӷ�ȡ��������������ĵ�������ƶ�������

                LasteMousePosition = Mouseposition;
                //����ٶ��������λ�ý��и��£����򽫻���������ƶ�����һֱ�ƶ�

            }
        }
        
    }


}
