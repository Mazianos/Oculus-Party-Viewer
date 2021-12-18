﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Party
    {
        private const int MAX_PARTY_SIZE = 5;

        public List<Player_Character> Members { get; private set; }

        public List<float> AverageSaves { get; private set; }

        public int Level { get; private set; }

        public int AverageArmorClass { get; private set; }

        public int AverageToHit { get; private set; }

        public int AverageHP { get; private set; }

        public float HealingPerRound { get; private set; }

        public int BaseHitPoints { get; private set; }

        public float EffectiveHitPoints { get; private set; }

        public Party()
        {
            Members = new List<Player_Character>(MAX_PARTY_SIZE);
            for (int i = 0; i < MAX_PARTY_SIZE; i++)
            {
                Members[i] = new Player_Character();
            }
            Update();
        }

        public float DPR(Creature enemy)
        {
            float total = 0;
            foreach (Player_Character player in Members) {
                total += player.DPR(enemy);
            }
            return total;
        }

        public float DPR()
        {
            float total = 0;
            foreach (Player_Character player in Members)
            {
                total += player.DPR();
            }
            return total;
        }

        public void Update()
        {
            float total = 0;
            for (int i = 0; i < 6; i++)
            {
                foreach (Player_Character player in Members)
                {
                    total += player.Saves[i];
                }
                AverageSaves[i] = total / Members.Count;
            }

            Level = Members[0].Level;

            total = 0;
            foreach (Player_Character player in Members)
            {
                total += player.ArmorClass;
            }
            AverageArmorClass = (int)(total / Members.Count);

            total = 0;
            foreach (Player_Character player in Members)
            {
                total += player.ToHit;
            }
            AverageToHit = (int)(total / Members.Count);

            total = 0;
            foreach (Player_Character player in Members)
            {
                total += player.BaseHitPoints;
            }
            AverageHP = (int)(total / Members.Count);

            total = 0;
            foreach (Player_Character player in Members)
            {
                total += player.AverageHealing;
            }
            HealingPerRound = total;

            total = 0;
            foreach (Player_Character player in Members)
            {
                total += player.BaseHitPoints;
            }
            BaseHitPoints = (int)total;

            total = 0;
            foreach (Player_Character player in Members)
            {
                total += player.Avoidance * AverageHP;
            }
            EffectiveHitPoints = BaseHitPoints + HealingPerRound - total;
        }
    }
}