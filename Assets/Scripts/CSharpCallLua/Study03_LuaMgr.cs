using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study03_LuaMgr : MonoBehaviour
{
    private void Start() {
        LuaMgr.Instance.Init();

        LuaMgr.Instance.DoLuaFile("Main");
    }
}
