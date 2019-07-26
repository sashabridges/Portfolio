DROP DATABASE weaving_db;
CREATE DATABASE weaving_db;

USE weaving_db;

CREATE TABLE weaving_items(
		id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
		weaved VARCHAR(50) NOT NULL,
		it_rank VARCHAR(6),
		exp_given INT (15),
		mats VARCHAR(100),
		add_tools VARCHAR (20)
);

INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Braid Braid',	'F', 300, 'Thick Thread Ball × 1, Thin Thread Ball × 1',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Thick Thread Ball', 	'Novice', 100,	'Wool × 5',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Thin Thread Ball', 'Novice',	100,	'Cobweb × 5',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Cheap Leather Strap',	'Novice',	100, 'Cheap Leather × 1',	'Sword');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Common Leather Strap', 	'Novice',	200,	'Common Leather × 1',	'Sword');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Fine Leather Strap', 	'F',	300,	'Fine Leather × 1',	'Sword');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Finest Leather Strap', 	'C',	700,	'Finest Leather × 1',	'Sword');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Tough String', 	'5',	800,	'Thick Thread Ball × 5',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Tough Thread',	'4',	300,	'Thin Thread Ball × 5',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Yarn Key',	'F',	5000,	'Larva Cocoon × 5',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Frost Thread', 	'F',	500,	'Snow Spiders Web × 5',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Cheap Fabric',	'Novice',	300,	'Thick Thread Ball × 5',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Common Fabric',	'F',	300,	'Thick Thread Ball × 5',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Fine Fabric',	'F',	300,	'Thick Thread Ball × 5',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Finest Fabric',	'F',	300,	'Thick Thread Ball × 5',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Cheap Silk',	'Novice',	300,	'Thin Thread Ball × 5',	'Silk Weaving Gloves');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Common Silk',	'F',	300,	'Thin Thread Ball × 5',	'Silk Weaving Gloves');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Fine Silk',	'F',	300,	'Thin Thread Ball × 5',	'Silk Weaving Gloves');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Finest Silk',	'F',	300,	'Thin Thread Ball × 5',	'Silk Weaving Gloves');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Ice Silk',	'9',	1000,	'Frost Thread × 5',	'Silk Weaving Gloves');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Demonic Scale',	'1',	15000,	'Demonic Scale Fragment x 3',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Dragon Scale',	'3',	30000,	'Dragon Scale Fragment × 3',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Robe (F)',	'Novice',	50000,	'Alpaca Fur × 1000',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Robe (M)',	'Novice',	50000,	'Alpaca Fur × 1000',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Fur Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Wool Collection Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Cobweb Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Thin Thread Ball Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Thick Thread Ball Pouch', 	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Cheap Leather Pouch', 	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Common Leather Pouch', 	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Fine Leather Pouch', 	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Finest Leather Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Cheap Fabric Pouch', 'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Common Fabric Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Fine Fabric Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Finest Fabric Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Cheap Silk Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Common Silk Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Fine Silk Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');
INSERT INTO weaving_items (weaved, it_rank, exp_given, mats, add_tools) VALUES ('Alpaca Finest Silk Pouch',	'Novice',	15000,	'Alpaca Fur × 200',	'None');