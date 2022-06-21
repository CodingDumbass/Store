-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: shop_db
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `producttable`
--

DROP TABLE IF EXISTS `producttable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producttable` (
  `ProductId` int NOT NULL,
  `ProductPrice` decimal(10,2) NOT NULL,
  `ProductName` varchar(40) NOT NULL,
  `ProductDescription` text NOT NULL,
  `ProductImage` text NOT NULL,
  `ProductStock` int NOT NULL,
  `ProductWeight` decimal(8,2) NOT NULL,
  `CategoryId` int NOT NULL,
  PRIMARY KEY (`ProductId`),
  UNIQUE KEY `ProductId` (`ProductId`),
  KEY `Cat_FK` (`CategoryId`),
  CONSTRAINT `Cat_FK` FOREIGN KEY (`CategoryId`) REFERENCES `categorytable` (`CategoryId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producttable`
--

LOCK TABLES `producttable` WRITE;
/*!40000 ALTER TABLE `producttable` DISABLE KEYS */;
INSERT INTO `producttable` VALUES (1008,25.67,'EggWhites','Ne mi se zanimavashe','https://cutt.ly/AJdfdOK',103,847.70,4),(1120,60.21,'CherenHlqb','Ne mi se zanimavashe','https://cutt.ly/6Jdjaqj',108,854.77,1),(1217,20.60,'Coca-Cola','Ne mi se zanimavashe','https://www.generatormi',26,301.65,8),(1417,46.12,'BIOKOLA','Ne mi se zanimavashe','https://cutt.ly/PJdhXt6',89,1286.96,5),(1481,42.95,'FrozenPeas','Ne mi se zanimavashe','https://cutt.ly/MJdg4hi',107,286.95,6),(1676,19.75,'PizzaFeliciana','Ne mi se zanimavashe','https://cutt.ly/QJdg1gT',42,883.11,6),(2006,40.25,'BIOMLEKONUTS','Ne mi se zanimavashe','https://cutt.ly/QJdhNFW',86,363.40,5),(2192,42.28,'SladoledNestle','Ne mi se zanimavashe','https://cutt.ly/BJdgHU9',23,1372.98,6),(2377,3.14,'Veal','Ne mi se zanimavashe','https://www.generatormix.com/images/meat/veal.jpg',92,782.81,3),(2523,53.19,'FrozenFruitsMix','Ne mi se zanimavashe','https://cutt.ly/cJdhqF9',56,241.82,6),(2564,21.90,'Pear','Ne mi se zanimavashe','https://www.generatormix.com/images/fruit/pear.jpg',56,1120.29,2),(2656,2.98,'GLUTENFREEBUNS','Ne mi se zanimavashe','https://cutt.ly/ZJdh5sG',54,343.57,5),(2975,5.74,'Banana','Ne mi se zanimavashe','https://www.generatormix.com/images/fruit/banana.jpg',23,729.90,2),(3289,4.70,'BeyondMince','Ne mi se zanimavashe','https://cutt.ly/GJdgCYm',68,1220.63,6),(3417,49.53,'Strawberry','Ne mi se zanimavashe','https://www.ebag.bg/products/585262/images/0/800',104,1025.13,2),(3451,27.23,'BrashnoSofiaMel','Ne mi se zanimavashe','https://cutt.ly/fJdfJqw',54,1221.42,7),(3631,8.49,'Ham','Ne mi se zanimavashe','https://www.generatormix.com/images/meat/ham.jpg',94,1035.53,3),(4223,38.76,'EggsRodnaSrqha','Ne mi se zanimavashe','https://cutt.ly/kJdfrNC',115,1104.24,4),(4322,38.80,'Stevia','Ne mi se zanimavashe','https://cutt.ly/QJdgdru',63,1383.47,7),(4484,14.60,'Sprite','Ne mi se zanimavashe','https://cutt.ly/gJdsb0G',56,179.36,8),(4495,12.88,'Pork','Ne mi se zanimavashe','https://www.generatormix.com/images/meat/pork.jpg',21,507.32,3),(4666,47.24,'Apple','Ne mi se zanimavashe','https://bellavitashop.co.uk/6288-large_default/red-apples-500g.jpg',88,1140.17,2),(4903,75.10,'KekscheUsmivka','Da','https://www.ebag.bg/products/images/94459/200',69,120.43,1),(4908,42.02,'VereqKiseloMlqko','Ne mi se zanimavashe','https://cutt.ly/nJddJGQ',55,1403.17,4),(5286,42.85,'FrozenPotatoes','Ne mi se zanimavashe','https://cutt.ly/LJdhi36',36,443.92,5),(5718,39.87,'Blueberry','Ne mi se zanimavashe','https://www.generatormix.com/images/fruit/blueberry.jpg',89,330.49,2),(5805,3.59,'Emu','Ne mi se zanimavashe','https://www.generatormix.com/images/meat/emu.jpg',100,1293.63,3),(5927,34.82,'Pineapple','Ne mi se zanimavashe','https://www.generatormix.com/images/fruit/pineapple.jpg',100,351.35,2),(5972,59.71,'HimalaiskaSol','Ne mi se zanimavashe','https://cutt.ly/wJdgzqI',90,128.04,7),(6146,12.05,'Lobster','Ne mi se zanimavashe','https://www.generatormix.com/images/meat/lobster.jpg',21,1001.35,3),(6888,39.51,'VereqMaslo','Ne mi se zanimavashe','https://cutt.ly/YJddCIk',40,792.36,4),(7152,56.21,'Suhari','Ne mi se zanimavashe','https://cutt.ly/VJdjGtF',42,563.01,1),(7277,44.60,'Lemon','Ne mi se zanimavashe','https://www.generatormix.com/images/fruit/lemon.jpg',48,908.31,2),(7285,33.01,'ChervenSimid','Ne mi se zanimavashe','https://cutt.ly/iJdjYDj',27,1271.65,1),(7417,28.18,'Octopus','Ne mi se zanimavashe','https://www.generatormix.com/images/meat/octopus.jpg',50,352.17,3),(7517,4.88,'Chicken','Ne mi se zanimavashe','https://www.generatormix.com/images/meat/chicken.jpg',120,188.93,3),(7605,28.24,'VereqSirene','Ne mi se zanimavashe','https://cutt.ly/UJddOdT',97,1147.01,4),(8136,56.70,'MaqDrOetkler','Ne mi se zanimavashe','https://cutt.ly/VJdf61C',70,1324.76,7),(8277,52.59,'Avocado','Ne mi se zanimavashe','https://www.generatormix.com/images/fruit/avocado.jpg',74,1212.86,2),(8486,9.10,'BIOSOKQBULKA','Ne mi se zanimavashe','https://cutt.ly/dJdhGXU',106,426.04,5),(8591,32.93,'Cantaloupe','Ne mi se zanimavashe','https://www.generatormix.com/images/fruit/cantaloupe.jpg',37,529.78,2),(8628,22.36,'BrownBuns','Ne mi se zanimavashe','https://cutt.ly/rJdjkHX',113,1160.61,1),(8640,36.14,'Mutton','Ne mi se zanimavashe','https://www.generatormix.com/images/meat/mutton.jpg',54,574.30,3),(8649,36.20,'Squid','Ne mi se zanimavashe','https://www.generatormix.com/images/meat/squid.jpg',117,437.55,3),(8704,23.26,'VereqPrqsnoMlqko','Ne mi se zanimavashe','https://cutt.ly/LJddhwi',40,148.20,4),(8751,37.96,'MayoHellmanns','Ne mi se zanimavashe','https://cutt.ly/JJdgUhf',118,306.21,7),(8926,32.32,'Fanta','Ne mi se zanimavashe','https://cutt.ly/OJdslju',57,825.34,8),(9310,2.47,'BrownSugar','Ne mi se zanimavashe','https://cutt.ly/cJdguzt',112,1101.71,7),(9319,33.12,'Peach','Ne mi se zanimavashe','https://www.generatormix.com/images/fruit/peach.jpg',95,446.41,2),(9619,41.52,'DevinVoda','Ne mi se zanimavashe','https://cutt.ly/QJdsTlb',87,688.71,4),(9709,46.09,'Salmon','Ne mi se zanimavashe','https://www.generatormix.com/images/meat/salmon.jpg',98,520.20,3);
/*!40000 ALTER TABLE `producttable` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-06-01  0:34:46
