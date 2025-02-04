﻿using System;
using Chapter02.Examples.CsharpKeywords.VirtualMethod;
using Chapter02.Examples.Encapsulation;

namespace Chapter02.Examples.CsharpKeywords.Other.ValueTuple
{
    public static class Demo
    {
        public static void Run()
        {
            var dog = new Dog("Sparky");
            var human = new Human("Thomas");
            bool isDogKnown = false;

            var values1 = new ValueTuple<Dog, Human, bool>(dog, human, isDogKnown);
            var values2 = (dog, human, isDogKnown);

            var (d, h, b) = GetDogHumanAndBool();
        }

        public static (Dog, Human, bool) GetDogHumanAndBool()
        {
            var dog = new Dog("Sparky");
            var human = new Human("Thomas");
            bool isDogKnown = false;

            return (dog, human, isDogKnown);
        }
    }
}
