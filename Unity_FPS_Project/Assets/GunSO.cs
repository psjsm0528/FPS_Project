using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="GUN", menuName ="SO/Gun", order = 100)]
public class GunSO : ScriptableObject
{
    [field:SerializeField] public float coolTime { get; private set; }
    [field:SerializeField] public float speed { get; private set; }
}
