// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Blacksmithing : ModuleRules
{
	public Blacksmithing(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
