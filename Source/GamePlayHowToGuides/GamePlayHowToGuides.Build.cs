// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GamePlayHowToGuides : ModuleRules
{
	public GamePlayHowToGuides(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
