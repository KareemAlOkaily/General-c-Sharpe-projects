using System;
using UnityEngine;
namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        void Start()
        {
            // Action
            Action logMessage = () => Debug.Log("Hello from Action delegate!");
            logMessage();

            // Func
            Func<int, int> square = x => x * x;
            Debug.Log($"Square: {square(5)}");

            // Predicate
            Predicate<int> isEven = x => x % 2 == 0;
            Debug.Log($"Is 4 even? {isEven(4)}");
        }
    }
}