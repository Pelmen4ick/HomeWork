SELECT * FROM trip 
WHERE name LIKE '%а %' OR name LIKE '%а.';


SELECT DISTINCT name 
FROM trip 
WHERE city = 'Москва' 
ORDER BY name;


SELECT city, COUNT(*) AS trip_count 
FROM trip 
GROUP BY city 
ORDER BY trip_count DESC;


SELECT city, COUNT(*) AS trip_count 
FROM trip 
GROUP BY city 
ORDER BY trip_count DESC 
LIMIT 2;


SELECT *, DATEDIFF(date_last, date_first) + 1 AS duration_days 
FROM trip;

SELECT *, DATEDIFF(date_last, date_first) + 1 AS duration_days 
FROM trip 
WHERE DATEDIFF(date_last, date_first) + 1 = (
    SELECT MIN(DATEDIFF(date_last, date_first) + 1) 
    FROM trip
);


SELECT * 
FROM trip 
WHERE MONTH(date_first) = MONTH(date_last) 
AND YEAR(date_first) = YEAR(date_last);

SELECT MONTH(date_first) AS month_number, COUNT(*) AS trip_count 
FROM trip 
GROUP BY month_number 
ORDER BY month_number;

SELECT name, SUM(per_diem * (DATEDIFF(date_last, date_first) + 1)) AS total_per_diem 
FROM trip 
GROUP BY name;

SELECT name, SUM(per_diem * (DATEDIFF(date_last, date_first) + 1)) AS total_per_diem 
FROM trip 
GROUP BY name 
HAVING COUNT(*) > 3;