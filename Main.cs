﻿using UnityEngine;
using Verse;

namespace No_Forced_Slowdown
{
	public class Main : Mod
	{
		public Main(ModContentPack content) : base(content)
		{
			GetSettings<Settings>();
		}

		public override void DoSettingsWindowContents(Rect inRect)
		{
			base.DoSettingsWindowContents(inRect);

			Settings.DoSettingsWindowContents(inRect.LeftPart(0.75f));
		}

		public override string SettingsCategory()
		{
			return "No Forced Slowdown";
		}
	}
}
