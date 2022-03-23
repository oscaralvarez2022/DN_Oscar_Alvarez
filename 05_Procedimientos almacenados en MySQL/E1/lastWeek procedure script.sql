CREATE DEFINER=`root`@`localhost` PROCEDURE `memberLastWeek`()
BEGIN
 select idMembers, MembersDateRegistrer,MembershipTypesName, membersName from members 
 left join membershiptypes on membershiptypes.idMembershipTypes=members.MembershipTypes_idMembershipTypes
 WHERE YEARWEEK(MembersDateRegistrer,1) = YEARWEEK(CURDATE(),1);
END