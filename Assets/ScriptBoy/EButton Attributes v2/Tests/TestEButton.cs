using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptBoy.EButtonTests
{
    public class TestEButton : MonoBehaviour
    {
        [EButton("Print Hello world!")]
        void PrintHelloWorld()
        {
            print("Hello world!");
        }

        [EButton.BeginHorizontal, EButton.BeginVertical("A"), EButton]
        void A1()
        {
            print("void A1()");
        }

        [EButton]
        void A2()
        {
            print("void A2()");
        }

        [EButton, EButton.EndVertical]
        void A3()
        {
            print("void A3()");
        }


        [EButton.BeginVertical("B"), EButton]
        void B3()
        {
            print("void B3()");
        }

        [EButton]
        void B2()
        {
            print("void B2()");
        }


        [EButton()]
        void B1()
        {
            print("void B1()");
        }
    }
}