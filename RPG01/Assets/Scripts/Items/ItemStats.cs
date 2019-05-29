using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Stats {
    HEALTH,
    MIN_DAMAGE,
    MAX_DAMAGE,
    TOTAL
}

public class ItemStats : MonoBehaviour {

    float health;
    float min_damage;
    float max_damage;

    public float Health{ get; set; }
    public float MinDamage{ get; set; }
    public float MaxDamage{ get; set; }
}
