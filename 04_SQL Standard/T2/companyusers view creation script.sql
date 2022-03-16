CREATE VIEW companyusers
AS
SELECT c.idcompany,u.iduser, u.email, c.location FROM users u
INNER JOIN company c on u.idcompany=c.idcompany
