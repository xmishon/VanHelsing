﻿namespace BeastHunterHubUI
{
    public class WeaponItemModel : BaseItemModel
    {
        #region Properties

        public bool IsTwoHanded { get; private set; }

        #endregion


        #region ClassLifeCycle

        public WeaponItemModel(WeaponItemData data) : base(data)
        {
            IsTwoHanded = data.IsTwoHanded;
        }

        #endregion
    }
}