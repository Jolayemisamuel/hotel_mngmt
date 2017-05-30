CREATE DATABASE  IF NOT EXISTS `hotel` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `hotel`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: hotel
-- ------------------------------------------------------
-- Server version	5.6.26-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employees` (
  `name` varchar(30) NOT NULL DEFAULT '',
  `user_name` varchar(30) NOT NULL DEFAULT '',
  `password` varchar(30) NOT NULL DEFAULT '',
  `emp_type` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES ('Patrick Kevorkian','pat','1',1),('Andy Haung ','andy','2',0),('Yas','yasasvi','3',1),('Yas','yasasvi2','3',0);
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menu` (
  `item_name` varchar(30) NOT NULL DEFAULT '',
  `price` decimal(6,2) unsigned NOT NULL,
  `description` varchar(96) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES ('Steak',15.00,'A prime cut of beef tenderloin served to order.'),('Chicken parm',12.00,'Fried chicken with sauce and cheese. '),('French Fries',4.00,'Fried potatoes.'),('Champagne ',100.00,'a bottle '),('Coke',2.00,'A bottle of carbinated water with syrup');
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_items`
--

DROP TABLE IF EXISTS `order_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order_items` (
  `order_num` int(13) unsigned NOT NULL,
  `item` varchar(30) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_items`
--

LOCK TABLES `order_items` WRITE;
/*!40000 ALTER TABLE `order_items` DISABLE KEYS */;
INSERT INTO `order_items` VALUES (1,'Steak'),(1,'Coke'),(1,'French Fries'),(13,'Steak'),(13,'Coke'),(14,'Chicken parm'),(14,'Champagne '),(15,'Steak'),(15,'French Fries'),(15,'Coke'),(15,'Champagne '),(16,'Chicken parm'),(17,'Champagne '),(17,'Champagne '),(17,'Champagne '),(17,'Champagne '),(17,'Champagne '),(18,'Steak'),(19,'Champagne '),(19,'Steak'),(20,'Steak'),(21,'Coke'),(22,'Coke'),(22,'Coke'),(22,'Coke'),(22,'Coke'),(23,'Steak'),(23,'Chicken parm'),(23,'French Fries'),(23,'Champagne '),(23,'Coke'),(23,'Champagne '),(23,'French Fries'),(23,'Chicken parm'),(23,'Steak'),(23,'Chicken parm'),(23,'French Fries'),(23,'Champagne '),(23,'Coke'),(23,'Champagne '),(23,'French Fries'),(23,'Chicken parm'),(23,'Steak'),(23,'Chicken parm'),(23,'French Fries'),(23,'Champagne '),(23,'Coke'),(23,'Coke'),(23,'Champagne '),(23,'French Fries'),(23,'Chicken parm'),(24,'Chicken parm'),(24,'Chicken parm'),(24,'Chicken parm'),(24,'Chicken parm'),(24,'Coke'),(24,'Coke'),(24,'Coke'),(24,'Coke'),(25,'French Fries'),(25,'French Fries'),(28,'Chicken parm'),(28,'Chicken parm'),(28,'Chicken parm'),(28,'Chicken parm'),(28,'Chicken parm'),(28,'Chicken parm'),(28,'Chicken parm'),(28,'Chicken parm'),(28,'Chicken parm'),(29,'Steak'),(29,'Steak'),(29,'Steak'),(29,'Steak'),(29,'Steak'),(29,'Chicken parm'),(29,'Chicken parm'),(29,'Chicken parm'),(31,'Steak'),(31,'Steak'),(31,'Chicken parm'),(31,'Chicken parm'),(33,'Steak'),(33,'Steak'),(33,'Steak'),(33,'Steak'),(33,'Steak'),(33,'Steak'),(33,'Steak'),(34,'French Fries'),(34,'French Fries'),(34,'French Fries'),(34,'French Fries'),(35,'French Fries'),(35,'Steak'),(35,'Champagne '),(35,'French Fries'),(35,'Chicken parm'),(35,'Chicken parm'),(35,'Steak'),(35,'Steak'),(35,'Chicken parm'),(35,'French Fries'),(36,'Chicken parm'),(36,'Coke');
/*!40000 ALTER TABLE `order_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders` (
  `order_num` int(13) unsigned NOT NULL AUTO_INCREMENT,
  `room_num` varchar(11) NOT NULL,
  `record_num` int(13) unsigned NOT NULL,
  `finished` tinyint(1) unsigned NOT NULL,
  PRIMARY KEY (`order_num`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'1',1,1),(13,'1',1,1),(14,'1',1,1),(15,'1',1,1),(16,'1',1,1),(17,'1',1,1),(18,'1',1,1),(19,'2',6,1),(20,'3',4,1),(21,'2',6,1),(22,'1',1,1),(23,'3',7,1),(24,'2',8,1),(25,'1',9,1),(28,'1',9,1),(29,'2',10,1),(31,'1',12,1),(33,'3',11,1),(34,'2',14,1),(35,'3',11,0),(36,'4',15,1);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `records`
--

DROP TABLE IF EXISTS `records`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `records` (
  `record_num` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL DEFAULT '',
  `cc_num` varchar(19) NOT NULL DEFAULT '',
  `exp_date` varchar(7) NOT NULL DEFAULT '',
  `room_num` varchar(4) NOT NULL DEFAULT '',
  `time_in` date NOT NULL DEFAULT '0000-00-00',
  `time_out` date NOT NULL DEFAULT '0000-00-00',
  `price` decimal(7,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`record_num`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `records`
--

LOCK TABLES `records` WRITE;
/*!40000 ALTER TABLE `records` DISABLE KEYS */;
INSERT INTO `records` VALUES (1,'Steven James','6666-6666-6666-6666','66/6666','1','2015-04-30','2015-05-02',924.00),(4,'Patrick Star','1111-1111-1111-1111','11/1111','3','2015-04-30','2015-05-02',215.00),(6,'steve','4444-4444-4444-4444','04/2016','2','2015-05-01','2015-05-02',147.00),(7,'Steven K','1231-2312-3123-1231','09/2018','3','2015-05-02','2015-05-02',749.00),(8,'abc easyas','1231-2312-3111-2311','12/2018','2','2015-05-02','2015-05-02',0.00),(9,'First Name','0987-6543-2456-7892','12/2015','1','2015-05-02','2015-05-02',116.00),(10,'Patty Watty','1231-2321-3123-1231','08/2018','2','2015-05-02','2015-05-02',111.00),(11,'Georgie Foreman','1231-1233-3123-1231','01/2017','3','2015-05-02','0000-00-00',105.00),(12,'Chuck Norris','6666-6666-6666-6666','08/2017','1','2015-05-02','2015-05-02',54.00),(13,'Chuck Borris','1111-1111-1111-1111','11/2018','2','2015-05-02','2015-05-02',0.00),(14,'DoYouSee MyName','1231-2312-1231-2312','09/2017','2','2015-05-02','2016-03-07',9316.00),(15,'Billy Kong','1231-2312-3123-1231','12/2015','4','2015-05-08','0000-00-00',14.00),(16,'asdasdasdasd asd','1212-1212-1212-1212','12/2016','1','2016-03-07','0000-00-00',0.00);
/*!40000 ALTER TABLE `records` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rooms`
--

DROP TABLE IF EXISTS `rooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rooms` (
  `room_num` varchar(4) NOT NULL DEFAULT '',
  `beds` varchar(1) NOT NULL DEFAULT '',
  `baths` varchar(1) NOT NULL DEFAULT '',
  `balcony` tinyint(1) NOT NULL,
  `oceanv` tinyint(1) NOT NULL,
  `suite` tinyint(1) NOT NULL,
  `ppn` decimal(7,2) NOT NULL,
  `vacant` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`room_num`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rooms`
--

LOCK TABLES `rooms` WRITE;
/*!40000 ALTER TABLE `rooms` DISABLE KEYS */;
INSERT INTO `rooms` VALUES ('1','2','1',0,0,0,50.00,0),('2','1','1',1,0,0,30.00,1),('3','3','2',1,1,1,100.00,0),('4','1','1',1,1,0,40.00,0);
/*!40000 ALTER TABLE `rooms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'hotel'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-21  8:33:17
