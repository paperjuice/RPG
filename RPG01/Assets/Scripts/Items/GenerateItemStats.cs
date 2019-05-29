using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateItemStats : MonoBehaviour
{
    // Start is called before the first frame update
    Dictionary<Stats, int> itemStats = new Dictionary<Stats, int>();

    private void Awake() {
        itemStats = GenerateStats();
    }

    private void Start() {
    }

    Dictionary<Stats, int> GenerateStats() {
        Dictionary<Stats, int> dictionary = new Dictionary<Stats, int>();

        dictionary.Add(Stats.HEALTH, 3);
        dictionary.Add(Stats.MIN_DAMAGE, 1);
        dictionary.Add(Stats.MAX_DAMAGE, 3);

        return dictionary;
    }

    public void Mergi() {
        Debug.Log("kdsjflksd");
    }
}
