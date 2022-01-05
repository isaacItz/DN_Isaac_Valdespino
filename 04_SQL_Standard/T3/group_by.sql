select c.name, sub.total_films, f.rating from 
film f join film_category fc on fc.film_id = f.film_id join 
category c on c.category_id = fc.category_id join 
( select count(*) total_films, rating from film group by rating having total_films > 200 ) sub on sub.rating = f.rating
group by c.name, sub.total_films, f.rating 
order by sub.total_films;
