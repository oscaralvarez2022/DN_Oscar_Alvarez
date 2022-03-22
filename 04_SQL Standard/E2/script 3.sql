CREATE VIEW `productOnInventory` AS
SELECT i.idInventory, et.EquipmentTypeName,mt.MeasureTypeName FROM inventory i
	LEFT JOIN measuretype mt ON i.MeasureType_idMeasureTypes=mt.idMeasureTypes
    LEFT JOIN equipmenttype et ON i.EquipmentType_idEquipmentType=et.idEquipmentType
WHERE i.InventoryQuantity>0;