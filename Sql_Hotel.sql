create database hotel;

use Hotel;

CREATE TABLE Hotel (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    endereco VARCHAR(200) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    estrelas INT
);

CREATE TABLE hospedes (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL,
    sobrenome VARCHAR(30) NOT NULL,
    cpf VARCHAR(14) UNIQUE NOT NULL,
    dataNascimento DATE NOT NULL,
    email VARCHAR(50) NOT NULL,
    telefone VARCHAR(11) NOT NULL
);

create table Quarto (
	id int primary key auto_increment,
    numero int not null,
    tipo Varchar(30) not null,
    precoDiaria decimal (10,2) not null,
    status varchar(30) not null,
    hotelId int not null,
    FOREIGN KEY (hotelId) REFERENCES Hotel(id)
);

INSERT INTO Hotel (nome, endereco, cidade, telefone, estrelas) 
VALUES ('Hotel Central', 'Rua São Bento, 123', 'Araraquara', '(16) 3333-0000', 4);

Insert into Quarto (numero, tipo, precoDiaria, status, hotelId)
Values (101, 'Suíte', 50.00, 'Ocupado',1); 