if(!$QuickTools::AddedBinds)
{
	$remapDivision[$remapCount] = "Quick Tools";

	$remapName[$remapCount] = "Equip Wand";
	$remapCmd[$remapCount] = "equipWand";
	$remapCount++;

	$remapName[$remapCount] = "Equip Fill Can";
	$remapCmd[$remapCount] = "equipFillCan";
	$remapCount++;

	$remapName[$remapCount] = "Equip Duplicator";
	$remapCmd[$remapCount] = "equipDuplicator";
	$remapCount++;

	$QuickTools::AddedBinds = true;
}

function equipWand(%bool)
{
	if(!%bool)
		return;

	if($iamadmin)
		commandtoserver('magicwand');
	else
		commandtoserver('wand');
}

function equipFillCan(%bool)
{
	if(!%bool)
		return;

	commandtoserver('fillcan');
}

function equipDuplicator(%bool)
{
	if(!%bool)
		return;

	commandtoserver('duplicator');
}

