// Shoot Them Up Game , All Rights Reserved.


#include "AI/Services/STUChangeWeaponService.h"
#include "AIController.h"
#include "STUUtiles.h"
#include "STUWeaponComponent.h"

class USTUWeaponComponent;

USTUChangeWeaponService::USTUChangeWeaponService()
{
	NodeName = "ChangeWeapon";
}

void USTUChangeWeaponService::TickNode(UBehaviorTreeComponent& OwnerComp, uint8* NodeMemory, float DeltaSeconds)
{

	const auto Controller = OwnerComp.GetAIOwner();
	
	if(Controller)
	{
		const auto WeaponComponent = STUUtiles::GetSTUPlayerComponent<USTUWeaponComponent>(Controller->GetPawn());
		if(WeaponComponent && Probability > 0  &&FMath::FRand() <= Probability)
		{
				WeaponComponent->NextWeapon();
		}
	}

	Super::TickNode(OwnerComp, NodeMemory, DeltaSeconds);
}
