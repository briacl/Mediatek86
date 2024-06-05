CREATE DATABASE IF NOT EXISTS `mediatek86` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `mediatek86`;
CREATE TABLE service(
   idservice INT AUTO_INCREMENT,
   nom VARCHAR(50) ,
   PRIMARY KEY(idservice)
);

CREATE TABLE motif(
   idmotif INT AUTO_INCREMENT,
   libelle VARCHAR(128) ,
   PRIMARY KEY(idmotif)
);

CREATE TABLE personnel(
   idpersonnel INT AUTO_INCREMENT,
   nom VARCHAR(50) ,
   prenom VARCHAR(50) ,
   tel VARCHAR(15) ,
   mail VARCHAR(128) ,
   idservice INT NOT NULL,
   PRIMARY KEY(idpersonnel),
   FOREIGN KEY(idservice) REFERENCES service(idservice)
);

CREATE TABLE absence(
   idpersonnel INT,
   datedebut DATETIME,
   datefin DATETIME,
   idmotif INT NOT NULL,
   PRIMARY KEY(idpersonnel, datedebut),
   FOREIGN KEY(idpersonnel) REFERENCES personnel(idpersonnel),
   FOREIGN KEY(idmotif) REFERENCES motif(idmotif)
);

CREATE TABLE responsable(
    login VARCHAR(64) NOT NULL,
    pwd VARCHAR(64)
 );

-- Insertion des données du responsable
INSERT INTO `responsable` (`login`, `pwd`) VALUES ('admin',  SHA2('admin', 256));

-- Insertion des motifs  vacances, maladie, motif familial, congé parental dans motif
INSERT INTO `motif` (`libelle`) VALUES ('vacances');
INSERT INTO `motif` (`libelle`) VALUES ('maladie');
INSERT INTO `motif` (`libelle`) VALUES ('motif familial');
INSERT INTO `motif` (`libelle`) VALUES ('congé parental');

-- Insertion des services administratif, médiation culturelle, prêt
INSERT INTO `service` (`nom`) VALUES ('administratif');
INSERT INTO `service` (`nom`) VALUES ('médiation culturelle');
INSERT INTO `service` (`nom`) VALUES ('prêt');