using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsMgr : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField]
    private Text _armorStats;
    [SerializeField]
    private Text _strenghtStats;
    [SerializeField]
    private Text _agilityStat;
    [SerializeField]
    private Text _maxSpeedStat;
    [SerializeField]
    private Text _convenienceStat;

    [SerializeField]
    private List<Slot> _slots;

    [SerializeField]
    private Character _character;

    private void Awake()
    {
        _slots.ForEach(_slot => _slot.ChangeHeadAction = UpdateCharacterHead);
        _slots.ForEach(_slot => _slot.ChangeArmorAction = UpdateCharacterArmor);
        _slots.ForEach(_slot => _slot.ChangePantsAction = UpdateCharacterPants);
        _slots.ForEach(_slot => _slot.ChangeWeaponAction = UpdateCharacterWeapon);
        _character.UpdateStatsAction = UpdateStatsText;    
    }

    private void UpdateCharacterHead(HeadEquipment equipment) 
    {
        _character.UpdateHeadAction.Invoke(equipment);
    }

    private void UpdateCharacterArmor(ArmorEquipment equipment) 
    {
        _character.UpdateArmorAction.Invoke(equipment);
    }

    private void UpdateCharacterWeapon(WeaponEquipment equipment) 
    {
        _character.UpdateWeaponAction.Invoke(equipment);
    }

    private void UpdateCharacterPants(LegsEquipment equipment) 
    {
        _character.UpdatePantsAction.Invoke(equipment);
    }

    private void UpdateStatsText() 
    {
        _armorStats.text = _character.Armor.ToString();
        _strenghtStats.text = _character.Strenght.ToString();
        _agilityStat.text = _character.Agility.ToString();
        _maxSpeedStat.text = _character.MaxSpeed.ToString();
        _convenienceStat.text = _character.Convenience.ToString();
    }
}
