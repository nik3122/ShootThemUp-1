// Shoot Them Up Game , All Rights Reserved.


#include "UI/STUSpectatorWidget.h"
#include "STUUtiles.h"
#include "Components/STURespawnComponent.h"

bool USTUSpectatorWidget::GetRespawnTime(int32& CountDownTime)
{
	const auto RespawnComponent = STUUtiles::GetSTUPlayerComponent<USTURespawnComponent>(GetOwningPlayer());
	if(!RespawnComponent || !RespawnComponent->IsRespawnInProgress()) return false;

	CountDownTime = RespawnComponent->GetRespawnCountDown();
	return true;
}
