
CREATE TABLE fine (
    fine_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(30) NOT NULL,
    number_plate VARCHAR(6) NOT NULL,
    violation VARCHAR(50) NOT NULL,
    sum_fine DECIMAL(8,2),
    date_violation DATE NOT NULL,
    date_payment DATE
);


INSERT INTO fine (name, number_plate, violation, sum_fine, date_violation, date_payment)
VALUES 
    ('Баранов П.Е.', 'Р523ВТ', 'Превышение скорости (от 40 до 60)', 500.00, '2020-01-12', '2020-01-17'),
    ('Абрамова К.А.', 'О111АВ', 'Проезд на запрещающий сигнал', 1000.00, '2020-01-14', '2020-02-27'),
    ('Яковлев Г.Р.', 'Т330ТТ', 'Превышение скорости (от 20 до 40)', 500.00, '2020-01-23', '2020-02-23'),
    ('Яковлев Г.Р.', 'М701АА', 'Превышение скорости (от 20 до 40)', NULL, '2020-01-12', NULL),
    ('Колесов С.П.', 'К892АХ', 'Превышение скорости (от 20 до 40)', NULL, '2020-02-01', NULL),
    ('Баранов П.Е.', 'Р523ВТ', 'Превышение скорости (от 40 до 60)', NULL, '2020-02-14', NULL),
    ('Абрамова К.А.', 'О111АВ', 'Проезд на запрещающий сигнал', NULL, '2020-02-23', NULL),
    ('Яковлев Г.Р.', 'Т330ТТ', 'Проезд на запрещающий сигнал', NULL, '2020-03-03', NULL);


CREATE TABLE traffic_violation (
    violation_id INT PRIMARY KEY AUTO_INCREMENT,
    violation VARCHAR(50) NOT NULL,
    sum_fine DECIMAL(8,2) NOT NULL
);


INSERT INTO traffic_violation (violation, sum_fine)
VALUES 
    ('Превышение скорости (от 20 до 40)', 500.00),
    ('Превышение скорости (от 40 до 60)', 1000.00),
    ('Проезд на запрещающий сигнал', 1000.00);


JOIN traffic_violation tv ON f.violation = tv.violation
SET f.sum_fine = tv.sum_fine
WHERE f.sum_fine IS NULL;


UPDATE fine f
JOIN (
    SELECT name, number_plate, violation, COUNT(*) as count
    FROM fine
    GROUP BY name, number_plate, violation
    HAVING count > 1
) as repeated ON f.name = repeated.name AND f.number_plate = repeated.number_plate AND f.violation = repeated.violation
SET f.sum_fine = f.sum_fine * 2;


UPDATE fine
SET sum_fine = sum_fine / 2
WHERE date_payment IS NOT NULL AND DATEDIFF(date_payment, date_violation) <= 20;


CREATE TABLE unpaid_fines AS
SELECT * FROM fine
WHERE date_payment IS NULL;


DELETE FROM fine
WHERE date_violation < '2020-02-01';