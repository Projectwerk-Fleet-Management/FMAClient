CREATE TABLE `fmadatabase`.`addresses` (
  `addressId` INT NOT NULL AUTO_INCREMENT,
  `street` VARCHAR(255) NOT NULL,
  `housenumber` VARCHAR(10) NOT NULL,
  `addendum` VARCHAR(10) NULL,
  `city` VARCHAR(255) NOT NULL,
  `postalcode` INT NOT NULL,
  PRIMARY KEY (`addressId`));