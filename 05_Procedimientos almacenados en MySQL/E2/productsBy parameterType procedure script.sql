CREATE DEFINER=`root`@`localhost` PROCEDURE `inventary`(in _equipmentTypeId int)
BEGIN
	select EquipmentTypeName, sum(InventoryQuantity) stock from inventory i 
	left join equipmenttype et on et.idEquipmentType=i.EquipmentType_idEquipmentType
    where et.idEquipmentType=_equipmentTypeId;
END