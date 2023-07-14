DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertUser`(pProfilePicture BLOB, pFirstName VARCHAR(45), pMiddleName VARCHAR(45), pLastName VARCHAR(45),
    pAddress VARCHAR(45), pContactNumber VARCHAR(45), pEmail VARCHAR(45), pUsername VARCHAR(45), pPassword VARBINARY(255))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO users(profilePicture, firstName, middleName, lastName, address, contactNumber, email, username, `password`)
		VALUES(pProfilePicture, pFirstName, pMiddleName, pLastName, pAddress, pContactNumber, pEmail, pUsername,
		AES_ENCRYPT(pPassword, "J.v3n!j.$hu4c.@l0ver4!#@"));
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertDescription`(pDescription TEXT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO descriptions(`description`)
		VALUES(pDescription);
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`loginUser`(pUsername VARCHAR(45), pPassword VARBINARY(255))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT userId, profilePicture, firstName, middleName, lastName, address, contactNumber, email, username,
		CAST(AES_DECRYPT(`password`, "J.v3n!j.$hu4c.@l0ver4!#@") AS CHAR)
		FROM users
		WHERE username = pUsername AND CAST(AES_DECRYPT(`password`, "J.v3n!j.$hu4c.@l0ver4!#@") AS CHAR) = pPassword;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`getDescriptionId`(pDescription TEXT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT descriptionId
		FROM descriptions
		WHERE `description` = pDescription;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`getPackagingUnitId`(pPackagingUnitName VARCHAR(45))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT packagingUnitId
		FROM packaging_units
		WHERE packagingUnitName = pPackagingUnitName;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertPackagingUnit`(pPackagingUnitName VARCHAR(45))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO packaging_units(packagingUnitName)
		VALUES(pPackagingUnitName);
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`getGenericId`(pGenericName VARCHAR(45))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT genericId
		FROM generics
		WHERE genericName = pGenericName;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertGeneric`(pGenericName VARCHAR(45))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO generics(genericName)
		VALUES(pGenericName);
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertProduct`(pCode VARCHAR(45), pDescriptionId BIGINT, pPackagingUnitId BIGINT, pQuantity INT, pPrice DOUBLE,
    pDiscount DOUBLE, pDiscounted DOUBLE, pGenericId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO products(`code`, descriptionId, packagingUnitId, quantity, price, discount, discounted, genericId)
		VALUES(pCode, pDescriptionId, pPackagingUnitId, pQuantity, pPrice, pDiscount, pDiscounted, pGenericId);
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`checkCodeIfExist`(pCode VARCHAR(45))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT `code`
		FROM products
		WHERE `code` = pCode;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`loadProducts`()
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT p.productId, p.code, d.description, pu.packagingUnitName, p.quantity, FORMAT(p.price, 2), p.discount, FORMAT(p.discounted, 2), g.genericName, p.dateCreated, p.dateUpdated
		FROM products AS p
		INNER JOIN descriptions AS d ON p.descriptionId = d.descriptionId
		INNER JOIN packaging_units AS pu ON p.packagingUnitId = pu.packagingUnitId
		INNER JOIN generics AS g ON p.genericId = g.genericId
		WHERE isDeleted = 0
		ORDER BY d.description ASC;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`loadUsers`()
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT userId, CONCAT(lastName, ', ', firstName, ' ', LEFT(middleName, 1)), address, contactNumber, email, dateCreated, dateUpdated
		FROM users
		WHERE isDeleted = 0
		ORDER BY lastName AND firstName AND lastName ASC;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`getProduct`(pProductId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT p.productId, p.code, d.description, pu.packagingUnitName, p.quantity, p.price, p.discount, p.discounted, g.genericName
		FROM products AS p
		INNER JOIN descriptions AS d ON p.descriptionId = d.descriptionId
		INNER JOIN packaging_units AS pu ON p.packagingUnitId = pu.packagingUnitId
		INNER JOIN generics AS g ON p.genericId = g.genericId
		WHERE p.productId = pProductId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`updateProduct`(pProductId BIGINT, pDescriptionId BIGINT, pPackagingUnitId BIGINT, pQuantity INT, pPrice DOUBLE,
    pDiscount DOUBLE, pDiscounted DOUBLE, pGenericId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE products
		SET descriptionId = pDescriptionId, packagingUnitId = pPackagingUnitId, quantity = pQuantity, price = pPrice, discount = pDiscount,
		discounted = pDiscounted, genericId = pGenericId, dateUpdated = CURRENT_TIMESTAMP
		WHERE productId = pProductId;
	END$$

DELIMITER ;