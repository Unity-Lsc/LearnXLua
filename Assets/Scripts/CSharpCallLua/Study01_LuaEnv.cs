using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class Study01_LuaEnv : MonoBehaviour
{
    private void Start() {
        //lua解释器 能够让我们在unity中执行lua
        LuaEnv env = new LuaEnv();

        //执行Lua语言
        env.DoString("print('HelloWorld')");

        env.DoString("require('Main')");

        //帮助我们清除Lua中没有手动释放的对象 垃圾回收
        //帧更新中定时执行,或者切场景时执行
        env.Tick();

        //释放Lua解释器
        env.Dispose();
    }
}
