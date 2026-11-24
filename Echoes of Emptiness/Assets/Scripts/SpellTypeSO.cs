using UnityEngine;

[CreateAssetMenu(fileName = "SpellTypeSO", menuName = "Scriptable Objects/SpellTypeSO")]
public class SpellTypeSO : ScriptableObject
{
    [SerializeField] GameObject[] spellPrefabs;
    [SerializeField] string[] elements = { "Lightning" };

    public GameObject GetAllyPrefab(int index)
    {
        return spellPrefabs[index];
    }

    public string GetAllyElement(int index)
    {
        return elements[index];
    }
}
