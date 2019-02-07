﻿using System;
using System.Collections.Generic;
using Intersect.Migration.UpgradeInstructions.Upgrade_8.Intersect_Convert_Lib.GameObjects.Conditions;

namespace Intersect.Migration.UpgradeInstructions.Upgrade_8.Intersect_Convert_Lib.GameObjects
{
    public class ResourceBase : DatabaseObject<ResourceBase>
    {
        public int Animation;

        // Drops
        public List<ResourceDrop> Drops = new List<ResourceDrop>();

        public string EndGraphic = "None";

        public ConditionLists HarvestingReqs = new ConditionLists();

        // Graphics
        public string InitialGraphic = "None";

        public int MaxHp;

        public int MinHp;
        public int SpawnDuration;
        public int Tool = -1;
        public bool WalkableAfter;
        public bool WalkableBefore;

        public ResourceBase(int id) : base(id)
        {
            Name = "New Resource";
            for (int i = 0; i < Options.MaxNpcDrops; i++)
            {
                Drops.Add(new ResourceDrop());
            }
        }

        public override byte[] BinaryData => ResourceData();

        public override void Load(byte[] packet)
        {
            var myBuffer = new Upgrade_10.Intersect_Convert_Lib.ByteBuffer();
            myBuffer.WriteBytes(packet);
            Name = myBuffer.ReadString();
            InitialGraphic = myBuffer.ReadString();
            EndGraphic = myBuffer.ReadString();
            MinHp = myBuffer.ReadInteger();
            MaxHp = myBuffer.ReadInteger();
            Tool = myBuffer.ReadInteger();
            SpawnDuration = myBuffer.ReadInteger();
            Animation = myBuffer.ReadInteger();
            WalkableBefore = Convert.ToBoolean(myBuffer.ReadInteger());
            WalkableAfter = Convert.ToBoolean(myBuffer.ReadInteger());

            for (int i = 0; i < Options.MaxNpcDrops; i++)
            {
                Drops[i].ItemNum = myBuffer.ReadInteger();
                Drops[i].Amount = myBuffer.ReadInteger();
                Drops[i].Chance = myBuffer.ReadInteger();
            }

            HarvestingReqs.Load(myBuffer);

            myBuffer.Dispose();
        }

        public byte[] ResourceData()
        {
            var myBuffer = new Upgrade_10.Intersect_Convert_Lib.ByteBuffer();
            myBuffer.WriteString(Name);
            myBuffer.WriteString(InitialGraphic);
            myBuffer.WriteString(EndGraphic);
            myBuffer.WriteInteger(MinHp);
            myBuffer.WriteInteger(MaxHp);
            myBuffer.WriteInteger(Tool);
            myBuffer.WriteInteger(SpawnDuration);
            myBuffer.WriteInteger(Animation);
            myBuffer.WriteInteger(Convert.ToInt32(WalkableBefore));
            myBuffer.WriteInteger(Convert.ToInt32(WalkableAfter));

            for (int i = 0; i < Options.MaxNpcDrops; i++)
            {
                myBuffer.WriteInteger(Drops[i].ItemNum);
                myBuffer.WriteInteger(Drops[i].Amount);
                myBuffer.WriteInteger(Drops[i].Chance);
            }

            HarvestingReqs.Save(myBuffer);

            return myBuffer.ToArray();
        }

        public class ResourceDrop
        {
            public int Amount;
            public int Chance;
            public int ItemNum;
        }
    }
}