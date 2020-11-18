﻿using UnityEngine;


namespace BeastHunter
{
    public sealed class CharacterInitializeController : IAwake
    {
        #region Field

        GameContext _context;

        #endregion


        #region ClassLifeCycle

        public CharacterInitializeController(GameContext context)
        {
            _context = context;
        }

        #endregion


        #region IAwake

        public void OnAwake()
        {
            var locationData = Resources.Load<LocationData>("Data/LocationData");
            var spawnPoint = locationData.PlayerSpawnData.SpawnPoint;

            var characterData = Data.CharacterData;

            Vector3 groundedInstancePosition = GetGroundedPosition(spawnPoint);

            //Vector3 instantiatePosition = characterData._characterCommonSettings.InstantiatePosition;
            //Vector3 groundedInstancePosition = GetGroundedPosition(instantiatePosition);

            GameObject instance = GameObject.Instantiate(characterData._characterCommonSettings.Prefab);

            CharacterModel character = new CharacterModel(instance, characterData, groundedInstancePosition);
            _context.CharacterModel = character;
        }

        #endregion


        #region Methods

        private Vector3 GetGroundedPosition(Vector3 startPosition)
        {
            Vector3 groundedPosition = new Vector3();

            bool isGroundBelow = Services.SharedInstance.PhysicsService.FindGround(startPosition, out groundedPosition);

            if (!isGroundBelow)
            {
                throw new System.Exception("Ground is above player's position!");
            }

            return groundedPosition;
        }

        #endregion
    }
}
