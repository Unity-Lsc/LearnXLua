using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test1
{
    public void Speak(string str) {
        Debug.Log("Test1:" + str);
    }
}

namespace LSC
{
    public class Test2
    {
        public void Speak(string str) {
            Debug.Log("Test2:" + str);
        }
    }
}

public class LuaCallCSharp : MonoBehaviour
{
    
}
