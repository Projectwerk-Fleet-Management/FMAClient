CREATE TABLE `fmadatabase`.`cars` (
    `carId` INT NOT NULL AUTO_INCREMENT,
  `vin` VARCHAR(17) NOT NULL,
  `make` VARCHAR(255) NOT NULL,
  `model` VARCHAR(255) NOT NULL,
  `licenseplate` VARCHAR(15) NOT NULL,
  `fueltypes` VARCHAR(255) NOT NULL,
  `vehicletype` VARCHAR(255) NOT NULL,
  `colour` VARCHAR(255) NULL,
  `doors` VARCHAR(255) NULL,
  PRIMARY KEY (`carId`),
  UNIQUE INDEX `licenseplate_UNIQUE` (`licenseplate` ASC) VISIBLE,
  UNIQUE INDEX `vin_UNIQUE` (`vin` ASC) VISIBLE);