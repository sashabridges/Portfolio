DROP DATABASE handicraft_db;
CREATE DATABASE handicraft_db;

USE handicraft_db;

CREATE TABLE implemented(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	item_rank VARCHAR(6),
	skill_rank VARCHAR(6),
	production_exp INT(15),
	materials VARCHAR(200)
);

CREATE TABLE previouslyImplemented(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	item_rank VARCHAR(6),
	skill_rank VARCHAR(6),
	production_exp INT(15),
	materials VARCHAR(200)
);


CREATE TABLE notImplemented(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	item_rank VARCHAR(6),
	skill_rank VARCHAR(6),
	production_exp INT(15),
	materials VARCHAR(200)
);


CREATE TABLE ptjOnly(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	item_rank VARCHAR(6),
	skill_rank VARCHAR(6),
	production_exp INT(15),
	materials VARCHAR(200)
);

# implemented - 103 items
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Spider Trap', 'A', 'F', 1000, 'Thin Thread x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Handmade Arrow (100)', 'F', 'F', 600, 'Firewood x5, Bundle of Arrowheads x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES (' Fine Handmade Arrow (100)', 'D', 'E', 600, 'Firewood x5, Bundle of Fine Arrowheads x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Finest Handmade Arrow (100)', 'A', 'C', 600, 'Firewood x5, Bundle of Finest Arrowheads x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Marionette Repair Set', 'A', 'D', 3000, 'Blacksmith Hammer x1, Copper Plate x1, Firewood x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fine Marionette Repair Set', '7', 'A', 6000, 'Blacksmith Hammer x1, Tailoring Kit x1, Silver Plate x1, Average Firewood x1, Common Fabric x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Complete Marionette Repair Set', '4', '7', 6000, 'Blacksmith Hammer x1, Tailoring Kit x1, Gold Plate x1, Fine Firewood x2, Fine Fabric x2');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Bone Marine Sword', '9', 'B', 2900, 'Sunfish Bone x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Wood Board', '9', 'D', 3400, 'Firewood x5, Large Nail x5, Iron Bar x2, Tough String x2');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Cooking Table', 'C', 'E', 1000, 'Firewood x5, Large Nail x10');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Nao Costume Kit', '8', 'A', 10000, 'Wood Board x3, Paper x3');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Tree Costume Kit', '6', '8', 9200, 'Wood Board x3, Paper x2');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Spinning Wheel for Finest Leather Strap', '1', '6', 7400, 'Wood Board x3, Large Nail x8, Tough Thread x8');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Spinning Wheel for Fine Leather Strap', '3', '8', 8600, 'Wood Board x3, Large Nail x4, Tough Thread x4');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Bird Cage', '7', '8', 10300, 'Wood Board x3, Tough Thread x3, Large Nail x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Stationary Table', '8', '9', 8700, 'Wood Board x3, Common Fabric x3, Large Nail x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Standing Lamp', '9', 'A', 9800, 'Wood Board x3, Common Fabric x3');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Rock Costume Kit', '9', 'B', 6900, 'Wood Board x2, Paper x4');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Sun Costume Kit', '5', '7', 5900, 'Wood Board x2, Paper x3');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Thicket Costume Kit', '7', '9', 6400, 'Wood Board x2, Paper x2');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fabric Weaving Loom', '4', '9', 5800, 'Wood Board x2, Large Nail x6, Tough Thread x6');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Silk Weaving Loom', '2', '7', 4800, 'Wood Board x2, Large Nail x4, Tough Thread x4');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Handmade Ballista Bolt (30)', 'F', 'F', 700, 'Firewood x6, Bundle of Bolt Heads x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Handmade Bolt (100)', 'E', 'E', 500, 'Firewood x4, Bundle of Bolt Heads x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fine Handmade Ballista Bolt (30)', 'C', 'C', 800, 'Firewood x6, Bundle of Fine Bolt Heads x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fine Handmade Bolt (100)', 'A', 'B', 500, 'Firewood x4, Bundle of Fine Bolt Heads x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Finest Handmade Ballista Bolt (30)', '9', '9', 700, 'Firewood x6, Bundle of Finest Bolt Heads x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Finest Handmade Bolt (100)', '8', '8', 500, 'Firewood x4, Bundle of Finest Bolt Heads x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Handicraft Kit', 'B', 'D', 700, 'Firewood x3, Lare Nail x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Ladle', 'E', 'F', 300, 'Firewood x3');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Potion Concotion Kit', 'B', 'C', 500, 'Firewood x2, Large Nail x4');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Rolling Pin', 'F', 'F', 300, 'Firewood x2');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Magic Powder (Blue Gem)', 'C', 'D', 100, 'Small Blue Gem x1, Base Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Magic Powder (Red Gem)', 'C', 'D', 100, 'Small Red Gem x1, Base Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Magic Powder (Silver Gem)', 'C', 'D', 100, 'Small Silver Gem x1, Base Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Paper Crane', 'F', 'F', 100, 'Paper x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Paper Hat', 'E', 'F', 100, 'Traveler\'s Guide x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fishing Rod', 'D', 'F', 200, 'Wooden Stick x1, Thick Thread Ball x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Ghost Sword', 'D', 'E', 400, 'Cheap Leather Strap x1, Ghost Fluid x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Handmade Bandage', 'E', 'E', 100, 'Cheap Fabric x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fine Handmade Bandage', 'A', 'B', 100, 'Common Fabric x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Alby Dungeon Pass (For Statue Restoration)', 'F', 'Novice', 300, 'Fomor Command Scroll (Alby Dungeon)x1, Holy Water of Lymilark x1, Mana Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Ciar Dungeon Pass (For Statue Restoration)', 'F', 'Novice', 300, 'Fomor Command Scroll (Ciar Dungeon)x1, Holy Water of Lymilark x1, Mana Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Rabbie Dungeon Pass (For Statue Restoration)', 'F', 'Novice', 300, 'Fomor Command Scroll (Rabbie Dungeon)x1, Holy Water of Lymilark x1, Mana Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Math Dungeon Pass (For Statue Restoration)', 'F', 'Novice', 300, 'Fomor Command Scroll (Math Dungeon)x1, Holy Water of Lymilark x1, Mana Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fiodh Dungeon Pass (For Statue Restoration)', 'F', 'Novice', 300, 'Fomor Command Scroll (Fiodh Dungeon)x1, Holy Water of Lymilark x1, Mana Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Coill Dungeon Pass (For Statue Restoration)', 'F', 'Novice', 300, 'Fomor Command Scroll (Coill Dungeon)x1, Holy Water of Lymilark x1, Mana Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Rundal Dungeon Pass (For Statue Restoration)', 'F', 'Novice', 300, 'Fomor Command Scroll (Rundal Dungeon)x1, Holy Water of Lymilark x1, Mana Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Barri Dungeon Pass (For Statue Restoration)', 'F', 'Novice', 300, 'Fomor Command Scroll (Barri Dungeon)x1, Holy Water of Lymilark x1, Mana Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Peaca Dungeon Pass (For Statue Restoration)', 'F', 'Novice', 300, 'Fomor Command Scroll (Peaca Dungeon)x1, Holy Water of Lymilark x1, Mana Herb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Chain of Protection', 'F', 'F', 100, 'Mythril Cable x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Anti-Fomor Cloth', 'F', 'F', 500, 'Fine Silk x2, Holy Water of Lymilark x2, Mana Herb x2');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Holy Potion of Lymilark', 'F', 'F', 100, 'Spirit Forming Bottle x1, Spirit Viewing Powder x1, Spirit Hearing Water x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Finest Handmade Bandage', '6', '6', 100, 'Fine Fabric x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Item Fishing Pole W22', 7, 7, 100, 'Iron Bar x1, Tough Thread x1, Magical Golden Thread x1, Magical Silver Thread x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Item Illusion T46 (100)', '9', '9', 6500, 'Iron Plate x2, Wood Board x2, Large Nail x2, Food Waste x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Peeled Bean', 'F', 'F', 100, 'Bean x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Glowing Ice Sword', 'F', 'F', 100, 'Glowing Frost Crystal x1, Broken Ice Piece x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Ice Sword', 'F', 'F', 100, 'Frost Crystal x1, Broken Ice Piece x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Poison Tip Wyvern Ballista Bolt (3)', '6', '8', 2100, 'Firewood x1, Wyvern Claw x1, Poison Potion x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Wyvern Ballista Bolt (3)', 'B', 'D', 2300, 'Firewood x1, Wyvern Claw x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Irinid Ballista Bolt', 'F', 'Novice', 100, 'Ballista Bolt x1, Irinid\'s Crystal x1, Sulfur Ore x7');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Transparent Crystal Ball', 'D', 'F', 100, 'Restored Blue Crystal Orb x1, Restored Red Crystal Orb x1, Restored White Crystal Orb x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Sparkling Diamond', 'C', 'F', 7100, 'Transparent Crystal Ball x2, Diamond x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Claus Knight Armor', 'Novice', 'Novice', 100, 'Broken Claus Knight Armor x1, Claus Knight Armor Repair Kit x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Snowball', 'Novice', 'F', 100, 'Snow x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Christmas Ornament', 'Novice', 'F', 300, 'Thick Thread Ball x1, Small Gem x5, Branch x5, Large Nail x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Dittes Sacred Wand', 'Novice', 'Novice', 100, 'Broken Dittes Sacred Wand x1, Dittes Sacred Wand Repair Kit x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Bonita Twin Ribbon', 'Novice', 'Novice', 100, 'Ruined Bonita Twin Ribbon x1, Bonita Twin Ribbon Repair Kit x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Ruyuefeixue\'s Butterfly Fan', 'Novice', 'Novice', 100, 'Broken Ruyuefeixue\'s Butterfly Fan x1, Broken Ruyuefeixue\'s Butterly Fan Repair Kit x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Metal Lightning Wand', 'Novice', 'Novice', 100, 'Broken Metal Lightning Rod x1, Metal Lightning Wand Repair Kit x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Doughnut Glasses', 'F', 'Novice', 100, 'Wave Patterned Doughnut x1, Rainbow Sprinkles Doughnut x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Green Paint', 'Novice', 'Novice', 2000, 'Base Herb x10, Bottled Water x1, Fish x1, Mana Point x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Red Paint', 'Novice', 'Novice', 3000, 'Bloody Herb x10, Bottled Water x1, Fish x1, Mana Point x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Yellow Paint', 'Novice', 'Novice', 3000, 'Sunlight Herb x10, Bottled Water x1, Fish x1, Mana Point x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Blue Paint', 'Novice', 'Novice', 4000, 'Mana Herb x10, Bottled Water x1, Fish x1, Mana Point x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Gold Paint', 'Novice', 'Novice', 5000, 'Gold Herb x10, Bottled Water x1, Fish x1, Mana Point x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('White Paint', 'Novice', 'Novice', 5000, 'White Herb x10, Bottled Water x1, Fish x1, Mana Point x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Black Paint', 'Novice', 'Novice', 3000, 'Garbage Herb x10, Bottled Water x1, Fish x1, Mana Point x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Purple Paint', 'Novice', 'Novice', 4000, 'Poison Herb x10, Bottled Water x1, Fish x1, Mana Point x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Demonic Infinity Staff', '1', '1', 50000, 'Demonic Ingot x20, Demonic Eye x1, Demonic Claw x1, Demonic Blade x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Demonic Illusion Control Bar', '1', '1', 50000, 'Demonic Ingot x20, Demonic Eye x2');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Demonic Nightmare Dream Catcher', '1', '1', 50000,'Demonic Eye x1, Demonic Claw x2, Demonic Ingot x15');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Dragon Bone', '4', '7', 6000, 'Dragon Bone Fragment x2');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Festival Table', 'F', 'F', 600, 'Firewood x5, Large Nail x10, Red Paint (Event) x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Celtic Control Bar', '1', '1', 32000, 'Special Firewood x5, Gold Plate x3, Large Nail x10, Cleansed Mage\'s Gem x4, Shattered Black Metal x6, Nightmare Guard\'s Relic x2');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Enchant Expiration Removal Scroll', '9', '9', 1500, 'Poison Herb x10, Paper x5, Restorative Powder x3, Distortion Powder x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Hard Mode Ciar Advanced Fomor Pass', 'F', 'Novice', 300, 'Mangled Ciar Dungeon Pass x1, Restorative Potion x2');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Hard Mode Alby Advanced Fomor Pass', 'F', 'Novice', 300, 'Mangled Alby Dungeon Pass x1, Restorative Potion x3');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Hard Mode Rundal Advanced Fomor Pass', 'F', 'Novice', 300, 'Mangled Rundal Dungeon Pass x1, Restorative Potion x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Rabbie Phantasm Dungeon Pass', 'F', 'Novice', 300, 'Mangled Rabbie Dungeon Pass x1, Restorative Potion x15');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Rabbie Phantasm Dungeon Mirrow World Pass', 'F', 'Novice', 300, 'Mangled Rabbie Dungeon Pass x1, Restorative Potion x5');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Milky Way Cymbals', 'Novice', 'F', 300, 'Melodic Metal Board x1, Song Stardust x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Milky Way Whistle', 'Novice', 'F', 300, 'Melodic Metal Board x10, Song Stardust x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Milky Way Lyre', 'Novice', 'F', 300, 'Harmonic Wood Board x10, Melodic Metal Board x20, Instrument Strings x2');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fine Cherry Scented Candle', '5', 'F', 12600, 'Mini Cherry Scented Candle x1, Wax x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fine Cotton Scented Candle', '5', 'F', 12600, 'Mini Cotton Scented Candle x1, Wax x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fine Lavender Scented Candle', '5', 'F', 12600, 'Mini Lavender Scented Candle x1, Wax x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fine Lemongrass Scented Candle', '5', 'F', 12600, 'Mini Lemongrass Scented Candle x1, Wax x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fine Vanilla Scented Candle', '5', 'F', 12600, 'Mini Vanilla Scented Candle x1, Wax x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Finest Cherry Scented Candle', '1', '9', 16000, 'Fine Cherry Scented Candle x1, Refined Catalyst x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Finest Cotton Scented Candle', '1', '9', 16000, 'Fine Cotton Scented Candle x1, Refined Catalyst x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Finest Lavender Scented Candle', '1', '9', 16000, 'Fine Lavender Scented Candle x1, Refined Catalyst x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Finest Lemongrass Scented Candle', '1', '9', 16000, 'Fine Lemongrass Scented Candle x1, Refined Catalyst x1');
INSERT INTO implemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Finest Vanilla Scented Candle', '1', '9', 16000, 'Fine Vanilla Scented Candle x1, Refined Catalyst x1');


# previouslyImplemented - 12 items
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Eweca Short Sword', 'F', 'F', 500, 'Silver Ingot x2, Shadow of Eweca x1');
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Eweca Shield', 'F', 'F', 500, 'Copper Plate x3, Shadow of Eweca x1');
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Whip Cream', 'Novice', 'Novice', 100, 'Valentine\'s Day Cake Kit x1, Milk x1, Sugar x1');
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Yolk Foam', 'Novice', 'Novice', 100, 'Valentine\'s Day Cake Kit x1, Egg x5');
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Yolk Dough', 'Novice', 'Novice', 100, 'Valentine\'s Day Cake Kit x1, Yolk Foam x1, Wheat Flour x1, Whip Cream x1');
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Egg White Foam', 'Novice', 'Novice', 100, 'Valentine\'s Day Cake Kit x1, Egg x5, Sugar x1');
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Chocolate Cake Dough', 'Novice', 'Novice', 100, 'Valentine\'s Day Cake Kit x1, Yolk Dough x1, Melted Chocolate x1');
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Rising Dough', 'Novice', 'Novice', 100, 'Valentine\'s Day Cake Kit x1, Chocolate Cake Dough x1, Egg White Foam x1');
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Ladeca Short Sword', 'F', 'F', 50, 'Silver Ingot x2, Shadow of Ladeca x1');
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Ladeca Shield', 'F', 'F', 500, 'Copper Plate x3, Shadow of Ladeca x1');
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Ladeca Helm', 'F', 'F', 500, 'Silver Ingot x3, Copper Plate x1, Shadow of Ladeca x1');
INSERT INTO previouslyImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Ladeca Ice Wand', 'F', 'F', 500, 'Silver Ingot x1, Silver Bar x2, Shadow of Ladeca x1');

# notImplemented - 6 items
INSERT INTO notImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Special Arrow (100)', '9', 'B', 1700, 'Average Firewood x5, Bundles of the Finest Arrowheads x1');
INSERT INTO notImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fine Special Arrow (100)', '8', 'A', 4000, 'Fine Firewood x5, Bundle of the Finest Arrowheads x1');
INSERT INTO notImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Finest Special Arrow (100)', '7', '9', 2700, 'Finest Firewood x5, Bundle of the Finest Arrowheads x1');
INSERT INTO notImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Special Bolt (100)', '9', 'B', 1400, 'Average Firewood x4, Bundle of the Finest Bolt Heads x1');
INSERT INTO notImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Fine Special Bolt (100)', '8', 'A', 3200, 'Fine Firewood x4, Bundle of the Finest Bolt Heads x1');
INSERT INTO notImplemented (name, item_rank, skill_rank, production_exp, materials) VALUES ('Finest Special Bolt (100)', '7', '9', 2200, 'Finest Firewood x4, Bundle of the Finest Bolt Heads x1');


# ptjOnly -  13 items
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Thin Spar', 'D', 'F', 600, 'Average Firewood x1');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Thick Spar', 'C', 'E', 800, 'Average Firewood x1, Fine Firewood x1');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Cross-shaped Spar', 'B', 'D', 1000, 'Fine Firewood x1, Wood Board x1');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Glue', 'A', 'C', 1300, 'Garbage Herb x5, Jellyfish x1');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Light Paper', '9', 'B', 1300, 'Poison Herb x6, Paper x4');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Light Thread', '8', 'A', 1500, 'Poison Herb x7, Cheap Finishing Thread x10, Finest Finishing Thread x10');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Light Silk', '7', '9', 1500, 'Poison Herb x8, Cheap Silk x8, Finest Silk x8');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Ferghus Puppet', 'B', 'F', 1500, 'Incomplete Ferghus Puppet x1, Control Bar x1, Finest Finishing Thread x1');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Decorated Bear Puppet', 'D', 'F', 600, 'Eyeless Bear Puppet x1, Button Eye x1');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Decorated Bunny Puppet', 'D', 'F', 800, 'Eyeless Bunny Puppet x1, Button Eye x1');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Bear Puppet', 'C', 'F', 1000, 'Incomplete Bear Puppet x1, Decorative Ribbon x1');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Bunny Puppet', 'C', 'F', 1300, 'Incomplete Bunny Puppet x1, Decorative Ribbon x1');
INSERT INTO ptjOnly (name, item_rank, skill_rank, production_exp, materials) VALUES ('Clown Puppet', 'B', 'F', 1500, 'Incomplete Clown Puppet, Decorative Fether x1, Glue x1');


