using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFurniture : MonoBehaviour
{
    GameObject gb;      //初始化
    public string gbtag;     //方便调用，循环利用
    void Start()
    {
        gb = GameObject.FindGameObjectWithTag(gbtag);

        gb.SetActive(false);   //设置开始可见性（此处最新修改与2017年7月8日）


    }
    public void ChangeVisibility()
    {   //控制显示和隐藏的方法
        if (gb.activeSelf == true)
        {
            gb.SetActive(false);

        }
        else if (gb.activeSelf == false)
        {
            gb.SetActive(true);
        }
    }


}