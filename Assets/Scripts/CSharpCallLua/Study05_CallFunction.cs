using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using XLua;

public class Study05_CallFunction : MonoBehaviour
{
    //无参无返回值的委托
    public delegate void CustomCall();
    //有参有返回值的委托
    [CSharpCallLua]
    public delegate int CustomCall2(int num);
    //多返回值委托
    [CSharpCallLua]
    public delegate int CustomCall3(int a, out int b, out bool c, out string d, out int e);
    [CSharpCallLua]
    public delegate int CustomCall4(int a, ref int b, ref bool c, ref string d, ref int e);
    //变长参数 委托
    [CSharpCallLua]
    public delegate void CustomCall5(string a, params object[] args);

    private void Start() {
        LuaMgr.Instance.Init();

        LuaMgr.Instance.DoLuaFile("Main");

        //无参无返回值的获取
        //委托
        CustomCall custom = LuaMgr.Instance.Global.Get<CustomCall>("testFunc");
        custom();
        //UnityAction
        UnityAction ua = LuaMgr.Instance.Global.Get<UnityAction>("testFunc");
        ua();
        //C#提供的Action
        Action ac = LuaMgr.Instance.Global.Get<Action>("testFunc");
        ac();
        //xLua提供的获取函数的方式
        LuaFunction lf = LuaMgr.Instance.Global.Get<LuaFunction>("testFunc");
        lf.Call();

        //有参有返回值
        //委托
        CustomCall2 custom2 = LuaMgr.Instance.Global.Get<CustomCall2>("testFunc2");
        Debug.Log("有参有返回值:" + custom2(10));
        //C#自带的Func
        Func<int, int> fc = LuaMgr.Instance.Global.Get<Func<int, int>>("testFunc2");
        Debug.Log("有参有返回值:" + fc(20));
        //xLua提供
        LuaFunction lf2 = LuaMgr.Instance.Global.Get<LuaFunction>("testFunc2");
        Debug.Log("有参有返回值:" + lf2.Call(30)[0]);

        //多返回值
        //C#中使用out ref来接收
        CustomCall3 custom3 = LuaMgr.Instance.Global.Get<CustomCall3>("testFunc3");
        int b, e;
        bool c;
        string d;
        Debug.Log("第一个返回值:" + custom3(300, out b, out c, out d, out e) + "  第二个:" + b + "   第三个:" + c + "    第四个:" + d + "第五个:" + e);

        CustomCall4 custom4 = LuaMgr.Instance.Global.Get<CustomCall4>("testFunc3");
        int b1 = 0, e1 = 0;
        bool c1 = true;
        string d1 = "";
        Debug.Log("第一个返回值:" + custom4(500, ref b1, ref c1, ref d1, ref e1) + "  第二个:" + b1 + "   第三个:" + c1 + "    第四个:" + d1 + "第五个:" + e1);

        //变长参数
        CustomCall5 custom5 = LuaMgr.Instance.Global.Get<CustomCall5>("testFunc4");
        custom5("lsc", "ss", 4, false, 5.5f, 30);
    }

}
