// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HorrorCPP : ModuleRules
{
	public HorrorCPP(ReadOnlyTargetRules Target) : base(Target)
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
			"HorrorCPP",
			"HorrorCPP/Variant_Horror",
			"HorrorCPP/Variant_Horror/UI",
			"HorrorCPP/Variant_Shooter",
			"HorrorCPP/Variant_Shooter/AI",
			"HorrorCPP/Variant_Shooter/UI",
			"HorrorCPP/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
