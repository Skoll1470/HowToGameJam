using UnrealBuildTool;

public class SpaceIsLimitedServerTarget : TargetRules
{
	public SpaceIsLimitedServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SpaceIsLimited");
	}
}
