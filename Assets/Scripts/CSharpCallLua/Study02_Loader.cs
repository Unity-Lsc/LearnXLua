using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

public class Study02_Loader : MonoBehaviour
{
    private void Start() {

        LuaEnv env = new LuaEnv();

        //xLua提供的路径重定向的方法  允许我们自定义加载Lua文件的规则
        env.AddLoader(MyCustomLoader);

        env.DoString("require('Main')");
        env.DoString("require('Mainss')");


    }

    private byte[] MyCustomLoader(ref string filePath) {

        string path = Application.dataPath + "/LuaScripts/" + filePath + ".lua";
        Debug.Log(path);

        if(File.Exists(path)) {
            return File.ReadAllBytes(path);
        }else {
            Debug.LogError("MyCustomLoader重定向失败,文件名:" + filePath);
        }

        return null;
    }

}
