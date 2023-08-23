using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class DataManager
{
    Entity_ItemData entity_ItemData;
    public void Init()
    {
        //입력한 엑셀값 ScriptableObject로 변환된 데이터를 로딩하기 위해
        entity_ItemData = (Entity_ItemData)Managers.Resource.Load <ScriptableObject>("ItemData");
        for (int i = 0; i < 5; i++)
        {
            Entity_ItemData.Param param = GetItemDataByIndex(i);
            string jsonStr = JsonConvert.SerializeObject(param);
            Debug.Log(jsonStr);
        }
    }
    public Entity_ItemData.Param GetItemDataByIndex(int index)
    {
        Entity_ItemData.Param targetParam = entity_ItemData.sheets[0].list.Find(param => param.index == index);
        return targetParam;
    }
}
