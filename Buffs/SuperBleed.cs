using Terraria;
using Terraria.ModLoader;
using Fargowiltas.NPCs;
using Fargowiltas;

namespace Fargowiltas.Buffs
{
	public class SuperBleed : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Super Bleed");
			Main.buffNoSave[Type] = true;

		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.GetGlobalNPC<FargoGlobalNPC>(mod).sBleed = true;
		}
	}
}