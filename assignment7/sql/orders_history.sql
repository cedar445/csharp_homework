DROP DATABASE IF EXISTS `OrderData`;
CREATE DATABASE  `OrderData`;
USE OrderData;

DROP TABLE IF EXISTS `Customer`;
CREATE TABLE `Customer`(
	`CustomerId` int(11) AUTO_INCREMENT,
	`CustomerName` varchar(25) DEFAULT NULL,
	PRIMARY KEY (`CustomerId`)
)ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
    

DROP TABLE IF EXISTS `Orders`;
CREATE TABLE `Orders` (
	`OrderId` int(11) AUTO_INCREMENT,
	`CustomerId` int(11) NOT NULL,
	`CreateTime` varchar(25) DEFAULT NULL,
	PRIMARY KEY (`OrderId`),
	FOREIGN KEY (`CustomerId`) REFERENCES `Customer`(`CustomerId`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

DROP TABLE IF EXISTS `Good`;
CREATE TABLE `Good`(
	`GoodId` int(11) AUTO_INCREMENT,
	`GoodName` varchar(25) DEFAULT NULL,
	`GoodPrice` float(53) DEFAULT NULL,
    PRIMARY KEY (`GoodId`)
)ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

DROP TABLE IF EXISTS `Details`;
CREATE TABLE `Details`(
	`DetailsId` int(11) AUTO_INCREMENT,
	`GoodId` int(11) NOT NULL,
	`UnitPrice` float(53) DEFAULT NULL,
	`Quantity` int(11) DEFAULT NULL,
	PRIMARY KEY (`DetailsId`),
	FOREIGN KEY (`GoodId`) REFERENCES `Good`(`GoodId`)
)ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

DROP TABLE IF EXISTS `OrderToDetails`;
CREATE TABLE `OrderToDetails` (
    `OrderId` INT(11) NOT NULL,
    `DetailsId` INT(11) NOT NULL,
    PRIMARY KEY (`OrderId` , `DetailsId`),
    FOREIGN KEY (`OrderId`)
        REFERENCES `orders` (`OrderId`),
    FOREIGN KEY (`DetailsId`)
        REFERENCES `Details` (`DetailsId`)
)  ENGINE=INNODB AUTO_INCREMENT=26 DEFAULT CHARSET=UTF8;