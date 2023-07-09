using UnrealBuildTool;

public class GMTK_GJ_2023Target : TargetRules
{
	public GMTK_GJ_2023Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("GMTK_GJ_2023");
	}
}
