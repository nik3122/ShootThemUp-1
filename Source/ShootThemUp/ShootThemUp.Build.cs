// Shoot Them Up Game , All Rights Reserved.

using UnrealBuildTool;
using System;

public class ShootThemUp : ModuleRules
{
	public ShootThemUp(ReadOnlyTargetRules Target) : base(Target)
	{
	    Console.WriteLine("STU module rules ---------->");
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"Niagara",
			"PhysicsCore",
			"GameplayTasks",
			"NavigationSystem"
		});

		PublicIncludePaths.AddRange(new string[]
		{
			"ShootThemUp/Public/Player",
			"ShootThemUp/Public/Components", 
			"ShootThemUp/Public/Dev",
			"ShootThemUp/Public/Weapon",
			"ShootThemUp/Public/UI",
			"ShootThemUp/Public/Animations",
			"ShootThemUp/Public/Pickups",
			"ShootThemUp/Public/Weapon/Components",
			"ShootThemUp/Public/AI",
			"ShootThemUp/Public/AI/Tasks",
			"ShootThemUp/Public/AI/Services",
			"ShootThemUp/Public/AI/EQS",
			"ShootThemUp/Public/AI/Decorators"
			
		});
		
		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
