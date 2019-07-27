DROP DATABASE carpentry_db;
CREATE DATABASE carpentry_db;

USE carpentry_db;

CREATE TABLE carpentry_items(
		id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
		carpentry VARCHAR(50) NOT NULL,
		prod_rank VARCHAR(6),
		exp_on_creation INT(10),
		mats_rq VARCHAR (200)
);

INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Average Firewood',	'Novice',	300,	'Firewood × 3');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Fine Firewood',	'C',	800,	'Average Firewood × 3');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Finest Firewood',		'9',	1600,	'Fine Firewood × 3');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Enhanced Firewood',	'9',	1600,	'Finest Firewood × 2, Ancient Golden Crystal × 20');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Special Firewood',	'?',	1600,	'Finest Firewood × 1, Purified Enhancer x 1');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Short Bow',		'9',	1700,	'Fine Firewood × 2, Thick Thread Ball × 2');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Elven Short Bow',		'8',	2600,	'Fine Firewood × 3, Thick Thread Ball × 3, Large Nail × 3');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Long Bow',		'7',	3500,	'Fine Firewood × 5, Thick Thread Ball × 3, Cheap Leather Strap × 1');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Composite Bow',	'6',	5000,	'Fine Firewood × 8, Thin Thread Ball × 2, Thick Thread Ball × 2');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Guardian Bow',	'5',	4300,	'Fine Firewood × 4, Finest Firewood × 1, Tough String × 2');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Elven Long Bow',	'4',	3300,	'Fine Firewood × 3, Finest Firewood × 2, Tough String × 1, Iron Ingot × 2');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Leather Long Bow',		'3',	4000,	'Fine Firewood × 5, Finest Firewood × 3, Thick Thread Ball × 3, Fine Leather × 1');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Crossbow',	'2',	3000,	'Finest Firewood × 6, Tough String × 1, Large Nail × 10, Common Leather × 1');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Arbalest',	'2',	3200,	'Finest Firewood × 4, Radiant String × 1, Large Nail × 10, Common Leather × 1');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Highlander Long Bow',		'1',	4500,	'Finest Firewood × 10, Radiant String × 5, Large Nail × 10, Finest Leather × 1');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Demonic Wood Board	',	'1',	30000,	'Demonic Firewood × 3');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Demonic Infinite Bow',	'1',	100000,	'Demonic Wood Board × 20, Demonic Eye × 2, Demonic Blade × 2, Demonic Scale × 5, Demonic Ingot × 5');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Demonic Gloomy Sunday',	'1',	100000,	'Demonic Eye × 1, Demonic Blade × 1, Demonic Scale × 10, Demonic Ingot × 10, Demonic Wood Board × 10');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Celtic Crossbow',		'1',	5000,	'Finest Firewood x 4, Tough String x 3, Broken Seal Chain x 5, Forgotten Mages Gem x 2, Hard Monster Horn x 2');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Celtic Royal Crossbow',		'1',	10000,	'Finest Firewood x 8, Radiant String x 3, Lightless Metal Fragment x2, Forgotten Mages Gem x 1 Hard Monster Horn x 5');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Divine Crossbow',		'1',	10000,	'Reinforced Firewood x 2, Shining Metal Shard x 10, Medal of Dignity x 5, Broken Guardian Crossbow x 1');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Milky Way Ukulele',	'F',	300,	'Harmonic Wood Board × 1, Instrument Strings x 1');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Milky Way Chalumeau',		'F',	300,	'Harmonic Wood Board × 5, Melodic Metal Board × 10');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Milky Way Cello',		'F',	300,	'Harmonic Wood Board × 8, Instrument Strings × 1, Song Stardust × 1');
INSERT INTO carpentry_items (carpentry, prod_rank, exp_on_creation, mats_rq) VALUES ('Milky Way Roncadora',	'F',	300,	'Harmonic Wood Board × 8, Melodic Metal Board × 15');