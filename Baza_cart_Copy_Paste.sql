-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: chcar
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cart`
--

DROP TABLE IF EXISTS `cart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cart` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Marka` char(40) NOT NULL,
  `Model` char(65) NOT NULL,
  `Paliwo` char(15) DEFAULT NULL,
  `Moc` int NOT NULL,
  `Cena` float NOT NULL,
  `Przebieg` float NOT NULL,
  `Pojemnosc` float NOT NULL,
  `DataProd` year DEFAULT NULL,
  `Opis` varchar(3000) DEFAULT NULL,
  `Tag` varchar(3500) DEFAULT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `cart_chk_1` CHECK ((`Cena` > 0)),
  CONSTRAINT `cart_chk_2` CHECK ((`Przebieg` > 0))
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cart`
--

LOCK TABLES `cart` WRITE;
/*!40000 ALTER TABLE `cart` DISABLE KEYS */;
INSERT INTO `cart` VALUES (6,'Ford','Mondeo','Benzyna',125,5000,202000,1.8,2000,'Super auto. Posiada klimatyzację ','Ford,Mondeo,Benzyna,125'),(8,'Volkswagen','Passat','Diesel',110,5000,202000,1.9,2000,'Super auto. Posiada klimatyzację ','Volkswagen,Passat,Diesel,110'),(9,'Skoda','Octawia II','Benzyna',125,5000,202000,1.8,2000,'Super auto. Posiada klimatyzację ','Skoda,Octawia II,Benzyna,125'),(10,'Citroen','C3','Benzyna',125,5000,202000,1.8,2000,'Super auto. Posiada klimatyzację ','Citroen,C3,Benzyna,125'),(11,'Peugeot','207','Benzyna',125,5000,202000,1.8,2000,'Super auto. Posiada klimatyzację ','Peugeot,207,Benzyna,125'),(12,'Mazda','Super','Benzyna',125,5000,202000,1.8,2000,'Super auto. Posiada klimatyzację ','Mazda,Super,Benzyna,125'),(13,'Audi','A4B5','Benzyna',125,5000,202000,1.8,2000,'Super auto. Posiada klimatyzację ','Audi,A4B5,Benzyna,125'),(14,'Renault','Clio 2','Benzyna',125,5000,202000,1.8,2000,'Super auto. Posiada klimatyzację ','Renault,Clio II,Benzyna,125'),(15,'Subaru','Impreza','Benzyna',200,99,200,2,2023,'Subaru 4x4\r\n','Klimatyzacja,ABS,Subaru,Impreza,Benzyna'),(16,'BMW','e46','Diesel',200,14000,200,3,2003,'Super pojazd\r\n','Klimatyzacja,ASR,ESP,ABS,BMW,e46,Diesel');
/*!40000 ALTER TABLE `cart` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-27 22:11:22
