SELECT count(*) total_films, rating FROM film f
group by rating;

SELECT rating FROM film f
group by rating;

SELECT title, count(*) total_films FROM film f
group by rating;