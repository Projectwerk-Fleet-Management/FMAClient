CREATE TABLE `fmadatabase`.`fuelcards` (
`fuelcardId` INT NOT NULL AUTO_INCREMENT,
  `cardnumber` VARCHAR(255) NOT NULL,
  `expiryDate` DATE NOT NULL,
  `pincode` INT NULL,
  `fueltypes` VARCHAR(255) NULL,
  `isActive` BINARY(1) NULL,
  PRIMARY KEY (`fuelcardId`),
  UNIQUE INDEX `cardnumber_UNIQUE` ( `cardnumber` ASC) VISIBLE);