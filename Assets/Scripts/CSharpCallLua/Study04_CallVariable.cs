using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study04_CallVariable : MonoBehaviour
{
    private void Start() {
        LuaMgr.Instance.Init();

        LuaMgr.Instance.DoLuaFile("Main");

        int num = LuaMgr.Instance.Global.Get<int>("testNumber");
        Debug.Log("testNumber:" + num);

        bool bo = LuaMgr.Instance.Global.Get<bool>("testBool");
        Debug.Log("testBool:" + bo);

        float fl = LuaMgr.Instance.Global.Get<float>("testFloat");
        Debug.Log("testFloat:" + fl);

        double d = LuaMgr.Instance.Global.Get<double>("testFloat");
        Debug.Log("testDouble:" + d);

        string str = LuaMgr.Instance.Global.Get<string>("testString");
        Debug.Log("testString:" + str);

    }
}
