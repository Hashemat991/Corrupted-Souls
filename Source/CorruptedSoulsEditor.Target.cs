// Saved copyright for Hashem Atrash

using UnrealBuildTool;
using System.Collections.Generic;

public class CorruptedSoulsEditorTarget : TargetRules
{
	public CorruptedSoulsEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "CorruptedSouls" } );
	}
}
