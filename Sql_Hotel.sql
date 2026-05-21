create database app_db;

use app_db;

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

-- =============================================================
-- Tabela Reserva
-- Estrutura mínima criada como pré-requisito para a FK de Pagamento.
-- A implementação completa é responsabilidade do Eric.
-- =============================================================
CREATE TABLE Reserva (
    id           INT PRIMARY KEY AUTO_INCREMENT,
    hospedeId    INT NOT NULL,
    quartoId     INT NOT NULL,
    dataEntrada  DATE NOT NULL,
    dataSaida    DATE NOT NULL,
    status       VARCHAR(30) NOT NULL DEFAULT 'Confirmada',
    FOREIGN KEY (hospedeId) REFERENCES hospedes(id),
    FOREIGN KEY (quartoId)  REFERENCES Quarto(id)
);

-- =============================================================
-- Tabela Pagamento
-- Responsável: Léo
-- reservaId é nullable para funcionar antes da entidade Reserva
-- ser conectada (integração futura com o Eric).
-- =============================================================
CREATE TABLE Pagamento (
    id              INT PRIMARY KEY AUTO_INCREMENT,
    hospedeId       INT NOT NULL,
    reservaId       INT NULL,
    valorTotal      DECIMAL(10, 2) NOT NULL,
    dataPagamento   DATETIME NOT NULL,
    formaPagamento  VARCHAR(30) NOT NULL,
    status          VARCHAR(20) NOT NULL DEFAULT 'Pendente',
    observacao      VARCHAR(255) NULL,
    FOREIGN KEY (hospedeId) REFERENCES hospedes(id),
    FOREIGN KEY (reservaId) REFERENCES Reserva(id)
);

-- =============================================================
-- Inserts de Teste (Hotéis, Hóspedes, Quartos, Reservas, Pagamentos)
-- =============================================================

-- 1. Hotéis
INSERT INTO Hotel (nome, endereco, cidade, telefone, estrelas) VALUES
('Hotel Central', 'Rua São Bento, 123', 'Araraquara', '(16) 3333-0000', 4),
('Plaza Hotel', 'Av. Paulista, 1000', 'São Paulo', '(11) 3214-5555', 5),
('Pousada Beira Mar', 'Av. Beira Mar, 500', 'Santos', '(13) 3879-1122', 3);

-- 2. Hóspedes
INSERT INTO hospedes (nome, sobrenome, cpf, dataNascimento, email, telefone) VALUES
('Maria', 'Silva', '123.456.789-00', '1990-05-15', 'maria.silva@email.com', '16999991111'),
('João', 'Santos', '987.654.321-11', '1985-10-22', 'joao.santos@email.com', '11988882222'),
('Ana', 'Oliveira', '111.222.333-44', '1998-02-28', 'ana.oliveira@email.com', '13977773333'),
('Carlos', 'Souza', '555.666.777-88', '1975-07-04', 'carlos.souza@email.com', '16966664444');

-- 3. Quartos
INSERT INTO Quarto (numero, tipo, precoDiaria, status, hotelId) VALUES
(101, 'Suíte', 150.00, 'Ocupado', 1),
(102, 'Solteiro', 80.00, 'Disponível', 1),
(103, 'Duplo', 120.00, 'Disponível', 1),
(201, 'Presidencial', 500.00, 'Disponível', 2),
(202, 'Luxo', 250.00, 'Ocupado', 2),
(301, 'Standard', 90.00, 'Manutenção', 3),
(302, 'Standard', 90.00, 'Disponível', 3);

-- 4. Reservas
INSERT INTO Reserva (hospedeId, quartoId, dataEntrada, dataSaida, status) VALUES
(1, 1, '2026-06-01', '2026-06-05', 'Confirmada'),
(2, 5, '2026-06-10', '2026-06-15', 'Confirmada'),
(3, 2, '2026-05-20', '2026-05-22', 'Check-out'),
(4, 6, '2026-05-18', '2026-05-25', 'Cancelada');

-- 5. Pagamentos
INSERT INTO Pagamento (hospedeId, reservaId, valorTotal, dataPagamento, formaPagamento, status, observacao) VALUES
(1, 1, 600.00, '2026-05-20 14:30:00', 'PIX', 'Pago', 'Pagamento antecipado via PIX'),
(2, 2, 1250.00, '2026-05-21 09:00:00', 'Cartão de Crédito', 'Pendente', 'Aguardando confirmação da operadora'),
(3, 3, 160.00, '2026-05-22 12:00:00', 'Cartão de Débito', 'Pago', 'Pago no check-out'),
(4, null, 100.00, '2026-05-19 10:00:00', 'Dinheiro', 'Cancelado', 'Taxa de cancelamento reembolsada');

