CREATE DATABASE IF NOT EXISTS book_store;
USE book_store;


CREATE TABLE cities (
    city_id INT AUTO_INCREMENT PRIMARY KEY,
    city_name VARCHAR(100) NOT NULL,
    average_delivery_time_days INT NOT NULL
);


CREATE TABLE customers (
    customer_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    city_id INT NOT NULL,
    registration_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (city_id) REFERENCES cities(city_id)
);


CREATE TABLE authors (
    author_id INT AUTO_INCREMENT PRIMARY KEY,
    author_name VARCHAR(100) NOT NULL,
    bio TEXT
);


CREATE TABLE genres (
    genre_id INT AUTO_INCREMENT PRIMARY KEY,
    genre_name VARCHAR(50) NOT NULL UNIQUE,
    description TEXT
);


CREATE TABLE books (
    book_id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    author_id INT NOT NULL,
    genre_id INT NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    publication_year INT,
    FOREIGN KEY (author_id) REFERENCES authors(author_id),
    FOREIGN KEY (genre_id) REFERENCES genres(genre_id)
);


CREATE TABLE inventory (
    inventory_id INT AUTO_INCREMENT PRIMARY KEY,
    book_id INT NOT NULL,
    quantity_in_stock INT NOT NULL DEFAULT 0,
    last_restock_date DATETIME,
    FOREIGN KEY (book_id) REFERENCES books(book_id)
);


CREATE TABLE orders (
    order_id INT AUTO_INCREMENT PRIMARY KEY,
    customer_id INT NOT NULL,
    order_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    notes TEXT,
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
);


CREATE TABLE order_items (
    order_item_id INT AUTO_INCREMENT PRIMARY KEY,
    order_id INT NOT NULL,
    book_id INT NOT NULL,
    quantity INT NOT NULL,
    price_per_unit DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (order_id) REFERENCES orders(order_id),
    FOREIGN KEY (book_id) REFERENCES books(book_id)
);


CREATE TABLE order_statuses (
    status_id INT AUTO_INCREMENT PRIMARY KEY,
    status_name VARCHAR(50) NOT NULL UNIQUE,
    description TEXT
);


CREATE TABLE order_history (
    history_id INT AUTO_INCREMENT PRIMARY KEY,
    order_id INT NOT NULL,
    status_id INT NOT NULL,
    status_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (order_id) REFERENCES orders(order_id),
    FOREIGN KEY (status_id) REFERENCES order_statuses(status_id)
);


INSERT INTO cities (city_name, average_delivery_time_days) VALUES
('Москва', 2),
('Санкт-Петербург', 3),
('Новосибирск', 5),
('Екатеринбург', 4),
('Казань', 4),
('Нижний Новгород', 4),
('Челябинск', 5),
('Самара', 5),
('Омск', 6),
('Ростов-на-Дону', 5);


INSERT INTO authors (author_name, bio) VALUES
('Лев Толстой', 'Русский писатель, мыслитель, философ и публицист. Классик мировой литературы.'),
('Фёдор Достоевский', 'Русский писатель, мыслитель, философ и публицист. Классик мировой литературы.'),
('Антон Чехов', 'Русский писатель, прозаик, драматург. Классик мировой литературы.'),
('Джоан Роулинг', 'Британская писательница, сценаристка и кинопродюсер, наиболее известная как автор серии романов о Гарри Поттере.'),
('Стивен Кинг', 'Американский писатель, работающий в жанрах ужасов, триллера, фантастики, фэнтези, мистики.'),
('Джордж Оруэлл', 'Английский писатель и публицист.'),
('Рэй Брэдбери', 'Американский писатель, известный по антиутопии «451 градус по Фаренгейту».'),
('Эрнест Хемингуэй', 'Американский писатель, журналист, лауреат Нобелевской премии по литературе 1954 года.'),
('Агата Кристи', 'Английская писательница. Относится к числу самых известных в мире авторов детективной прозы.'),
('Дэн Браун', 'Американский писатель, журналист, музыкант. Автор международных бестселлеров в жанре интеллектуального детективного триллера.');


INSERT INTO genres (genre_name, description) VALUES
('Роман', 'Литературный жанр, чаще прозаический, зародившийся в Средние века у романских народов.'),
('Детектив', 'Жанр, описывающий процесс исследования загадочного происшествия с целью выяснения его обстоятельств.'),
('Фантастика', 'Жанр в литературе, кино и других видах искусства, описывающий вымышленные события и явления.'),
('Фэнтези', 'Жанр фантастической литературы, основанный на использовании мифологических и сказочных мотивов.'),
('Ужасы', 'Жанр, предназначенный устрашить, напугать, шокировать или вызвать отвращение у своих читателей или зрителей.'),
('Научная литература', 'Литература, в которой представлены научные исследования и знания.'),
('Биография', 'Описание жизни человека, сделанное другими людьми или им самим.'),
('Поэзия', 'Особый способ организации речи; словесное художественное творчество, преимущественно стихотворное.'),
('Драма', 'Один из родов литературы (наряду с лирикой, эпосом, а также лироэпикой).'),
('Приключения', 'Захватывающие происшествия, неожиданные события или стечения обстоятельств в жизни.');


INSERT INTO books (title, author_id, genre_id, price, publication_year) VALUES
('Война и мир', 1, 1, 1200.00, 1869),
('Преступление и наказание', 2, 1, 850.00, 1866),
('Гарри Поттер и философский камень', 4, 4, 950.00, 1997),
('Оно', 5, 5, 900.00, 1986),
('1984', 6, 3, 750.00, 1949),
('451 градус по Фаренгейту', 7, 3, 700.00, 1953),
('Старик и море', 8, 1, 650.00, 1952),
('Убийство в Восточном экспрессе', 9, 2, 800.00, 1934),
('Код да Винчи', 10, 2, 850.00, 2003),
('Анна Каренина', 1, 1, 950.00, 1877);


INSERT INTO inventory (book_id, quantity_in_stock, last_restock_date) VALUES
(1, 15, '2023-01-15'),
(2, 10, '2023-02-20'),
(3, 20, '2023-03-10'),
(4, 8, '2023-01-25'),
(5, 12, '2023-02-05'),
(6, 7, '2023-03-15'),
(7, 9, '2023-01-30'),
(8, 11, '2023-02-10'),
(9, 14, '2023-03-01'),
(10, 6, '2023-01-20');


INSERT INTO customers (first_name, last_name, email, city_id) VALUES
('Иван', 'Иванов', 'ivanov@example.com', 1),
('Петр', 'Петров', 'petrov@example.com', 2),
('Сергей', 'Сергеев', 'sergeev@example.com', 3),
('Анна', 'Смирнова', 'smirnova@example.com', 1),
('Елена', 'Кузнецова', 'kuznetsova@example.com', 4),
('Дмитрий', 'Попов', 'popov@example.com', 5),
('Ольга', 'Васильева', 'vasileva@example.com', 2),
('Алексей', 'Соколов', 'sokolov@example.com', 6),
('Мария', 'Михайлова', 'mikhailova@example.com', 7),
('Андрей', 'Новиков', 'novikov@example.com', 8);


INSERT INTO order_statuses (status_name, description) VALUES
('Создан', 'Заказ создан, но еще не оплачен'),
('Оплачен', 'Заказ оплачен покупателем'),
('Упакован', 'Заказ упакован и готов к отправке'),
('Передан курьеру', 'Заказ передан в службу доставки'),
('В пути', 'Заказ находится в процессе доставки'),
('Доставлен', 'Заказ успешно доставлен покупателю'),
('Отменен', 'Заказ отменен');


INSERT INTO orders (customer_id, notes) VALUES
(1, 'Пожалуйста, упакуйте в подарочную упаковку'),
(2, 'Доставить до 18:00'),
(3, NULL),
(4, 'Книги в мягкой обложке не подходят, нужны только твердые переплеты'),
(5, NULL),
(6, 'Позвонить за час до доставки'),
(7, NULL),
(8, 'Оставить у консьержа'),
(9, 'Доставить в офис'),
(10, NULL);


INSERT INTO order_items (order_id, book_id, quantity, price_per_unit) VALUES
(1, 1, 1, 1200.00),
(1, 3, 2, 950.00),
(2, 5, 1, 750.00),
(3, 7, 1, 650.00),
(3, 9, 1, 850.00),
(4, 2, 1, 850.00),
(5, 4, 1, 900.00),
(6, 6, 1, 700.00),
(7, 8, 1, 800.00),
(8, 10, 1, 950.00),
(9, 1, 1, 1200.00),
(9, 2, 1, 850.00),
(10, 3, 1, 950.00);


INSERT INTO order_history (order_id, status_id, status_date) VALUES
(1, 1, '2023-04-01 10:00:00'),
(1, 2, '2023-04-01 10:30:00'),
(1, 3, '2023-04-01 12:00:00'),
(1, 4, '2023-04-01 15:00:00'),
(1, 5, '2023-04-01 16:00:00'),
(1, 6, '2023-04-03 14:00:00'),
(2, 1, '2023-04-02 11:00:00'),
(2, 2, '2023-04-02 11:45:00'),
(2, 3, '2023-04-02 13:30:00'),
(2, 4, '2023-04-02 16:00:00'),
(3, 1, '2023-04-03 09:00:00'),
(4, 1, '2023-04-03 14:00:00'),
(5, 1, '2023-04-04 10:00:00'),
(6, 1, '2023-04-04 15:00:00'),
(7, 1, '2023-04-05 11:00:00'),
(8, 1, '2023-04-05 16:00:00'),
(9, 1, '2023-04-06 10:00:00'),
(10, 1, '2023-04-06 14:00:00');