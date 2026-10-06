// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Laboratorio_proyecto : ModuleRules
{
	public Laboratorio_proyecto(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Laboratorio_proyecto",
			"Laboratorio_proyecto/Variant_Platforming",
			"Laboratorio_proyecto/Variant_Platforming/Animation",
			"Laboratorio_proyecto/Variant_Combat",
			"Laboratorio_proyecto/Variant_Combat/AI",
			"Laboratorio_proyecto/Variant_Combat/Animation",
			"Laboratorio_proyecto/Variant_Combat/Gameplay",
			"Laboratorio_proyecto/Variant_Combat/Interfaces",
			"Laboratorio_proyecto/Variant_Combat/UI",
			"Laboratorio_proyecto/Variant_SideScrolling",
			"Laboratorio_proyecto/Variant_SideScrolling/AI",
			"Laboratorio_proyecto/Variant_SideScrolling/Gameplay",
			"Laboratorio_proyecto/Variant_SideScrolling/Interfaces",
			"Laboratorio_proyecto/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
