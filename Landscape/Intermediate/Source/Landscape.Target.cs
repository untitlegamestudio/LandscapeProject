using UnrealBuildTool;

public class LandscapeTarget : TargetRules
{
	public LandscapeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Landscape");
	}
}
