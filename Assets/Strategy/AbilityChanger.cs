
using UnityEngine;

namespace DesignPattern.Strategy
{
    public class AbilityChanger : MonoBehaviour
    {
        [SerializeField] private AbilityStrategy[] _abilities;
        
        [SerializeField] private Animator _animator;
        
        private void OnEnable() 
        {
            SpellsUI.OnSpellButtonPressed += SpellsUI_OnSpellButtonPressed;
        }
        
        private void OnDisable() 
        {
            SpellsUI.OnSpellButtonPressed -= SpellsUI_OnSpellButtonPressed;
        }
        
        private void SpellsUI_OnSpellButtonPressed(int index)
        {
            _abilities[index].UseAbility(transform);
            _animator.SetTrigger(1);
        }
    }
}

