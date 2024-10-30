using UnrealBuildTool;

public class LandscapeClientTarget : TargetRules
{
	public LandscapeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Landscape");
	}
}
