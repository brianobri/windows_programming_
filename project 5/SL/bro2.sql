CREATE TABLE users
(
username varchar(255) NOT NULL,
pwd varchar(255) NOT NULL,
role varchar(255) NOT NULL,
PRIMARY KEY(username)
);


INSERT INTO users
VALUES ("xiao","uawp", "friend");

INSERT INTO users
VALUES ("parent","uawp", "family");