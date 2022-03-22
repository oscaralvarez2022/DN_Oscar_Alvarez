INSERT INTO cities (idCities,CitiesName) VALUES (1,'Calvillo'),(2,'Aguacalientes'),(3,'Rincon de Romos'),(4,'San Francisco'),(5,'Tepezalá');

INSERT INTO equipmenttype (idEquipmentType,EquipmentTypeName) VALUES (1,'Mancuernas'),(2,'Barras'),(3,'Discos'),(4,'Cuerdas'),(5,'Bandas elásticas');

INSERT INTO measuretype (idMeasureTypes,MeasureTypeName) VALUES (1,'Centímetro'),(2,'Milla'),(3,'Kilogramo'),(4,'Pie'),(5,'Pieza');

INSERT INTO inventory (idInventory,EquipmentType_idEquipmentType,MeasureType_idMeasureTypes,InventoryQuantity) 
VALUES (1,2,5,2),(2,1,3,2),(3,2,2,2),(4,1,5,2),(5,3,4,2);

INSERT INTO membershiptypes (idMembershipTypes,MembershipTypesName) VALUES (1,'basic'),(2,'basic plus'),(3,'premium'),(4,'premium plus'),(5,'gold');

INSERT INTO members (idMembers,MembershipTypes_idMembershipTypes,MembersName) VALUES (1,1,'daniel'),(2,1,'moises'),(3,3,'oscar'),(4,4,'juan'),(5,5,'jorge');

INSERT INTO producttypes (idProductTypes,ProductTypesName,ProductTypesCost) VALUES (1,'candy',0.50),(2,'water',1.10),(3,'protein',10.2),(4,'towel',5),(5,'gatorade',2.50);

INSERT INTO sales (idSales,ProductTypes_idProductTypes,SalesDate) VALUES (1,1,'2022-03-22'),(2,5,'2022-03-22'),(3,4,'2022-03-22'),(4,2,'2022-03-22'),(5,3,'2022-03-22');

INSERT INTO roles (idRoles,RolesName) VALUES (1,'admin'),(2,'sales'),(3,'security'),(4,'auxiliary'),(5,'trainer');

INSERT INTO users (idUsers,UsersName) VALUES (1,'david'),(2,'jonh'),(3,'maria'),(4,'pepe'),(5,'jose');

INSERT INTO usersinroles (idUsersInRoles,Roles_idRoles,Users_idUsers) VALUES (1,1,2),(2,2,3),(3,3,4),(4,4,5),(5,5,1);