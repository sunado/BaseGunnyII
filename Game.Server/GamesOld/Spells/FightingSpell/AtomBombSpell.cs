﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Server.Spells;
using Game.Server.GameObjects;
using Game.Base.Packets;
using SqlDataProvider.Data;
using Game.Server.Managers;
using Phy.Object;
using Game.Server.Games;

namespace Game.Server.Spells.FightingSpell
{
    [SpellAttibute((int)eSpellType.ABOMB)]
    public class ABombSpell : ISpellHandler
    {
        public void Execute(BaseGame game, Player player, ItemTemplateInfo item)
        {
            player.SetBall(4);
        }

    }
}
