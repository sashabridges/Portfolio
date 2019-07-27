DROP DATABASE potionmaking_db;
CREATE DATABASE potionmaking_db;

USE potionmaking_db;

CREATE TABLE potion_making_items(
		id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
		potion VARCHAR(50) NOT NULL,
		i_rank VARCHAR(6),
		materials VARCHAR(300),
		description VARCHAR (100)
);

INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Comprehensive HP 1000 Potion',	'Dan 1', 'Wound Remedy 30 Potion x 5, HP 500 Potion RE x 1, Bottled Water x 1, Bloody Herb x 5', 'Restores 1,000 HP & Wound');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Comprehensive HP 500 Potion', 'Dan 1',	 'Wound Remedy 30 Potion x 3, HP 300 Potion RE x 1, Bottled Water x 1', 'Restores 500 HP & Wound');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Comprehensive Recovery 1000 Potion', 'Dan 1', 'N/A',		'Restores 1,000 HP, MP, Stamina & Wound');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Comprehensive Recovery 500 Potion', 'Dan 1', 'N/A',		'Restores 500 HP, MP, Stamina & Wound' );
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('HP & MP 30 Potion',	'F', 'Mana Herb x 1, Bloody Herb x 1, Base Herb x 1', 'Restores 30 HP & MP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('HP & MP 50 Potion', 'F', 'Mana Herb x 1, Bloody Herb x 1, Base Potion x 1, Base Herb x 1', 'Restores 50 HP & MP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('HP & Stamina 30 Potion', 'F', 'Mandrake x 1, Base Herb x 1', 'Restores 30 HP & Stamina');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('HP & Stamina 50 Potion', 'F', 'Mandrake x 1, Base Potion x 1, Base Herb x 1', 'Restores 50 HP & Stamina');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('HP 100 Potion', 'F', 'Bloody Herb x 1, Base Potion x 1, Base Herb x 1', 'Restores 100 HP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('HP 300 Potion', 'F', 'Water x 1, HP 100 Potion x 1, Bloody Herb x 2', 'Restores 300 HP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('HP 300 Potion RE', 'Dan 1', 'Water x 1, Mandrake x 1, HP 300 Potion x 1, Four-Leaf Clover x 1', 'Restores 300 HP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('HP 50 Potion',	'Novice', 'Bloody Herb x 1, Base Herb x 1', 'Restores 50 HP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('HP 500 Potion', '?', 'Water x 1, HP 300 Potion x 1, Four-Leaf Clover x 1', 'Restores 500 HP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('HP 500 Potion RE', 'Dan 1', 'Water x 1, Mandrake x 1, HP 500 Potion x 1, Four-Leaf Clover x 1', 'Restores 500 HP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('MP 100 Potion','F', 'Mana Herb x 1, Base Potion x 1, Base Herb x 1', 'Restores 100 MP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('MP 300 Potion', 'F', 'Water x 1, Mana Herb x 2, MP 100 Potion x 1', 'Restores 300 MP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('MP 300 Potion RE',	'Dan 1', 'Water x 1, Mandrake x 1, MP 300 Potion x 1, Four-Leaf Clover x 1', 'Restores 300 MP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('MP 50 Potion',	'Novice', 'Mana Herb x 1, Base Herb x 1', 'Restores 50 MP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('MP 500 Potion', '?', 'Water x 1, MP 300 Potion x 1, Four-Leaf Clover x 1', 'Restores 500 MP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('MP 500 Potion RE', 'Dan 1', 'Water x 1, Mandrake x 1, MP 500 Potion x 1, Four-Leaf Clover x 1', 'Restores 500 MP');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Marionette 100 Potion',	'F', 'Zinc Ore Fragment x 1, Tin Ore Fragment x 1, Sunlight Herb x 1, Base Potion x 1', 'Restores 100 HP of the summoned Marionette');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Marionette 30 Potion',	'F', 'Tin Ore Fragment x 1, Base Potion x 1, Base Herb x 1', 'Restores 30 HP of the summoned Marionette');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Marionette 300 Potion', 'F', 'Zinc Ore Fragment x 1, Nickel Ore Fragment x 1, Mana Herb x 1, Base Potion x 1', 'Restores 300 HP of the summoned Marionette');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Marionette 50 Potion', 'F', 'Tin Ore Fragment x 1, Bloody Herb x 1, Base Potion x 1', 'Restores 50 HP of the summoned Marionette');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Marionette 500 Potion', 'F', 'Zinc Ore Fragment x 1, Tin Ore Fragment x 1, Nickel Ore Fragment x 1, Gold Herb x 1, Base Potion x 1', 'Restores 500 HP of the summoned Marionette');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Stamina 100 Potion', 'F', 'Sunlight Herb x 1,  Base Herb x 1', 'Restores 100 Stamina');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Stamina 300 Potion', 'F', 'Water x 1, Sunlight Herb x 2, Stamina 100 Potion x 1', 'Restores 300 Stamina');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Stamina 300 Potion RE', 'Dan 1', 'Water x 1, Stamina 300 Potion x 1, Mandrake x 1, Four-Leaf Clover x 1', 'Restores 300 Stamina');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Stamina 50 Potion', 'Novice', 'Sunlight Herb x 1, Base Herb x 1', 'Restores 50 Stamina');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Stamina 500 Potion', '?',	 'Water x 1, Stamina 300 Potion x 1, Four-Leaf Clover x 1', 'Restores 500 Stamina');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Stamina 500 Potion RE', 'Dan 1', 'Water x 1, Stamina 300 Potion x 1, Mandrake x 1, Four-Leaf Clover x 1', 'Restores 500 Stamina');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Wound Remedy 10 Potion', 'F', 'Mana Herb x 1, Golden Herb x 1, Bloody Herb x 1, Base Herb x 1', 'Restores 10 Wound');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Wound Remedy 30 Potion', 'F', 'Mana Herb x 1, Gold Herb x 1, Bloody Herb x 1, Base Potion x 1, Base Herb x 1', 'Restores 30 Wound');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Blacksmithing Boost Potion', 'D', 'Refined Catalyst x 3, Pure White Dust x 5, Mandrake x 2, Gold Herb x 5, Base Potion x 1','Increases Blacksmithing success rate by 2% for 1 attempt');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Carpentry Boost Potion', 'D', 'Refined Catalyst x 3, Pure White Dust x 5, Mandrake x 2, Gold Herb x 5, Base Potion x 1', 'Increases Carpentry success rate by 2% for 1 attempt');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Handicraft Boost Potion', 'D',	 'Refined Catalyst x 3, Pure White Dust x 5, Mandrake x 2, Gold Herb x 5, Base Potion x 1', 'Increases Handicraft success rate by 2% for 1 attempt');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Hillwen Engineering Boost Potion', 'D', 'Refined Catalyst x 3, Pure White Dust x 5, Mandrake x 2, Gold Herb x 5, Base Potion x 1', 'Increases Hillwen Engineering success rate by 2% for 1 attempt');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Magic Craft Boost Potion',	'D', 'Refined Catalyst x 3, Pure White Dust x 5, Mandrake x 2, Gold Herb x 5, Base Potion x 1', 'Increases Magic Craft success rate by 2% for 1 attempt');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Potion Making Boost Potion', 'D', 'Refined Catalyst x 3, Pure White Dust x 5, Mandrake x 2, Gold Herb x 5, Base Potion x 1', 'Increases Potion Making success rate by 2% for 1 attempt');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Tailoring Boost Potion', 'D', 'Refined Catalyst x 3, Pure White Dust x 5, Mandrake x 2, Gold Herb x 5, Base Potion x 1', 'Increases Tailoring success rate by 2% for 1 attempt');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Cooking Potion', 'D', 'Water x 1, Mandrake x 1, Brown Pine Mushroom x 1', 'Used to cook magical dishes.');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Poison Potion', '3', 'Water x 1, Poison Herb x 1, Base Herb x 1', 'Temporarily applies poison effect to weapon.');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Spirit Liqueur', 'F', 'White Herb x 1, Piece of an Ancient Spirit Fossil x 1, Elemental Remover x 2', 'Used in repairing Spirit Weapons');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Antidote Potion', '5', 'Water x 1, Base Herb x 1, Antidote Herb x 1', 'Cures poisoning from Poison Attack and sulfur poisoning (not Potion Poisoning).');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Good Luck Potion',	'F', 'Water x 1, Four-Leaf Clover x 1, Base Herb x 1', 'Changes into a random item after 36 minutes.');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Likeability Potion', 'C', 'Water x 1, Gold Mushroom x 1, Bloody Herb x 1', 'Raises the affection level when given as a present to an NPC.');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Holy Potion of Lymilark', 'F', 'Spirit Viewing Powder x 1, Spirit Hearing Water x 1, Spirit Forming Bottle x 1', 'Used in Creating the Secret Formula for Holy Potion of Lymilark quest of Generation 3: Dark Knight.');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Possessed Potion',	'Novice', 'Water x 1, Mana Herb x 1, Bloody Herb x 1, Base Herb x 1', 'Used in Shamala in Crisis Generation 17 Sidequest');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Spirit Hearing Water',	'F','White Herb x 1, Mana Herb x 1, Bloody Herb x 1', 'Used to make Holy Potion of Lymilark');
INSERT INTO potion_making_items (potion, i_rank, materials, description) VALUES ('Treasure Hunters Special Potion', 'Novice', 'Scorpion Hair x 4, Peculiar Dust x 4, Map Pieces x 10, Lava Fruit x 2, Hot Ash x 5, Creepy Sprout x 3, Bitterbite Herb x 6', 'Used in Iria II: Episode 3 - Pursuit');