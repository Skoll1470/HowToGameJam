using UnrealBuildTool;

public class SpaceIsLimitedTarget : TargetRules
{
	public SpaceIsLimitedTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SpaceIsLimited");
	}
}
