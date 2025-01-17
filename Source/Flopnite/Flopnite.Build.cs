// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Flopnite : ModuleRules
{
	public Flopnite(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "ALSV4_CPP" });
	}
}
