using UnityEngine;

[CreateAssetMenu(fileName = "AllySO", menuName = "Scriptable Objects/AllySO")]
public class AllySO : ScriptableObject
{
    [SerializeField] GameObject[] allyPrefabs;
    [SerializeField] string[] elements = {"Lightning"};

    public GameObject GetAllyPrefab(int index)
    {
        return allyPrefabs[index];
    }

    public string GetAllyElement(int index)
    {
        return elements[index];
    }
}
