USE master;


CREATE TABLE library(
	id INT NOT NULL IDENTITY PRIMARY KEY,
	title VARCHAR(100),
	author VARCHAR(100),
	published_date datetime
);

INSERT INTO library (title, author, published_date) VALUES ('The Great Gatsby','F. Scott Fitzgerald','1925-04-10');
INSERT INTO library (title, author, published_date) VALUES ('The Fault in Our Stars','John Green','2012-01-10');
INSERT INTO library (title, author, published_date) VALUES ('The Catcher in the Rye','J. D. Salinger','1951-07-16');


SELECT * FROM library;