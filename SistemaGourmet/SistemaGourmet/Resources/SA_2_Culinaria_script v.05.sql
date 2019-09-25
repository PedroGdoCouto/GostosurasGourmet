-- MySQL Workbench Synchronization
-- Generated: 2019-05-30 13:58
-- Model: New Model
-- Version: 1.0
-- Project: Name of the project
-- Author: leonn

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

CREATE SCHEMA IF NOT EXISTS `dbCulinaria` DEFAULT CHARACTER SET utf8 ;

CREATE TABLE IF NOT EXISTS `dbCulinaria`.`receita` (
  `id` INT(8) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL DEFAULT NULL,
  `dificuldade` INT NULL DEFAULT NULL,
  `porcoes` DOUBLE NULL DEFAULT NULL,
  `tempo` INT NULL DEFAULT NULL,
  `custo` DOUBLE NULL DEFAULT NULL,
  `preparo` TEXT NULL DEFAULT NULL,
  `categoria` VARCHAR(20) NOT NULL,
  UNIQUE INDEX `nome` (`nome` ASC),
  PRIMARY KEY (`id`)
  )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `dbCulinaria`.`ingrediente` (
  `id` INT(8) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL DEFAULT NULL UNIQUE,
  `preco` DOUBLE NULL DEFAULT NULL,
  `quantidade` DOUBLE NULL DEFAULT NULL,
  `unidade` VARCHAR(5) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `dbCulinaria`.`preparo` (
  `receita_id` INT(8) NOT NULL,
  `ingrediente_id` INT(8) NOT NULL,
  `quantidade` DOUBLE NULL DEFAULT NULL,
  `unidade` VARCHAR(5) NULL DEFAULT NULL,
  `custo` DOUBLE NULL DEFAULT NULL,
  PRIMARY KEY (`receita_id`, `ingrediente_id`),
  INDEX `fk_receita_has_ingrediente_ingrediente1_idx` (`ingrediente_id` ASC),
  INDEX `fk_receita_has_ingrediente_receita_idx` (`receita_id` ASC),
  CONSTRAINT `fk_receita_has_ingrediente_receita`
    FOREIGN KEY (`receita_id`)
    REFERENCES `dbCulinaria`.`receita` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_receita_has_ingrediente_ingrediente1`
    FOREIGN KEY (`ingrediente_id`)
    REFERENCES `dbCulinaria`.`ingrediente` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

USE dbCulinaria;

INSERT INTO ingrediente (nome,preco,quantidade,unidade)
VALUES 
	('Açúcar cristal',10, 5,'kg'),
    ('Açúcar refinado',3.0, 1.0, 'kg'),
	('Leite de vaca',2.75, 1.0, 'l'),
	('Amendoim torrado descascado',	5.25, 500.0, 'g'),
	('Creme de leite', 2.10, 200.0, 'ml'),
    ('Feijão preto', 6.00, 1, 'kg'),
    ('Feijão carioquinha', 4.00, 1, 'kg'),
    ('Músculo', 15.00, 1, 'kg'),
    ('Acém', 16.00, 1, 'kg'),
    ('Costela de boi', 10.00, 2, 'kg'),
    ('Mandioca', 4.25, 2, 'kg'),    
    ('Ovos brancos', 9, 12, 'un'),    
    ('Farinha de trigo sem fermento', 2.5, 1, 'kg'),    
    ('Fubá mimoso', 3.25, 1, 'kg'),    
    ('Peito de frango', 9.98, 1, 'kg'),    
    ('Café em pó solúvel', 7, 50, 'g'),    
    ('Leite em pó', 9, 400, 'g'),    
    ('Canela em pó solúvel', 3, 100, 'g')    
    ;

#INSERT	INTO Categoria (nome) VALUES	('Carne'),	('Peixe'),	('Marisco'),	('Pastelaria'),	('Sobremesa'),	('Confeitaria'),	('Padaria'),	('Salada'),	('Bebida')	;
	
INSERT INTO receita (nome,dificuldade,porcoes,tempo,preparo,categoria,custo) VALUES
	('Cucuz à mineira',		5,	3, 	10,'xxxxxxxxxxxxxxxxxxxxxxxxxxxxx',"Confeitaria",0),
	('Vaca atolada',		6,	6, 	25,'xxxxxxxxxxxxxxxxxxxxxxxxxxxxx',"Carne",0),
	('Bolo de fubá',		5,	10,	40,'xxxxxxxxxxxxxxxxxxxxxxxxxxxxx',"Padaria",0),
	('Pastel português',	5,	6, 	50,'xxxxxxxxxxxxxxxxxxxxxxxxxxxxx',"Pastelaria",0),
	('Coxinha',				6,	6, 	60,'xxxxxxxxxxxxxxxxxxxxxxxxxxxxx',"Pastelaria",0),
	('Café capuccino',		1,	10,	85,'xxxxxxxxxxxxxxxxxxxxxxxxxxxxx',"Bebida",0)
    ;

INSERT INTO preparo VALUES
(1,14,500,"g",1.13),  
(2,10,2,"kg",10),  
(2,11,2,"kg",4.25),  
(3,13,500,"g",1.25),  
(3,14,500,"g",1.88),  
(3,12,4,"un",3.00),  
(4,13,1,"kg",2.50),  
(4,12,3,"kg",2.25),  
(4,8,500,"g",7.5),  
(5,14,500,"g",4.98),  
(5,13,1,"kg",2.50),  
(5,12,4,"un",3),
(6,16,50,"g",4),
(6,17,400,"g",8),
(6,18,50,"g",1.5)
; 
 
DESCRIBE receita;
    
SELECT * FROM ingrediente;
SELECT * FROM receita ;
SELECT * FROM preparo;

UPDATE receita SET custo =10.50 WHERE id = 6;
#UPDATE ingrediente SET nome = 'Açúcar cristal', preco =5.00 , quantidade =2000, unidade = "g"  WHERE id = 1;

# SELECT 	p.quantidade,p.unidade,p.custo,i.nome		
#	FROM  preparo as p
#	INNER JOIN  receita as r ON p.receita_id = 2 and  r.id = 2
#   INNER JOIN ingrediente as i ON p.ingrediente_id = i.id;
    
