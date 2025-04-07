using SOGen;
using UnityEngine;

// ReSharper disable inconsistentNaming

namespace Sandbox
{
    [DatabaseOf(typeof(int), typeof(string))]
    [CreateAssetMenu(fileName = nameof(SampleDatabase), menuName = "SOGen/" + nameof(SampleDatabase))]
    public partial class SampleDatabase : ScriptableObject
    {
    }
}