DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertUser`(pProfilePicture BLOB, pFirstName VARCHAR(100), pMiddleName VARCHAR(100), pLastName VARCHAR(100),
    pAddress VARCHAR(100), pContactNumber VARCHAR(100), pEmail VARCHAR(100), pUsername VARBINARY(255), pUserLevelId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO 
			users(profilePicture, firstName, middleName, lastName, address, contactNumber, email, username, userLevelId)
		VALUES
			(pProfilePicture, pFirstName, pMiddleName, pLastName, pAddress, pContactNumber, pEmail,
			AES_ENCRYPT(pUsername, "J.v3n!j.$hu4c.@l0ver4!#@"), pUserLevelId);
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
    PROCEDURE `raloveraspharmacy_db`.`loginUser`(pUsername VARBINARY(255), pPassword VARBINARY(255))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			u.userId, u.profilePicture, u.firstName, u.middleName, u.lastName, u.address, u.contactNumber, u.email,
			CAST(AES_DECRYPT(u.username, "J.v3n!j.$hu4c.@l0ver4!#@") AS CHAR), CAST(AES_DECRYPT(u.password, "J.v3n!j.$hu4c.@l0ver4!#@") AS CHAR),
			ul.userLevel
		FROM
			users AS u
		INNER JOIN
			user_levels AS ul ON u.userLevelId = ul.userLevelId
		WHERE
			CAST(AES_DECRYPT(u.username, "J.v3n!j.$hu4c.@l0ver4!#@") AS CHAR) = pUsername
			AND CAST(AES_DECRYPT(u.password, "J.v3n!j.$hu4c.@l0ver4!#@") AS CHAR) = pPassword AND u.isDeleted = 0;
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
    PROCEDURE `raloveraspharmacy_db`.`getPackagingUnitId`(pPackagingUnitName VARCHAR(100))
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
    PROCEDURE `raloveraspharmacy_db`.`insertPackagingUnit`(pPackagingUnitName VARCHAR(100))
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
    PROCEDURE `raloveraspharmacy_db`.`getGenericId`(pGenericName VARCHAR(100))
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
    PROCEDURE `raloveraspharmacy_db`.`insertGeneric`(pGenericName VARCHAR(100))
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
    PROCEDURE `raloveraspharmacy_db`.`insertProduct`(pCode VARCHAR(100), pDescriptionId BIGINT, pPackagingUnitId BIGINT, pQuantity INT, pPrice DOUBLE,
    pDiscountId BIGINT, pDiscounted DOUBLE, pGenericId BIGINT, pSupplierId BIGINT, pPriceFromSupplier DOUBLE, pUserId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO
			products(`code`, descriptionId, packagingUnitId, quantity, price, discountId, discounted, genericId, supplierId, priceFromSupplier, userId)
		VALUES
			(pCode, pDescriptionId, pPackagingUnitId, pQuantity, pPrice, pDiscountId, pDiscounted, pGenericId, pSupplierId, pPriceFromSupplier, pUserId);
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`checkCodeIfExist`(pCode VARCHAR(100))
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
		SELECT
			p.productId, p.code, d.description, pu.packagingUnitName, p.quantity, FORMAT(p.price, 2), dis.discount,
			FORMAT(p.discounted, 2), g.genericName, s.supplier, FORMAT(p.priceFromSupplier, 2),
			CASE WHEN u.middleName IS NULL OR u.middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END,
			p.dateCreated, p.dateUpdated
		FROM
			products AS p
		INNER JOIN
			descriptions AS d ON p.descriptionId = d.descriptionId
		INNER JOIN
			packaging_units AS pu ON p.packagingUnitId = pu.packagingUnitId
		INNER JOIN
			discounts AS dis ON p.discountId = dis.discountId
		INNER JOIN
			generics AS g ON p.genericId = g.genericId
		INNER JOIN
			suppliers AS s ON p.supplierId = s.supplierId
		INNER JOIN
			users AS u ON p.userId = u.userId
		WHERE
			p.isDeleted = 0
		ORDER BY
			d.description ASC;
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
		SELECT 
			userId,
			CASE WHEN middleName IS NULL OR middleName = '' THEN CONCAT(lastName, ', ', firstName) ELSE CONCAT(lastName, ', ', firstName, ' ', LEFT(middleName, 1), '.') END,
			`address`, contactNumber, email,
			CAST(AES_DECRYPT(username, "J.v3n!j.$hu4c.@l0ver4!#@") AS CHAR), dateCreated, dateUpdated
		FROM
			users
		WHERE
			isDeleted = 0
		ORDER BY
			lastName ASC;
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
		SELECT
			p.productId, p.code, d.description, pu.packagingUnitName, p.quantity, p.price, dis.discount, p.discounted, g.genericName, s.supplier,
			p.priceFromSupplier
		FROM
			products AS p
		INNER JOIN
			descriptions AS d ON p.descriptionId = d.descriptionId
		INNER JOIN
			packaging_units AS pu ON p.packagingUnitId = pu.packagingUnitId
		INNER JOIN
			discounts AS dis ON p.discountId = dis.discountId
		INNER JOIN
			generics AS g ON p.genericId = g.genericId
		INNER JOIN
			suppliers AS s ON p.supplierId = s.supplierId
		WHERE
			p.productId = pProductId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`updateProduct`(pProductId BIGINT, pDescriptionId BIGINT, pPackagingUnitId BIGINT, pQuantity INT, pPrice DOUBLE,
    pDiscountId BIGINT, pDiscounted DOUBLE, pGenericId BIGINT, pSupplierId BIGINT, pPriceFromSupplier DOUBLE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE
			products
		SET
			descriptionId = pDescriptionId, packagingUnitId = pPackagingUnitId, quantity = pQuantity, price = pPrice, discountId = pDiscountId,
			discounted = pDiscounted, genericId = pGenericId, supplierId = pSupplierId, priceFromSupplier = pPriceFromSupplier
		WHERE
			productId = pProductId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`deleteProduct`(pProductId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE products
		SET isDeleted = 1
		WHERE productId = pProductId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`searchProduct`(pKeyword VARCHAR(100))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			p.productId, p.code, d.description, pu.packagingUnitName, p.quantity, FORMAT(p.price, 2), dis.discount,
			FORMAT(p.discounted, 2), g.genericName, s.supplier, FORMAT(p.priceFromSupplier, 2),
			CASE WHEN u.middleName IS NULL OR u.middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END,
			p.dateCreated, p.dateUpdated
		FROM
			products AS p
		INNER JOIN
			descriptions AS d ON p.descriptionId = d.descriptionId
		INNER JOIN
			packaging_units AS pu ON p.packagingUnitId = pu.packagingUnitId
		INNER JOIN
			discounts AS dis ON p.discountId = dis.discountId
		INNER JOIN
			generics AS g ON p.genericId = g.genericId
		INNER JOIN
			suppliers AS s ON p.supplierId = s.supplierId
		INNER JOIN
			users AS u ON p.userId = u.userId
		WHERE
			p.code LIKE pKeyword AND p.isDeleted = 0 OR d.description LIKE pKeyword AND p.isDeleted = 0
			OR pu.packagingUnitName LIKE pKeyword AND p.isDeleted = 0 OR g.genericName LIKE pKeyword AND p.isDeleted = 0 OR
			s.supplier LIKE pKeyword AND p.isDeleted = 0
		ORDER BY
			d.description ASC;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`resetUserPassword`(pUserId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE users
		SET `password` = AES_ENCRYPT("user123", "J.v3n!j.$hu4c.@l0ver4!#@")
		WHERE userId = pUserId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`deleteUser`(pUserId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE users
		SET isDeleted = 1
		WHERE userId = pUserId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`updateUser`(pUserId BIGINT, pProfilePicture BLOB, pFirstName VARCHAR(100), pMiddleName VARCHAR(100),
    pLastName VARCHAR(100), pAddress VARCHAR(100), pContactNumber VARCHAR(100), pEmail VARCHAR(100), pUsername VARBINARY(255),
    pPassword VARBINARY(255))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE
			users
		SET
			profilePicture = pProfilePicture, firstName = pFirstName, middleName = pMiddleName, lastName = pLastName,
			`address` = pAddress, contactNumber = pContactNumber, email = pEmail, username = AES_ENCRYPT(pUsername, "J.v3n!j.$hu4c.@l0ver4!#@"),
			`password` = AES_ENCRYPT(pPassword, "J.v3n!j.$hu4c.@l0ver4!#@")
		WHERE
			userId = pUserId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`checkUsernameIfExist`(pUsername VARBINARY(255))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT CAST(AES_DECRYPT(username, "J.v3n!j.$hu4c.@l0ver4!#@") AS CHAR)
		FROM users
		WHERE CAST(AES_DECRYPT(username, "J.v3n!j.$hu4c.@l0ver4!#@") AS CHAR) = pUsername
		AND isDeleted = 0;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`proceedUpdateUserWithExistingUsername`(pUserId BIGINT, pUsername VARCHAR(100))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT userId, CAST(AES_DECRYPT(username, "J.v3n!j.$hu4c.@l0ver4!#@") AS CHAR)
		FROM users
		WHERE userId = pUserId
		AND CAST(AES_DECRYPT(username, "J.v3n!j.$hu4c.@l0ver4!#@") AS CHAR) = pUsername
		AND isDeleted = 0;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`getDiscountId`(pDiscount DOUBLE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT discountId
		FROM discounts
		WHERE discount = pDiscount;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertDiscount`(pDiscount DOUBLE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO discounts(discount)
		VALUES(pDiscount);
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertUserForPayment`(pUserId BIGINT, pDiscountId BIGINT, pAmount DOUBLE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO
			user_for_payments(userId, discountId, amount)
		VALUES
			(pUserId, pDiscountId, pAmount);
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`getUserForPaymentIdDesc`()
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT userForPaymentId
		FROM user_for_payments
		ORDER BY userForPaymentId DESC LIMIT 1;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertCart`(pUserForPaymentId BIGINT, pProductId BIGINT, pQuantity INT, pSubTotal DOUBLE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO carts(userForPaymentId, productId, quantity, subTotal)
		VALUES(pUserForPaymentId, pProductId, pQuantity, pSubTotal);
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`loadCartsForPaymentWithFilter`(pUserForPaymentId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT c.cartId, c.productId, d.description,
		CASE WHEN dis.discount = 0 THEN FORMAT(p.price, 2) ELSE FORMAT(p.discounted, 2) END,
		c.quantity, FORMAT(c.subTotal, 2)
		FROM carts AS c
		INNER JOIN products AS p ON c.productId = p.productId
		INNER JOIN descriptions AS d ON p.descriptionId = d.descriptionId
		INNER JOIN discounts AS dis ON p.discountId = dis.discountId
		WHERE c.userForPaymentId = pUserForPaymentId
		ORDER BY d.description ASC;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`loadCartsForPaymentWithoutFilter`()
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT c.cartId, c.productId, d.description, p.price, c.quantity, FORMAT(c.subTotal, 2)
		FROM carts AS c
		INNER JOIN products AS p ON c.productId = p.productId
		INNER JOIN descriptions AS d ON p.descriptionId = d.descriptionId
		LIMIT 0;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`loadUsersForPayment`()
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			ufp.userForPaymentId,
			CASE WHEN u.middleName IS NULL OR u.middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END,
			FORMAT(d.discount, 2), FORMAT(ufp.amount, 2)
		FROM
			user_for_payments AS ufp
		INNER JOIN
			users AS u ON ufp.userId = u.userId
		INNER JOIN
			discounts AS d ON ufp.discountId = d.discountId
		WHERE
			ufp.isPaid = 0 AND ufp.isCancelled = 0
		ORDER BY
			ufp.userForPaymentId ASC;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertTransaction`(pTransactionNo VARCHAR(100), pTotalAmountToPay DOUBLE, pDiscountId BIGINT, pDiscounted DOUBLE,
    pAmount DOUBLE, pChange DOUBLE, pUserId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO
			transactions(transactionNo, totalAmountToPay, discountId, discounted, amount, `change`, userId)
		VALUES
			(pTransactionNo, pTotalAmountToPay, pDiscountId, pDiscounted, pAmount, pChange, pUserId);
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`getTransactionIdDesc`()
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT transactionId
		FROM transactions
		ORDER BY transactionId DESC LIMIT 1;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertTransactionIdToCarts`(pCartId BIGINT, pTransactionId BIGINT, pUserForPaymentId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE carts
		SET transactionId = pTransactionId
		WHERE cartId = pCartId;
		
		UPDATE user_for_payments
		SET isPaid = 1
		WHERE userForPaymentId = pUserForPaymentId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`deductProductQuantity`(pProductId BIGINT, pQuantity INT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE products AS p
		SET p.quantity = p.quantity - pQuantity
		WHERE p.productId = pProductId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`loadSalesWithDateRange`(pFrom DATE, pTo DATE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			t.transactionId, t.transactionNo, FORMAT(t.totalAmountToPay, 2), FORMAT(d.discount, 2), FORMAT(t.discounted, 2),
			FORMAT(t.amount, 2), FORMAT(t.change, 2),
			CASE WHEN middleName IS NULL OR middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END,
			t.dateCreated
		FROM
			transactions AS t
		INNER JOIN
			discounts AS d ON t.discountId = d.discountId
		INNER JOIN
			users AS u ON t.userId = u.userId
		WHERE
			t.dateCreated BETWEEN pFrom AND pTo AND t.isDeleted = 0 OR t.dateCreated BETWEEN pTo AND pFrom AND t.isDeleted = 0
		ORDER BY
			t.transactionId DESC;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`loadSalesWithoutDateRange`()
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			t.transactionId, t.transactionNo, FORMAT(t.totalAmountToPay, 2), FORMAT(d.discount, 2), FORMAT(t.discounted, 2),
			FORMAT(t.amount, 2), FORMAT(t.change, 2),
			CASE WHEN middleName IS NULL OR middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END,
			t.dateCreated
		FROM
			transactions AS t
		INNER JOIN
			discounts AS d ON t.discountId = d.discountId
		INNER JOIN
			users AS u ON t.userId = u.userId
		WHERE
			t.isDeleted = 0
		ORDER BY
			t.transactionId DESC;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`sumTotalSalesWithDateRange`(pFrom DATE, pTo DATE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			SUM(CASE WHEN discounted = 0 THEN totalAmountToPay ELSE discounted END)
		FROM
			transactions
		WHERE
			dateCreated BETWEEN pFrom AND pTo AND isDeleted = 0 OR dateCreated BETWEEN pTo AND pFrom AND isDeleted = 0;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`sumTotalSalesWithoutDateRange`()
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			SUM(CASE WHEN discounted = 0 THEN totalAmountToPay ELSE discounted END)
		FROM
			transactions
		WHERE
			isDeleted = 0;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`countTransactionsWithDateRange`(pFrom DATE, pTo DATE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			COUNT(transactionId)
		FROM
			transactions
		WHERE
			dateCreated BETWEEN pFrom AND pTo AND isDeleted = 0 OR dateCreated BETWEEN pTo AND pFrom AND isDeleted = 0;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`countTransactionsWithoutDateRange`()
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			COUNT(transactionId)
		FROM
			transactions
		WHERE
			isDeleted = 0;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`loadSalesCart`(pTransactionId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			c.cartId, c.productId, d.description,
			CASE WHEN dis.discount = 0 THEN FORMAT(p.price, 2) ELSE FORMAT(p.discounted, 2) END,
			c.quantity, FORMAT(c.subTotal, 2),
			CASE WHEN u.middleName IS NULL OR u.middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END,
			c.dateCreated
		FROM
			carts AS c
		INNER JOIN
			products AS p ON c.productId = p.productId
		INNER JOIN
			descriptions AS d ON p.descriptionId = d.descriptionId
		INNER JOIN
			discounts AS dis ON p.discountId = dis.discountId
		INNER JOIN
			user_for_payments AS ufp ON c.userForPaymentId = ufp.userForPaymentId
		INNER JOIN
			users AS u ON ufp.userId = u.userId
		WHERE
			c.transactionId = pTransactionId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`getTransactionId`(pTransactionId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			transactionId
		FROM
			transactions
		WHERE
			transactionId = pTransactionId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`checkTransactionNoIfExist`(pTransactionNo VARCHAR(100))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			transactionNo
		FROM
			transactions
		WHERE
			transactionNo = pTransactionNo;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`loadUserLevels`()
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			userLevel
		FROM
			user_levels;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`getUserLevel`(pUserLevel VARCHAR(100))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			userLevelId
		FROM
			user_levels
		WHERE
			userLevel = pUserLevel;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`updateDiscountIdAfterPaymentTransaction`(pUserForPaymentId BIGINT, pDiscountId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE
			user_for_payments
		SET
			discountId = pDiscountId
		WHERE
			userForPaymentId = pUserForPaymentId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertSupplier`(pSupplier VARCHAR(100))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO
			suppliers(supplier)
		VALUES
			(pSupplier);
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`getSupplierId`(pSupplier VARCHAR(100))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			supplierId
		FROM
			suppliers
		WHERE
			supplier = pSupplier;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`updateDiscountIdAndAmountAfterPaymentTransaction`(pUserForPaymentId BIGINT, pDiscountId BIGINT, pAmount DOUBLE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE
			user_for_payments
		SET
			discountId = pDiscountId, amount = pAmount
		WHERE
			userForPaymentId = pUserForPaymentId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`updateProductQuantityWhenCancelled`(pProductId BIGINT, pQuantity INT, pCartId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE
			products AS p
		SET
			p.quantity = p.quantity + pQuantity
		WHERE
			p.productId = pProductId;
			
		UPDATE
			carts AS c
		SET
			c.quantity = 0
		WHERE
			c.cartId = pCartId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`updateUserForPaymentToCancelled`(pUserForPaymentId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE
			user_for_payments AS ufp
		SET
			ufp.isCancelled = 1
		WHERE
			ufp.userForPaymentId = pUserForPaymentId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`loadReturnedProducts`()
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			rp.returnProductId, rp.productId, p.code, d.description, pu.packagingUnitName, rp.quantity, FORMAT(rp.amountReturned, 2), rp.dateCreated, rp.dateUpdated
		FROM
			return_products AS rp
		INNER JOIN
			products AS p ON rp.productId = p.productId
		INNER JOIN
			descriptions AS d ON p.descriptionId = d.descriptionId
		INNER JOIN
			packaging_units AS pu ON p.packagingUnitId = pu.packagingUnitId
		WHERE
			rp.isDeleted = 0
		ORDER BY
			d.description ASC;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`insertReturnedProduct`(pProductId BIGINT, pQuantity INT, pAmountReturned DOUBLE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		INSERT INTO
			return_products(productId, quantity, amountReturned)
		VALUES
			(pProductId, pQuantity, pAmountReturned);
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`updateProductQuantityWhenReturnedProduct`(pProductId BIGINT, pQuantity INT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE
			products AS p
		SET
			p.quantity = p.quantity + pQuantity
		WHERE
			p.productId = pProductId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`deleteReturnedProduct`(pReturnProductId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE
			return_products AS rp
		SET
			rp.isDeleted = 1
		WHERE
			rp.returnProductId = pReturnProductId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`getReturnedProduct`(pReturnProductId BIGINT)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			rp.returnProductId, rp.productId, d.description, rp.quantity, rp.amountReturned
		FROM
			return_products AS rp
		INNER JOIN
			products AS p ON rp.productId = p.productId
		INNER JOIN
			descriptions AS d ON p.descriptionId = d.descriptionId
		WHERE
			rp.returnProductId = pReturnProductId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`updateReturnedProduct`(ppProductId BIGINT, ppQuantity INT, pReturnProductId BIGINT, pProductId BIGINT, pQuantity INT, pAmountReturned DOUBLE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		UPDATE
			products AS p
		SET
			p.quantity = p.quantity - ppQuantity
		WHERE
			p.productId = ppProductId;

		UPDATE
			products AS p
		SET
			p.quantity = p.quantity + pQuantity
		WHERE
			p.productId = pProductId;
			
		UPDATE
			return_products AS rp
		SET
			rp.productId = pProductId, rp.quantity = pQuantity, rp.amountReturned = pAmountReturned
		WHERE
			rp.returnProductId = pReturnProductId;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`searchReturnedProduct`(pKeyword varchar(100))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			rp.returnProductId, rp.productId, p.code, d.description, pu.packagingUnitName, rp.quantity, FORMAT(rp.amountReturned, 2), rp.dateCreated, rp.dateUpdated
		FROM
			return_products AS rp
		INNER JOIN
			products AS p ON rp.productId = p.productId
		INNER JOIN
			descriptions AS d ON p.descriptionId = d.descriptionId
		INNER JOIN
			packaging_units AS pu ON p.packagingUnitId = pu.packagingUnitId
		WHERE
			p.code LIKE pKeyword AND rp.isDeleted = 0 OR d.description LIKE pKeyword AND rp.isDeleted = 0 OR pu.packagingUnitName LIKE pKeyword
			AND rp.isDeleted = 0 OR rp.quantity LIKE pKeyword AND rp.isDeleted = 0 OR rp.amountReturned LIKE pKeyword AND rp.isDeleted = 0
		ORDER BY
			d.description ASC;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`countItemsReturnedWithDateRange`(pFrom DATE, pTo DATE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			COUNT(returnProductId)
		FROM
			return_products
		WHERE
			dateCreated BETWEEN pFrom AND pTo AND isDeleted = 0 OR dateCreated BETWEEN pTo AND pFrom AND isDeleted = 0;
	END$$

DELIMITER ;

DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `raloveraspharmacy_db`.`sumTotalAmountReturnedWithDateRange`(pFrom DATE, pTo DATE)
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
	BEGIN
		SELECT
			SUM(amountReturned)
		FROM
			return_products
		WHERE
			dateCreated BETWEEN pFrom AND pTo AND isDeleted = 0 OR dateCreated BETWEEN pTo AND pFrom AND isDeleted = 0;
	END$$

DELIMITER ;