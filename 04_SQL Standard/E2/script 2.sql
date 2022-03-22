CREATE VIEW `usersRole` AS
SELECT u.idUsers, u.UsersName, r.RolesName FROM users u 
	LEFT JOIN usersinroles ur ON u.idUsers=ur.Users_idUsers
    LEFT JOIN roles r ON ur.Roles_idRoles=r.idRoles;