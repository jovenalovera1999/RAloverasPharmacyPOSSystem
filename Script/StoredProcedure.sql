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