USE magiccraft_db;

#SELECT * FROM magic_craft_items;

#SELECT * FROM magic_craft_items
#WHERE training_type LIKE 'Magic Conversion';

#SELECT * FROM magic_craft_items
#WHERE training_type LIKE 'Magic Weapon and Armor Crafting';

SELECT * FROM magic_craft_items
WHERE materials LIKE '%Mutant%';