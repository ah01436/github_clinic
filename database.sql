CREATE DATABASE  IF NOT EXISTS `clinic` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `clinic`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win32 (AMD64)
--
-- Host: localhost    Database: clinic
-- ------------------------------------------------------
-- Server version	5.0.51b-community-nt-log

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
-- Not dumping tablespaces as no INFORMATION_SCHEMA.FILES table on this server
--

--
-- Table structure for table `asd`
--

DROP TABLE IF EXISTS `asd`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asd` (
  `i` int(11) NOT NULL,
  PRIMARY KEY  (`i`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asd`
--

LOCK TABLES `asd` WRITE;
/*!40000 ALTER TABLE `asd` DISABLE KEYS */;
INSERT  IGNORE INTO `asd` (`i`) VALUES (1),(2),(3),(4),(5),(6),(7),(8),(9);
/*!40000 ALTER TABLE `asd` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clinic_info`
--

DROP TABLE IF EXISTS `clinic_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clinic_info` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(50) default NULL,
  `doctor` varchar(50) default NULL,
  `address` varchar(50) default NULL,
  `telephone` varchar(14) default NULL,
  `mobile` varchar(14) default NULL,
  `fax` varchar(50) default NULL,
  `email` varchar(50) default NULL,
  `website` varchar(50) default NULL,
  `fb_page` varchar(100) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clinic_info`
--

LOCK TABLES `clinic_info` WRITE;
/*!40000 ALTER TABLE `clinic_info` DISABLE KEYS */;
INSERT  IGNORE INTO `clinic_info` (`id`, `name`, `doctor`, `address`, `telephone`, `mobile`, `fax`, `email`, `website`, `fb_page`) VALUES (1,'الزهور للعلاج الطبيعى ','هبة عاطف عبد الاه','قنا / فرشوط ','6606755','01003528987','HTTP://www.fax.com','ah01167@yahoo.com','WWW.Elostora.com','www.facebook.com');
/*!40000 ALTER TABLE `clinic_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devices`
--

DROP TABLE IF EXISTS `devices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `devices` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(50) default NULL,
  `quantity` int(11) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devices`
--

LOCK TABLES `devices` WRITE;
/*!40000 ALTER TABLE `devices` DISABLE KEYS */;
INSERT  IGNORE INTO `devices` (`id`, `name`, `quantity`) VALUES (2,'جهاز 1',25),(3,'جهاز 2',20);
/*!40000 ALTER TABLE `devices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diagnosis`
--

DROP TABLE IF EXISTS `diagnosis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diagnosis` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(50) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnosis`
--

LOCK TABLES `diagnosis` WRITE;
/*!40000 ALTER TABLE `diagnosis` DISABLE KEYS */;
INSERT  IGNORE INTO `diagnosis` (`id`, `name`) VALUES (1,'تحليل 1');
/*!40000 ALTER TABLE `diagnosis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expenses`
--

DROP TABLE IF EXISTS `expenses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `expenses` (
  `id` int(11) NOT NULL auto_increment,
  `item_id` int(11) default NULL,
  `expense_date` date default NULL,
  `price` float default NULL,
  `notes` varchar(255) default NULL,
  PRIMARY KEY  (`id`),
  KEY `item_id` (`item_id`),
  CONSTRAINT `expenses_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `item_expense` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expenses`
--

LOCK TABLES `expenses` WRITE;
/*!40000 ALTER TABLE `expenses` DISABLE KEYS */;
INSERT  IGNORE INTO `expenses` (`id`, `item_id`, `expense_date`, `price`, `notes`) VALUES (5,2,'2017-08-18',54,'خالد'),(6,6,'2017-08-24',61,'على عبد السلام'),(7,2,'2017-08-04',60,'محمد على '),(8,4,'2017-08-25',1000,'احمد'),(9,3,'2017-08-14',1,'asdas'),(10,3,'2017-08-14',1,'asdas'),(11,3,'2017-08-14',1,'asdas');
/*!40000 ALTER TABLE `expenses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventory` (
  `item_id` int(11) NOT NULL auto_increment,
  `item_name` varchar(100) default NULL,
  `item_qty` int(11) default NULL,
  `item_sell_price` float default NULL,
  `item_buy_price` float default NULL,
  `item_function` varchar(200) default NULL,
  PRIMARY KEY  (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT  IGNORE INTO `inventory` (`item_id`, `item_name`, `item_qty`, `item_sell_price`, `item_buy_price`, `item_function`) VALUES (1,'ali',1,1,1,'lmjk'),(2,'sdA',1,1,1,'asd'),(3,'JBGJHB',1,1,1,'');
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_expense`
--

DROP TABLE IF EXISTS `item_expense`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `item_expense` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(50) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_expense`
--

LOCK TABLES `item_expense` WRITE;
/*!40000 ALTER TABLE `item_expense` DISABLE KEYS */;
INSERT  IGNORE INTO `item_expense` (`id`, `name`) VALUES (1,'بند 1'),(2,'بند 2'),(3,'asdasd'),(4,'sdgdgfdg'),(5,'ASasAS'),(6,'dsfdsf');
/*!40000 ALTER TABLE `item_expense` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `login` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `staff_id` varchar(20) default NULL,
  PRIMARY KEY  (`username`),
  KEY `staff_id` (`staff_id`),
  CONSTRAINT `login_ibfk_1` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patient` (
  `patient_id` varchar(20) NOT NULL,
  `patient_name` varchar(50) default NULL,
  `patient_gender` varchar(10) default NULL,
  `patient_birth_date` date default NULL,
  `patient_register_date` date default NULL,
  `patient_status` varchar(10) default NULL,
  `patient_address` varchar(100) default NULL,
  `patient_email` varchar(20) default NULL,
  `patient_contact_no` varchar(20) default NULL,
  `transformers_id` int(11) default NULL,
  PRIMARY KEY  (`patient_id`),
  KEY `transformers_id` (`transformers_id`),
  CONSTRAINT `patient_ibfk_1` FOREIGN KEY (`transformers_id`) REFERENCES `transformers` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT  IGNORE INTO `patient` (`patient_id`, `patient_name`, `patient_gender`, `patient_birth_date`, `patient_register_date`, `patient_status`, `patient_address`, `patient_email`, `patient_contact_no`, `transformers_id`) VALUES ('P_101','محمد على عبد السلام','ذكر','2000-01-18','2017-09-07','متزوج','ش مصر','ah01436@yahoo.com','01003008393',3),('P_105','glsdfgsdfg','انثى','2000-01-01','2017-08-13','متزوجة','gdfgsdfgsdfg','','3213123123',2),('P_106','نانسى عجرم','انثى','2000-01-25','2017-09-27','متزوجه','قنا ','ah011455@gmail.com','01048818570',3),('P_107','ASDASD','انثى','2000-01-01','2017-09-05','متزوجة','','','01003008393',1),('P_109','Ahmed Hamdy ','انثى','2000-01-01','2017-09-05','متزوجة','','','01003008393',1);
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rays`
--

DROP TABLE IF EXISTS `rays`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rays` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(50) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rays`
--

LOCK TABLES `rays` WRITE;
/*!40000 ALTER TABLE `rays` DISABLE KEYS */;
INSERT  IGNORE INTO `rays` (`id`, `name`) VALUES (1,'اشعة '),(2,'asdasda');
/*!40000 ALTER TABLE `rays` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staff` (
  `staff_id` varchar(20) NOT NULL,
  `staff_name` varchar(50) default NULL,
  `staff_gender` varchar(10) default NULL,
  `staff_birth_date` date default NULL,
  `staff_date_of_employee` date default NULL,
  `staff_status` varchar(10) default NULL,
  `staff_address` varchar(100) default NULL,
  `staff_email` varchar(20) default NULL,
  `staff_contact_no` varchar(14) default NULL,
  `staff_contact_no2` varchar(14) default NULL,
  `staff_position` varchar(10) default NULL,
  `staff_nat_id` varchar(14) default NULL,
  PRIMARY KEY  (`staff_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT  IGNORE INTO `staff` (`staff_id`, `staff_name`, `staff_gender`, `staff_birth_date`, `staff_date_of_employee`, `staff_status`, `staff_address`, `staff_email`, `staff_contact_no`, `staff_contact_no2`, `staff_position`, `staff_nat_id`) VALUES ('E_101','محمد على ','ذكر','1998-12-28','2017-08-04','متزوج','قنا','ah01436@yahoo.com','01148818570',' ',NULL,NULL),('E_102','احمد على احمد على ','انثى','2000-01-12','2017-08-09','متزوجه','','ah01167@yahoo.com','01003008393',' ','دكتور',NULL),('E_103','خالد على','ذكر ',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `supplier` (
  `supplier_id` int(11) NOT NULL auto_increment,
  `supplier_name` varchar(50) default NULL,
  `supplier_contact_no` varchar(14) default NULL,
  `supplier_contact_no2` varchar(14) default NULL,
  `supplier_email` varchar(20) default NULL,
  `supplier_address` varchar(100) default NULL,
  PRIMARY KEY  (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT  IGNORE INTO `supplier` (`supplier_id`, `supplier_name`, `supplier_contact_no`, `supplier_contact_no2`, `supplier_email`, `supplier_address`) VALUES (1,'hrgdsdfdg',NULL,NULL,NULL,NULL),(2,'احمد على احمد على ','123333333',NULL,NULL,NULL);
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_lists`
--

DROP TABLE IF EXISTS `tb_lists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_lists` (
  `list_id` int(11) NOT NULL,
  `list_name` varchar(45) default NULL,
  PRIMARY KEY  (`list_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_lists`
--

LOCK TABLES `tb_lists` WRITE;
/*!40000 ALTER TABLE `tb_lists` DISABLE KEYS */;
INSERT  IGNORE INTO `tb_lists` (`list_id`, `list_name`) VALUES (1,'الاشخاص'),(2,'ادارة الزيارات'),(3,'الادارة العامة'),(4,'التقارير');
/*!40000 ALTER TABLE `tb_lists` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_priv`
--

DROP TABLE IF EXISTS `tb_priv`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_priv` (
  `priv_user_id` varchar(20) default NULL,
  `priv_screen_id` int(11) default NULL,
  `priv_display` tinyint(1) default NULL,
  `priv_add` tinyint(1) default NULL,
  `priv_delete` tinyint(1) default NULL,
  `priv_edit` tinyint(1) default NULL,
  KEY `priv_screen_id` (`priv_screen_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_priv`
--

LOCK TABLES `tb_priv` WRITE;
/*!40000 ALTER TABLE `tb_priv` DISABLE KEYS */;
INSERT  IGNORE INTO `tb_priv` (`priv_user_id`, `priv_screen_id`, `priv_display`, `priv_add`, `priv_delete`, `priv_edit`) VALUES ('user_101',1,1,1,1,1),('user_101',2,1,1,1,1),('user_101',3,1,0,0,0),('user_101',4,1,1,1,1),('user_101',5,1,1,1,1),('user_101',6,1,0,0,0),('user_101',7,1,0,0,0),('user_101',8,1,0,0,0),('user_101',9,1,0,0,0),('user_101',10,1,0,0,0),('user_101',11,1,0,0,0),('user_101',12,1,1,0,0),('user_101',13,1,1,0,0),('user_101',14,0,1,0,0),('user_101',15,0,0,0,0),('user_101',16,0,0,0,0),('user_101',17,0,0,0,0),('user_103',1,0,0,0,0),('user_103',2,0,0,0,0),('user_103',3,1,0,0,0),('user_103',4,1,0,0,0),('user_103',5,1,0,0,0),('user_103',6,1,0,0,0),('user_103',7,1,0,0,0),('user_103',8,0,0,0,0),('user_103',9,0,0,0,0),('user_103',10,0,0,0,0),('user_103',11,1,0,0,0),('user_103',12,1,0,0,0),('user_103',13,1,0,0,0),('user_103',14,1,0,0,0),('user_103',15,1,0,0,0),('user_103',16,1,0,0,0),('user_103',17,1,0,0,0);
/*!40000 ALTER TABLE `tb_priv` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_screen`
--

DROP TABLE IF EXISTS `tb_screen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_screen` (
  `screen_id` int(11) NOT NULL,
  `screen_name` varchar(45) default NULL,
  `list_id` int(11) default NULL,
  PRIMARY KEY  (`screen_id`),
  KEY `list_id` (`list_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_screen`
--

LOCK TABLES `tb_screen` WRITE;
/*!40000 ALTER TABLE `tb_screen` DISABLE KEYS */;
INSERT  IGNORE INTO `tb_screen` (`screen_id`, `screen_name`, `list_id`) VALUES (1,'ادارة المرضى ',1),(2,'ادارة الموظفين',1),(3,'ادارة الموردين',1),(4,'ادارة المستخدمين',1),(5,'اضافة نوع زيارة ',2),(6,'ادارة الاجهزة ',3),(7,'ادارة الاشعة ',3),(8,'ادارة التحاليل',3),(9,'بنود المصروفات',3),(10,'المصروفات ',3),(11,'المخزن',3),(12,'المصروفات',4),(13,' بنود المصروفات',4),(14,'المرضى',4),(15,'الموظفين ',4),(16,'التعريف بالعيادة ',4),(17,'الموردين',4);
/*!40000 ALTER TABLE `tb_screen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transformers`
--

DROP TABLE IF EXISTS `transformers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transformers` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(50) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transformers`
--

LOCK TABLES `transformers` WRITE;
/*!40000 ALTER TABLE `transformers` DISABLE KEYS */;
INSERT  IGNORE INTO `transformers` (`id`, `name`) VALUES (1,'لا اعلم'),(2,'محمد عبد الصبور'),(3,'احمد على ');
/*!40000 ALTER TABLE `transformers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `userID` varchar(20) NOT NULL,
  `userName` varchar(30) NOT NULL,
  `password` varchar(50) default NULL,
  `emp_id` varchar(20) NOT NULL,
  `emp_name` varchar(50) default NULL,
  PRIMARY KEY  (`userID`),
  KEY `emp_id` (`emp_id`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`emp_id`) REFERENCES `staff` (`staff_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT  IGNORE INTO `user` (`userID`, `userName`, `password`, `emp_id`, `emp_name`) VALUES ('user_101','ah01436','123456','E_101','محمد على '),('user_102','asd','asd','E_102','احمد على احمد على '),('user_103','qwe','1','E_103','خالد على');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `visit_type`
--

DROP TABLE IF EXISTS `visit_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `visit_type` (
  `v_id` int(11) NOT NULL auto_increment,
  `v_name` varchar(100) default NULL,
  `v_price` float default NULL,
  `v_nurse_offer` float default NULL,
  PRIMARY KEY  (`v_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `visit_type`
--

LOCK TABLES `visit_type` WRITE;
/*!40000 ALTER TABLE `visit_type` DISABLE KEYS */;
INSERT  IGNORE INTO `visit_type` (`v_id`, `v_name`, `v_price`, `v_nurse_offer`) VALUES (1,'كشف',50,2.5),(2,'زيارة',20,3.5);
/*!40000 ALTER TABLE `visit_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `visits`
--

DROP TABLE IF EXISTS `visits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `visits` (
  `id` int(11) NOT NULL auto_increment,
  `pat_id` varchar(45) default NULL,
  `doc_id` varchar(45) default NULL,
  `user_id` varchar(45) default NULL,
  `date_visit` date default NULL,
  `visite_type_code` int(11) default NULL,
  `isopen` tinyint(1) default NULL,
  `detection_done` tinyint(1) default NULL,
  PRIMARY KEY  (`id`),
  KEY `doc_id` (`doc_id`),
  KEY `user_id` (`user_id`),
  KEY `pat_id` (`pat_id`),
  KEY `visite_type_code` (`visite_type_code`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `visits`
--

LOCK TABLES `visits` WRITE;
/*!40000 ALTER TABLE `visits` DISABLE KEYS */;
INSERT  IGNORE INTO `visits` (`id`, `pat_id`, `doc_id`, `user_id`, `date_visit`, `visite_type_code`, `isopen`, `detection_done`) VALUES (4,'P_106','E_102','user_101','2017-09-06',2,0,0),(6,'P_107','E_102','user_101','2017-09-06',2,0,0);
/*!40000 ALTER TABLE `visits` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'clinic'
--
/*!50003 DROP PROCEDURE IF EXISTS `clinic_info` */;
--
-- WARNING: old server version. The following dump may be incomplete.
--
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `clinic_info`(
    in sname varchar(50),
    in sdoctor varchar(50),
    in saddress varchar(50),
    in stelephone varchar(14),
    in smobile varchar(14),
    in sfax varchar(50),
    in semail varchar(50),
    in swebsite varchar(50),
    in sfb_page varchar(100),
    in stype varchar(20)

)
BEGIN
if(stype='add')
then
insert into clinic_info (name,doctor,address,telephone,mobile,fax,email,website,fb_page)value(sname,sdoctor,saddress,stelephone,smobile,sfax,semail,swebsite,sfb_page);
elseif(stype='update')
then 
update clinic_info set name=sname,doctor=sdoctor,address=saddress,telephone=stelephone,mobile=smobile,fax=sfax,email=semail,website=swebsite,fb_page=sfb_page where id=1;
end if;

end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_clinic_info` */;
--
-- WARNING: old server version. The following dump may be incomplete.
--
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_clinic_info`()
BEGIN
select * from clinic_info;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_add` */;
--
-- WARNING: old server version. The following dump may be incomplete.
--
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_add`(

    in stype varchar(20),
	in sid varchar(20),
    in sname varchar(50),
    in sgender varchar(10),
    in sbirth_date date,
    in sreg_date date,
    in sstatus varchar(10),
    in saddress varchar(100),
    in semail varchar(50),
    in sphone1 varchar(14),
    in sphone2 varchar(14),
    in sposition varchar(10),
    in snat_id varchar(14))
BEGIN
if (stype='supplier')
then
INSERT INTO `clinic`.`supplier`
(`supplier_id`,
`supplier_name`,
`supplier_contact_no`,
supplier_contact_no2,supplier_email,
`supplier_address`)
VALUES(sid,snamem,sphone1,sphone2,semail,saddress);
elseif(stype='patient')
then
INSERT INTO `clinic`.`patient`
(`patient_id`,
`patient_name`,
`patient_gender`,
`patient_birth_date`,
`patient_register_date`,
`patient_status`,
`patient_address`,
patient_email,
`patient_contact_no`,
`patient_contact_no2`)
VALUES
(sid,sname,sgender,sbirth_date,sreg_date,sstatus,saddress,semail,sphone1,sphone2);
elseif(stype='staff')
then
INSERT INTO `clinic`.`staff`
(`staff_id`,
`staff_name`,
`staff_gender`,
`staff_birth_date`,
`staff_date_of_employee`,
`staff_status`,
`staff_address`,
`staff_email`,
`staff_contact_no`,
`staff_contact_no2`,
`staff_position`,
`staff_nat_id`,
`transformers_id`
)
VALUES
(sid,sname,sgender,sbirth_date,sreg_date,sstatus,saddress,semail,sphone1,sphone2,sposition,snat_id,transformers_id);

end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete` */;
--
-- WARNING: old server version. The following dump may be incomplete.
--
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete`(
in stype varchar(20),
in sid varchar(20)
)
BEGIN
if(stype='patient')
then
delete from patient where patient_id=sid;
elseif(stype='supplier')
then
delete from supplier where supplier_id=sid;
elseif(stype='staff')
then
delete from staff where staff_id=sid;

end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_select` */;
--
-- WARNING: old server version. The following dump may be incomplete.
--
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select`(in p_type varchar(20))
BEGIN
if(p_type='patient')
then
select * from patient;

elseif(p_type='staff')
then 
select * from staff;

elseif(p_type='v_type')
then 
select * from visit_type;

elseif(p_type='supplier')
then 
select * from supplier;

elseif(p_type='inventory')
then 
select * from inventory;

end if;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-06 19:29:35
