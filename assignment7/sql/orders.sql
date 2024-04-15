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
	`OrdersId` int(11) AUTO_INCREMENT,
	`CustomerId` int(11) NOT NULL,
	`CreateTime` varchar(25) DEFAULT NULL,
	PRIMARY KEY (`OrdersId`),
	FOREIGN KEY (`CustomerId`) REFERENCES `Customer`(`CustomerId`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

DROP TABLE IF EXISTS `Goods`;
CREATE TABLE `Goods`(
	`GoodsId` int(11) NOT NULL,
    `DetailsId` int(11) NOT NULL,
    `OrdersId` int(11) NOT NULL,
	`GoodName` varchar(25) DEFAULT NULL,
	`GoodPrice` float(53) DEFAULT NULL,
    PRIMARY KEY (`GoodsId`,`DetailsId`,`OrdersId`)
)ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

DROP TABLE IF EXISTS `Details`;
CREATE TABLE `Details`(
	`DetailsId` int(11) NOT NULL,
    `OrdersId` int(11) NOT NULL,
	`Quantity` int(11) DEFAULT NULL,
	PRIMARY KEY (`DetailsId`,`OrdersId`),
    FOREIGN KEY (`OrdersId`) REFERENCES `Orders`(`OrdersId`)
)ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*
DROP TABLE IF EXISTS `OrderToDetails`;
CREATE TABLE `OrderToDetails` (
    `OrderId` INT(11) NOT NULL,
    `DetailsId` INT(11) NOT NULL,
    PRIMARY KEY (`OrdersId` , `DetailsId`),
    FOREIGN KEY (`OrdersId`)
        REFERENCES `orders` (`OrdersId`),
    FOREIGN KEY (`DetailsId`)
        REFERENCES `Details` (`DetailsId`)
)ENGINE=INNODB AUTO_INCREMENT=26 DEFAULT CHARSET=UTF8;
*/
insert into `Customer` values(1,'li'),(2,'zhang');
insert into `Orders` values(1,1,date_format(now(),'%Y/%m/%d %H:%i:%s')),(2,2,date_format(now(),'%Y/%m/%d %H:%i:%s'));
insert into `Details` values(1,1,10),(1,2,61),(2,2,10);
insert into `Goods` values(1,1,1,'apple',100.0),(1,1,2,'egg',50.0),(2,2,2,'milk',200.0);

