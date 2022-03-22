SELECT * FROM country co
INNER JOIN city ci ON co.country_id=ci.country_id
WHERE co.country_id=1;