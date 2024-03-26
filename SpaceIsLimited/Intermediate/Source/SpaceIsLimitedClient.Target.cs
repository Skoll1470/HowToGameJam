using UnrealBuildTool;

public class SpaceIsLimitedClientTarget : TargetRules
{
	public SpaceIsLimitedClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SpaceIsLimited");
	}
}
