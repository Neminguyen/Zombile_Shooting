using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamagedInvincibility : MonoBehaviour
{
    [SerializeField]
    private float _invivcibilityDuration;

    private InvincibilityController _invincibilityController;

    private void Awake()
    {
        _invincibilityController = GetComponent<InvincibilityController>();

    }

    public void StartInvincibility()
    {
        _invincibilityController.StarInvincibility(_invivcibilityDuration);
    }
}
