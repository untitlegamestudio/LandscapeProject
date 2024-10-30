using UnrealBuildTool;

public class LandscapeEditorTarget : TargetRules
{
	public LandscapeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Landscape");
	}
}
