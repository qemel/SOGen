using UnityEngine;

namespace Sandbox
{
    public sealed class SampleDataAccessor : MonoBehaviour
    {
        [SerializeField] SampleDatabase _sampleDatabase;

        void Start()
        {
            var dataName = _sampleDatabase.Get(1);
            Debug.Log(dataName);
        }
    }
}