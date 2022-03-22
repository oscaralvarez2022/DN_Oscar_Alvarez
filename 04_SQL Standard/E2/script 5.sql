SELECT m.MembersName, m.MembersDateRegistrer, mst.MembershipTypesName FROM members m
LEFT JOIN membershiptypes mst ON mst.idMembershipTypes=m.MembershipTypes_idMembershipTypes
ORDER BY MembersDateRegistrer DESC 
LIMIT 1