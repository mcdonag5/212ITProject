-- --------------------------------------------------------
-- Host:                         db212it.czz7ucpwdopn.us-east-1.rds.amazonaws.com
-- Server version:               5.7.22 - Source distribution
-- Server OS:                    Linux
-- HeidiSQL Version:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for HarrisContactDb
CREATE DATABASE IF NOT EXISTS `HarrisContactDb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `HarrisContactDb`;

-- Dumping structure for procedure HarrisContactDb.deleteBusiness
DELIMITER //
CREATE PROCEDURE `deleteBusiness`(IN conID INT)
BEGIN
DELETE FROM tbl_BusinessContacts WHERE ContactID = conID;
END//
DELIMITER ;

-- Dumping structure for procedure HarrisContactDb.deletePersonal
DELIMITER //
CREATE PROCEDURE `deletePersonal`(IN conID INT)
BEGIN
DELETE FROM tbl_PersonalContacts WHERE ContactID = conID;
END//
DELIMITER ;

-- Dumping structure for procedure HarrisContactDb.insertBusiness
DELIMITER //
CREATE PROCEDURE `insertBusiness`(
	IN `conFName` VARCHAR(50),
	IN `conLName` VARCHAR(50),
	IN `conTel` VARCHAR(13),
	IN `conBusinessTel` VARCHAR(13),
	IN `conEmail` VARCHAR(100),
	IN `conAddr1` VARCHAR(50),
	IN `conAddr2` VARCHAR(50),
	IN `conCity` VARCHAR(50),
	IN `conPostcode` VARCHAR(50)
)
BEGIN
INSERT INTO tbl_BusinessContacts (ContactFName,ContactLName,ContactTel,ContactBusinessTel,ContactEmail,ContactAddr1,ContactAddr2,ContactCity,ContactPostcode) 
VALUES (conFName,conLName,conTel,conBusinessTel,conEmail,conAddr1,conAddr2,conCity,conPostcode);
END//
DELIMITER ;

-- Dumping structure for procedure HarrisContactDb.insertPersonal
DELIMITER //
CREATE PROCEDURE `insertPersonal`(
	IN `conFName` VARCHAR(50),
	IN `conLName` VARCHAR(50),
	IN `conTel` VARCHAR(13),
	IN `conHomeTel` VARCHAR(13),
	IN `conEmail` VARCHAR(100),
	IN `conAddr1` VARCHAR(50),
	IN `conAddr2` VARCHAR(50),
	IN `conCity` VARCHAR(50),
	IN `conPostcode` VARCHAR(50)
)
BEGIN
INSERT INTO tbl_PersonalContacts (ContactFName,ContactLName,ContactTel,ContactHomeTel,ContactEmail,ContactAddr1,ContactAddr2,ContactCity,ContactPostcode) 
VALUES (conFName,conLName,conTel,conHomeTel,conEmail,conAddr1,conAddr2,conCity,conPostcode);
END//
DELIMITER ;

-- Dumping structure for procedure HarrisContactDb.selectAllBusiness
DELIMITER //
CREATE PROCEDURE `selectAllBusiness`()
BEGIN
SELECT * FROM tbl_BusinessContacts;
END//
DELIMITER ;

-- Dumping structure for procedure HarrisContactDb.selectAllPersonal
DELIMITER //
CREATE PROCEDURE `selectAllPersonal`()
BEGIN
SELECT * FROM tbl_PersonalContacts;
END//
DELIMITER ;

-- Dumping structure for table HarrisContactDb.tbl_BusinessContacts
CREATE TABLE IF NOT EXISTS `tbl_BusinessContacts` (
  `ContactID` int(11) NOT NULL AUTO_INCREMENT,
  `ContactFName` varchar(50) NOT NULL,
  `ContactLName` varchar(50) NOT NULL,
  `ContactTel` varchar(13) NOT NULL,
  `ContactBusinessTel` varchar(13) NOT NULL,
  `ContactEmail` varchar(100) NOT NULL,
  `ContactAddr1` varchar(50) NOT NULL,
  `ContactAddr2` varchar(50) NOT NULL,
  `ContactCity` varchar(50) NOT NULL,
  `ContactPostcode` varchar(50) NOT NULL,
  PRIMARY KEY (`ContactID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Dumping data for table HarrisContactDb.tbl_BusinessContacts: ~0 rows (approximately)
/*!40000 ALTER TABLE `tbl_BusinessContacts` DISABLE KEYS */;
INSERT INTO `tbl_BusinessContacts` (`ContactID`, `ContactFName`, `ContactLName`, `ContactTel`, `ContactBusinessTel`, `ContactEmail`, `ContactAddr1`, `ContactAddr2`, `ContactCity`, `ContactPostcode`) VALUES
	(1, 'dan', 'foud', '123', '123456', 'email@mail.e', '34 fr', 'a', 'Mancster', 'MA7 N90');
/*!40000 ALTER TABLE `tbl_BusinessContacts` ENABLE KEYS */;

-- Dumping structure for table HarrisContactDb.tbl_PersonalContacts
CREATE TABLE IF NOT EXISTS `tbl_PersonalContacts` (
  `ContactID` int(11) NOT NULL AUTO_INCREMENT,
  `ContactFName` varchar(50) NOT NULL,
  `ContactLName` varchar(50) NOT NULL,
  `ContactTel` varchar(13) NOT NULL,
  `ContactHomeTel` varchar(13) NOT NULL,
  `ContactEmail` varchar(100) NOT NULL,
  `ContactAddr1` varchar(50) NOT NULL,
  `ContactAddr2` varchar(50) NOT NULL,
  `ContactCity` varchar(50) NOT NULL,
  `ContactPostcode` varchar(50) NOT NULL,
  PRIMARY KEY (`ContactID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Dumping data for table HarrisContactDb.tbl_PersonalContacts: ~0 rows (approximately)
/*!40000 ALTER TABLE `tbl_PersonalContacts` DISABLE KEYS */;
INSERT INTO `tbl_PersonalContacts` (`ContactID`, `ContactFName`, `ContactLName`, `ContactTel`, `ContactHomeTel`, `ContactEmail`, `ContactAddr1`, `ContactAddr2`, `ContactCity`, `ContactPostcode`) VALUES
	(2, 'Ross', 'Josh', '01748569847', '01788458741', 'e@mail.lll', '14 Road place', 'jhdddd', 'Rug', 'DJ4 78K'),
	(8, '1', '4', '7', '4', 'a', '2', '5', '6', '5'),
	(9, 'asd', 'asd', 'asdd', 'sd', 'aas', 'dss', 'ds', 'as', 'sss');
/*!40000 ALTER TABLE `tbl_PersonalContacts` ENABLE KEYS */;

-- Dumping structure for procedure HarrisContactDb.updateBusiness
DELIMITER //
CREATE PROCEDURE `updateBusiness`(IN conID INT, conFName VARCHAR(50), conLName VARCHAR(50), conTel VARCHAR(13), conBusTel VARCHAR(13), conEmail VARCHAR(100), conAddr1 VARCHAR(50), conAddr2 VARCHAR(50), conCity VARCHAR(50), conPostcode VARCHAR(50))
BEGIN
UPDATE tbl_BusinessContacts SET ContactFName = conFName,ContactLName = conLName,ContactTel = conTel,ContactBusinessTel = conBusTel,ContactEmail = conEmail,ContactAddr1 = conAddr1,ContactAddr2 = conAddr2,ContactCity = conCity,ContactPostcode = conPostcode
WHERE ContactID = conID;
END//
DELIMITER ;

-- Dumping structure for procedure HarrisContactDb.updatePersonal
DELIMITER //
CREATE PROCEDURE `updatePersonal`(IN conID INT, conFName VARCHAR(50), conLName VARCHAR(50), conTel VARCHAR(13), conHomeTel VARCHAR(13), conEmail VARCHAR(100), conAddr1 VARCHAR(50), conAddr2 VARCHAR(50), conCity VARCHAR(50), conPostcode VARCHAR(50))
BEGIN
UPDATE tbl_PersonalContacts SET ContactFName = conFName,ContactLName = conLName,ContactTel = conTel,ContactHomeTel = conHomeTel,ContactEmail = conEmail,ContactAddr1 = conAddr1,ContactAddr2 = conAddr2,ContactCity = conCity,ContactPostcode = conPostcode
WHERE ContactID = conID;
END//
DELIMITER ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
