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
        slots.ForEach(_slot => _slot.ChangeHeadAction = UpdateCharacterHead);
        slots.ForEach(_slot => _slot.ChangeArmorAction = UpdateCharacterArmor);
        slots.ForEach(_slot => _slot.ChangePantsAction = UpdateCharacterPants);
        slots.ForEach(_slot => _slot.ChangeWeaponAction = UpdateCharacterWeapon);
        character.UpdateStatsAction = UpdateStatsText;    
    }

    void UpdateCharacterHead(HeadEquipment _equipment) 
    {
        character.UpdateHeadAction.Invoke(_equipment);
    }

    void UpdateCharacterArmor(ArmorEquipment _equipment) 
    {
        character.UpdateArmorAction.Invoke(_equipment);
    }

    void UpdateCharacterWeapon(WeaponEquipment _equipment) 
    {
        character.UpdateWeaponAction.Invoke(_equipment);
    }

    void UpdateCharacterPants(LegsEquipment _equipment) 
    {
        character.UpdatePantsAction.Invoke(_equipment);
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
