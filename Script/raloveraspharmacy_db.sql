CREATE TABLE user_levels (
	userLevelId BIGINT NOT NULL AUTO_INCREMENT,
	userLevel VARCHAR(100) NOT NULL,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(userLevelId)
);

INSERT INTO
	user_levels(userLevel)
VALUES
	("ADMIN"),
	("OWNER"),
	("EMPLOYEE");

CREATE TABLE users (
	userId BIGINT NOT NULL AUTO_INCREMENT,
	profilePicture BLOB DEFAULT NULL,
	firstName VARCHAR(100) NOT NULL,
	middleName VARCHAR(100) DEFAULT NULL,
	lastName VARCHAR(100) NOT NULL,
	`address` VARCHAR(100) NOT NULL,
	contactNumber VARCHAR(100) DEFAULT NULL,
	email VARCHAR(100) DEFAULT NULL,
	username VARBINARY(255) NOT NULL,
	`password` VARBINARY(255) NOT NULL DEFAULT AES_ENCRYPT("user123", "J.v3n!j.$hu4c.@l0ver4!#@"),
	userLevelId BIGINT NOT NULL,
	isDeleted TINYINT(1) NOT NULL DEFAULT 0,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(userId),
	FOREIGN KEY(userLevelId) REFERENCES user_levels(userLevelId) ON UPDATE CASCADE ON DELETE CASCADE
);

INSERT INTO
	users(firstName, middleName, lastName, `address`, contactNumber, email, username, `password`, userLevelId)
VALUES
	("JOVEN JOSHUA", "CELIZ", "ALOVERA", "ROXAS CITY", "09123456789", "joven@email.com", AES_ENCRYPT("ADMIN", "J.v3n!j.$hu4c.@l0ver4!#@"), AES_ENCRYPT("admin", "J.v3n!j.$hu4c.@l0ver4!#@"), 1);

CREATE TABLE descriptions (
	descriptionId BIGINT NOT NULL AUTO_INCREMENT,
	`description` TEXT NOT NULL,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(descriptionId)
);

CREATE TABLE packaging_units (
	packagingUnitId BIGINT NOT NULL AUTO_INCREMENT,
	packagingUnitName VARCHAR(100) NOT NULL,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(packagingUnitId)
);

CREATE TABLE generics (
	genericId BIGINT NOT NULL AUTO_INCREMENT,
	genericName VARCHAR(100) NOT NULL,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(genericId)
);

CREATE TABLE discounts (
	discountId BIGINT NOT NULL AUTO_INCREMENT,
	discount DOUBLE NOT NULL,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(discountId)
);

CREATE TABLE suppliers (
	supplierId BIGINT NOT NULL AUTO_INCREMENT,
	supplier VARCHAR(100) NOT NULL,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(supplierId)
);

CREATE TABLE products (
	productId BIGINT NOT NULL AUTO_INCREMENT,
	`code` VARCHAR(100) NOT NULL,
	descriptionId BIGINT NOT NULL,
	packagingUnitId BIGINT NOT NULL,
	quantity INT NOT NULL,
	price DOUBLE NOT NULL,
	discountId BIGINT NOT NULL,
	discounted DOUBLE NOT NULL,
	genericId BIGINT NOT NULL,
	supplierId BIGINT NOT NULL,
	priceFromSupplier DOUBLE NOT NULL,
	userId BIGINT NOT NULL,
	isDeleted TINYINT(1) NOT NULL DEFAULT 0,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(productId),
	FOREIGN KEY(descriptionId) REFERENCES descriptions(descriptionId),
	FOREIGN KEY(packagingUnitId) REFERENCES packaging_units(packagingUnitId) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(discountId) REFERENCES discounts(discountId) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(genericId) REFERENCES generics(genericId) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(supplierId) REFERENCES suppliers(supplierId) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(userId) REFERENCES users(userId) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE return_products (
	returnProductId BIGINT NOT NULL AUTO_INCREMENT,
	productId BIGINT NOT NULL,
	quantity INT NOT NULL,
	amountReturned DOUBLE NOT NULL,
	isDeleted TINYINT(1) NOT NULL DEFAULT 0,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(returnProductId),
	FOREIGN KEY(productId) REFERENCES products(productId) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE transactions (
	transactionId BIGINT NOT NULL AUTO_INCREMENT,
	transactionNo VARCHAR(100) NOT NULL,
	totalAmountToPay DOUBLE NOT NULL,
	discountId BIGINT NOT NULL,
	discounted DOUBLE NOT NULL,
	amount DOUBLE NOT NULL,
	`change` DOUBLE NOT NULL,
	userId BIGINT NOT NULL,
	isDeleted TINYINT(1) NOT NULL DEFAULT 0,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(transactionId),
	FOREIGN KEY(discountId) REFERENCES discounts(discountId) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(userId) REFERENCES users(userId) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE user_for_payments (
	userForPaymentId BIGINT NOT NULL AUTO_INCREMENT,
	userId BIGINT NOT NULL,
	discountId BIGINT NOT NULL,
	amount DOUBLE NOT NULL,
	isPaid TINYINT(1) NOT NULL DEFAULT 0,
	isCancelled TINYINT(1) NOT NULL DEFAULT 0,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(userForPaymentId),
	FOREIGN KEY(userId) REFERENCES users(userId) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(discountId) REFERENCES discounts(discountId) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE carts (
	cartId BIGINT NOT NULL AUTO_INCREMENT,
	userForPaymentId BIGINT NOT NULL,
	productId BIGINT NOT NULL,
	transactionId BIGINT DEFAULT NULL,
	quantity INT NOT NULL,
	subTotal DOUBLE NOT NULL,
	dateCreated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	dateUpdated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY(cartId),
	FOREIGN KEY(userForPaymentId) REFERENCES user_for_payments(userForPaymentId) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(productId) REFERENCES products(productId) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(transactionId) REFERENCES transactions(transactionId) ON UPDATE CASCADE ON DELETE CASCADE
);