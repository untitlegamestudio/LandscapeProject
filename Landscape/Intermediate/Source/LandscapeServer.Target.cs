using UnrealBuildTool;

public class LandscapeServerTarget : TargetRules
{
	public LandscapeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Landscape");
	}
}
