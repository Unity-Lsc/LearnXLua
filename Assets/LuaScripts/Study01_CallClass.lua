print("***********************Lua调用C#相关知识点***********************")

GameObject = CS.UnityEngine.GameObject
Debug = CS.UnityEngine.Debug
Vector3 = CS.UnityEngine.Vector3

--通过C#中的类,实例化一个对象 lua中没有new 直接类名括号就是实例化对象
--默认调用的,相当于是无参构造
local obj = CS.UnityEngine.GameObject()
local obj2 = CS.UnityEngine.GameObject("obj")
local obj3 = GameObject("obj2")

local obj4 = GameObject.Find("obj2")
Debug.Log(obj4.transform.position)

--使用对象中的成员方法,一定要用:
obj4.transform:Translate(Vector3.right * 10)
Debug.Log(obj4.transform.position)

local t1 = CS.Test1()
t1:Speak("说话...")

local t2 = CS.LSC.Test2()
t2:Speak("说话....")

local obj5 = GameObject("AddComponent测试")
obj5:AddComponent(typeof(CS.LuaCallCSharp))