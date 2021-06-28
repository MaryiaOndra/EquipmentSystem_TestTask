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
    [SerializeField]
    BaseCharacterStats  baseCharacterStats;

    private void Awake()
    {
        slots.ForEach(_slot => _slot.ChangeItemAction = UpdateCharacterStats);

        character.UpdateStatsAction = UpdateStatsText;       
    }

    void UpdateCharacterStats(Equipment _equipment) 
    {
        Debug.Log("UpdateCharacterStats  "+ _equipment.EquipmentName);
        character.UpdateEquipmentAction.Invoke(_equipment);
        character.UpdateStatsAction.Invoke();
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
