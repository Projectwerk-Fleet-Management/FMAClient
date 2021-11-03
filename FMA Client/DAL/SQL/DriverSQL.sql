CREATE TABLE `fmadatabase`.`drivers` (
  `driverId` INT NOT NULL AUTO_INCREMENT,
  `firstName` VARCHAR(255) NOT NULL,
  `lastName` VARCHAR(255) NOT NULL,
  `dateOfBirth` DATE NOT NULL,
  `nationalIdentificationNumber` INT NOT NULL,
  `licenses` VARCHAR(255) NULL,
  PRIMARY KEY (`driverId`),
  UNIQUE INDEX `nationalIdentificationNumber_UNIQUE` (`nationalIdentificationNumber` ASC) VISIBLE,
  CONSTRAINT `addressId`
    FOREIGN KEY (`driverId`)
    REFERENCES `fmadatabase`.`addresses` (`addressId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `carId`
    FOREIGN KEY (`driverId`)
    REFERENCES `fmadatabase`.`cars` (`carId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fuelcardId`
    FOREIGN KEY (`driverId`)
    REFERENCES `fmadatabase`.`fuelcards` (`fuelcardId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);