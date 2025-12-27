// Saved copyright for Hashem Atrash

using UnrealBuildTool;
using System.Collections.Generic;

public class CorruptedSoulsTarget : TargetRules
{
	public CorruptedSoulsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "CorruptedSouls" } );
	}
}
