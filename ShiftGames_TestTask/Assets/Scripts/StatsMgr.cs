using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsMgr : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField]
    Text armorStats;
    [SerializeField]
    Text strenghtStats;
    [SerializeField]
    Text agilityStat;
    [SerializeField]
    Text maxSpeedStat;
    [SerializeField]
    Text convenienceStat;

    [SerializeField]
    List<Slot> slots;

    [SerializeField]
    Character character;

    private void Awake()
    {
        slots.ForEach(_slot => _slot.ChangeItemAction = UpdateCharacterStats);
        character.UpdateStatsAction = UpdateStatsText;    
    }

    void UpdateCharacterStats(Equipment _equipment) 
    {
        character.UpdateEquipmentAction.Invoke(_equipment);
    }

    void UpdateStatsText() 
    {
        armorStats.text = character.Armor.ToString();
        strenghtStats.text = character.Strenght.ToString();
        agilityStat.text = character.Agility.ToString();
        maxSpeedStat.text = character.MaxSpeed.ToString();
        convenienceStat.text = character.Convenience.ToString();
    }
}
