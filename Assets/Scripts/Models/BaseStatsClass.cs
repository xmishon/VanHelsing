﻿using System;
using UnityEngine;


namespace BeastHunter
{
    [Serializable]
    public class BaseStatsClass
    {
        #region Fields

        [SerializeField, Tooltip("Maximum Hp value")]
        private float _maxHealth;
        [SerializeField] private EnemyType _enemyType;
        //_enemySubtype

        [SerializeField] private float _viewRadius;
        [SerializeField, Tooltip("Angle from center. Max 180."), Range(0.0f, 180.0f)]
        private float _viewAngle;
        //_moveSpeed
        //_jumpHeight
        //etc.

        //OBSOLETE
        [Header("Basic stats(obsolete)")]

        [Tooltip("Health points")]
        [Range(0.0f, 1000.0f)]
        [SerializeField] private float _healthPoints;

        [Tooltip("Physical power between 0 and 10.")]
        [Range(0.0f, 10.0f)]
        [SerializeField] private float _physicalPower;

        [Tooltip("Physical damage resistance between 0 and 1.")]
        [Range(0.0f, 1.0f)]
        [SerializeField] private float _physicalDamageResistance;

        [Tooltip("Stun resistance between 0 and 1.")]
        [Range(0.0f, 1.0f)]
        [SerializeField] private float _stunProbabilityResistance;
        //OBSOLETE

        #endregion


        #region Properties

        public float HealthPoints => _healthPoints;
        public float MaxHealth => _maxHealth;
        public EnemyType EnemyType => _enemyType;
        public float ViewRadius => _viewRadius;
        public float ViewAngle => _viewAngle;

        //OBSOLETE
        public float PhysicalPower => _physicalPower;
        public float PhysicalResistance => _physicalDamageResistance;
        public float StunResistance => _stunProbabilityResistance;
        //OBSOLETE

        #endregion
    }
}