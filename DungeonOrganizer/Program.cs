using DungeonOrganizer.Items;
using DungeonOrganizer.World;
using DungeonOrganizer.Characters;
using DungeonOrganizer.UI;
using InventoryItem = DungeonOrganizer.Items.Item;
using MapItem = DungeonOrganizer.World.Item;


Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
InventoryItem item = new InventoryItem("Mikstura", 15);
Weapon weapon = new Weapon("Miecz", 8);
MapItem Item = new MapItem("!");


//GamePrinter.ShowHeader("Dungeon Organizer");
//GamePrinter.ShowCharacter(player.Name, player.Health);
//GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowInventoryItem(item.Name, item.Price);
//GamePrinter.ShowWeapon(weapon.Name, weapon.Damage);
GamePrinter.ShowMapItem(Item.Symbol);
