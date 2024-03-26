using UnrealBuildTool;

public class SpaceIsLimitedEditorTarget : TargetRules
{
	public SpaceIsLimitedEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SpaceIsLimited");
	}
}
