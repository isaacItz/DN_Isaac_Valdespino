select 'Mayor Cantidad' query_type, a.actor_id, max_films, a.first_name, a.last_name 
from 
(select count(*) total_films, actor_id from film_actor fa group by actor_id ) as sub 
join 
( select max(total_films) max_films 
    from 
    ( select count(*) total_films, actor_id 
        from film_actor fa group by fa.actor_id ) sub ) sub_max on sub_max.max_films = sub.total_films 
join actor a on a.actor_id = sub.actor_id  
union 
select 'Menor Cantidad' query_type, a.actor_id, max_films, a.first_name, a.last_name 
from (select count(*) total_films, actor_id 
    from film_actor fa group by actor_id ) as sub 
join ( select min(total_films) max_films 
    from ( select count(*) total_films, actor_id 
        from film_actor fa group by fa.actor_id ) sub ) sub_max on sub_max.max_films = sub.total_films 
join actor a 
on a.actor_id = sub.actor_id;

