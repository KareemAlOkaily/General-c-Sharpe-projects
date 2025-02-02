using UnityEngine;
namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample example = new DerivedClassExample();
            example.PerformAction();
            example.PrintInfo();
        }
    }

    public abstract class AbstractBaseClass
    {
        public abstract void PerformAction();
        public void PrintInfo()
        {
            UnityEngine.Debug.Log("This is a concrete method in the abstract base class.");
        }
    }
    public class DerivedClassExample : AbstractBaseClass
    {
        public override void PerformAction()
        {
            UnityEngine.Debug.Log("PerformAction is implemented in the derived class.");
        }
    }
}
