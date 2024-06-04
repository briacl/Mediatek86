-- MariaDB dump 10.19-11.3.2-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: mediatek86
-- ------------------------------------------------------
-- Server version	11.3.2-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `absence`
--

DROP TABLE IF EXISTS `absence`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `absence` (
  `idpersonnel` int(11) NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int(11) NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `absence`
--

LOCK TABLES `absence` WRITE;
/*!40000 ALTER TABLE `absence` DISABLE KEYS */;
INSERT INTO `absence` VALUES
(1,'2022-01-01 00:00:00','2022-01-10 00:00:00',1),
(2,'2022-02-01 00:00:00','2022-02-10 00:00:00',2),
(3,'2022-03-01 00:00:00','2022-03-10 00:00:00',3),
(4,'2022-04-01 00:00:00','2022-04-10 00:00:00',4),
(5,'2022-05-01 00:00:00','2022-05-10 00:00:00',1),
(6,'2022-06-01 00:00:00','2022-06-10 00:00:00',2),
(7,'2022-07-01 00:00:00','2022-07-10 00:00:00',3),
(8,'2022-08-01 00:00:00','2022-08-10 00:00:00',4),
(9,'2022-09-01 00:00:00','2022-09-10 00:00:00',1),
(10,'2022-10-01 00:00:00','2022-10-10 00:00:00',2),
(11,'2022-11-01 00:00:00','2022-11-10 00:00:00',3),
(12,'2022-12-01 00:00:00','2022-12-10 00:00:00',4),
(13,'2023-01-01 00:00:00','2023-01-10 00:00:00',1),
(14,'2023-02-01 00:00:00','2023-02-10 00:00:00',2),
(1,'2023-03-01 00:00:00','2023-03-10 00:00:00',3),
(2,'2023-04-01 00:00:00','2023-04-10 00:00:00',4),
(3,'2023-05-01 00:00:00','2023-05-10 00:00:00',1),
(4,'2023-06-01 00:00:00','2023-06-10 00:00:00',2),
(5,'2023-07-01 00:00:00','2023-07-10 00:00:00',3),
(6,'2023-08-01 00:00:00','2023-08-10 00:00:00',4),
(7,'2023-09-01 00:00:00','2023-09-10 00:00:00',1),
(8,'2023-10-01 00:00:00','2023-10-10 00:00:00',2),
(9,'2023-11-01 00:00:00','2023-11-10 00:00:00',3),
(10,'2023-12-01 00:00:00','2023-12-10 00:00:00',4),
(11,'2024-01-01 00:00:00','2024-01-10 00:00:00',1),
(12,'2024-02-01 00:00:00','2024-02-10 00:00:00',2),
(13,'2024-03-01 00:00:00','2024-03-10 00:00:00',3),
(14,'2024-04-01 00:00:00','2024-04-10 00:00:00',4),
(1,'2024-05-01 00:00:00','2024-05-10 00:00:00',1),
(2,'2024-06-01 00:00:00','2024-06-10 00:00:00',2),
(3,'2024-07-01 00:00:00','2024-07-10 00:00:00',3),
(4,'2024-08-01 00:00:00','2024-08-10 00:00:00',4),
(5,'2024-09-01 00:00:00','2024-09-10 00:00:00',1),
(6,'2024-10-01 00:00:00','2024-10-10 00:00:00',2),
(7,'2024-11-01 00:00:00','2024-11-10 00:00:00',3),
(8,'2024-12-01 00:00:00','2024-12-10 00:00:00',4),
(9,'2021-01-01 00:00:00','2021-01-10 00:00:00',1),
(10,'2021-02-01 00:00:00','2021-02-10 00:00:00',2),
(11,'2021-03-01 00:00:00','2021-03-10 00:00:00',3),
(12,'2021-04-01 00:00:00','2021-04-10 00:00:00',4),
(13,'2021-05-01 00:00:00','2021-05-10 00:00:00',1),
(14,'2021-06-01 00:00:00','2021-06-10 00:00:00',2),
(1,'2021-07-01 00:00:00','2021-07-10 00:00:00',3),
(2,'2021-08-01 00:00:00','2021-08-10 00:00:00',4),
(3,'2021-09-01 00:00:00','2021-09-10 00:00:00',1),
(4,'2021-10-01 00:00:00','2021-10-10 00:00:00',2),
(5,'2021-11-01 00:00:00','2021-11-10 00:00:00',3),
(6,'2021-12-01 00:00:00','2021-12-10 00:00:00',4),
(7,'2022-01-01 00:00:00','2022-01-10 00:00:00',1),
(8,'2022-02-01 00:00:00','2022-02-10 00:00:00',2),
(9,'2022-03-01 00:00:00','2022-03-10 00:00:00',3),
(10,'2022-04-01 00:00:00','2022-04-10 00:00:00',4),
(11,'2022-05-01 00:00:00','2022-05-10 00:00:00',1),
(12,'2022-06-01 00:00:00','2022-06-10 00:00:00',2),
(13,'2022-07-01 00:00:00','2022-07-10 00:00:00',3),
(14,'2022-08-01 00:00:00','2022-08-10 00:00:00',4),
(1,'2022-09-01 00:00:00','2022-09-10 00:00:00',1),
(2,'2022-10-01 00:00:00','2022-10-10 00:00:00',2),
(3,'2022-11-01 00:00:00','2022-11-10 00:00:00',3),
(4,'2022-12-01 00:00:00','2022-12-10 00:00:00',4),
(5,'2021-01-01 00:00:00','2021-01-10 00:00:00',1),
(6,'2021-02-01 00:00:00','2021-02-10 00:00:00',2),
(7,'2021-03-01 00:00:00','2021-03-10 00:00:00',3),
(8,'2021-04-01 00:00:00','2021-04-10 00:00:00',4);
/*!40000 ALTER TABLE `absence` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `motif`
--

DROP TABLE IF EXISTS `motif`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `motif` (
  `idmotif` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `motif`
--

LOCK TABLES `motif` WRITE;
/*!40000 ALTER TABLE `motif` DISABLE KEYS */;
INSERT INTO `motif` VALUES
(1,'vacances'),
(2,'maladie'),
(3,'motif familial'),
(4,'congé parental');
/*!40000 ALTER TABLE `motif` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `personnel` (
  `idpersonnel` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int(11) NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personnel`
--

LOCK TABLES `personnel` WRITE;
/*!40000 ALTER TABLE `personnel` DISABLE KEYS */;
INSERT INTO `personnel` VALUES
(1,'Dupont','Jean','0123456789','jean.dupont@mail.com',1),
(2,'Martin','Marie','0123456780','marie.martin@mail.com',2),
(3,'Lefevre','Paul','0123456781','paul.lefevre@mail.com',3),
(4,'Durand','Julie','0123456782','julie.durand@mail.com',1),
(5,'Moreau','Lucas','0123456783','lucas.moreau@mail.com',2),
(6,'Simon','Emma','0123456784','emma.simon@mail.com',3),
(7,'Laurent','Maxime','0123456785','maxime.laurent@mail.com',1),
(8,'Lemoine','Chloe','0123456786','chloe.lemoine@mail.com',3),
(9,'Girard','Alexandre','0123450787','alexandre.girard@mail.com',3),
(10,'Roux','Alice','0123456788','alice.roux@mail.com',1),
(11,'Leroy','Thomas','0123456789','thomas.leroy@mail.com',2),
(12,'Morel','Sarah','0123456780','sarah.morel@mail.com',3),
(13,'Fournier','Nicolas','0123456781','nicolas.fournier@mail.com',1),
(14,'Guerin','Camille','0123456782','camille.guerin@mail.com',2),
(15,'Ochon','Paul','0182776645','paul.ochon@mail.com',1);
/*!40000 ALTER TABLE `personnel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `responsable`
--

LOCK TABLES `responsable` WRITE;
/*!40000 ALTER TABLE `responsable` DISABLE KEYS */;
INSERT INTO `responsable` VALUES
('admin','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');
/*!40000 ALTER TABLE `responsable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service`
--

DROP TABLE IF EXISTS `service`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `service` (
  `idservice` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service`
--

LOCK TABLES `service` WRITE;
/*!40000 ALTER TABLE `service` DISABLE KEYS */;
INSERT INTO `service` VALUES
(1,'administratif'),
(2,'médiation culturelle'),
(3,'prêt');
/*!40000 ALTER TABLE `service` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-04 12:35:43
