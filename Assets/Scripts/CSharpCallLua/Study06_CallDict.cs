using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study06_CallDict : MonoBehaviour
{
    private void Start() {

        LuaMgr.Instance.Init();
        LuaMgr.Instance.DoLuaFile("Main");

        List<int> list = LuaMgr.Instance.Global.Get<List<int>>("testList");
        Debug.Log("************************List***********************");
        for (int i = 0; i < list.Count; i++) {
            Debug.Log(list[i]);
        }

        List<object> listObj = LuaMgr.Instance.Global.Get<List<object>>("testList2");
        Debug.Log("************************ListObj***********************");
        for (int i = 0; i < listObj.Count; i++) {
            Debug.Log(listObj[i]);
        }

        Dictionary<string, int> dict = LuaMgr.Instance.Global.Get<Dictionary<string, int>>("testDict");
        Debug.Log("************************Dict***********************");
        foreach (string item in dict.Keys) {
            Debug.Log(item + ":" + dict[item]);
        }

        Dictionary<string, object> dict2 = LuaMgr.Instance.Global.Get<Dictionary<string, object>>("testDict2");
        Debug.Log("************************Dict2***********************");
        foreach (string item in dict2.Keys) {
            Debug.Log(item + ":" + dict2[item]);
        }

        Dictionary<object, object> dict3 = LuaMgr.Instance.Global.Get<Dictionary<object, object>>("testDict3");
        Debug.Log("************************Dict3***********************");
        foreach (object item in dict3.Keys) {
            Debug.Log(item + ":" + dict3[item]);
        }

    }
}
