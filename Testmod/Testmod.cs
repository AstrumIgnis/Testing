using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Testmod.Items;
using Terraria;

namespace Testmod
{
	public class Testmod : Mod
	{
		public Testmod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true


			};
		}
	}
}