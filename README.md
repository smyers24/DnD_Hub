# DnD_Hub

## Features
Main Screen <br>
![Overview](https://github.com/smyers24/DnD_Hub/raw/master/DnD_Hub/assets/HubMainScreen.png)
* Character Management
    * Save Name, HP, and AC between sessions
* File Management
    * Easily open multiple files/URLs to quickly jump back into a sessions
    * Use a .txt file for this feature - line separated links
* Roll Result [WIP]
    * Easily and visibly see the result of the roll
* Dice Box 
	* Roll individual die or multiple dice at once
	* Display individual results as well as total
	* [WIP] Need to add (dis)advantage
    ![Dice box](https://github.com/smyers24/DnD_Hub/raw/master/DnD_Hub/assets/DiceBoxRoll.png)
* Custom Roll Table
    * Parse from CSV to populate control with Name, Roll String , and Description
    * Easily modify in the program, or use the CSV
    * Double-clicking the row will automatically perform the roll
    * Add/Modify/Delete rolls as desired
    * Rolls are saved to CSV at close and populated on launch
![Custom roll table](https://github.com/smyers24/DnD_Hub/raw/master/DnD_Hub/assets/CustomRollBreakdown.png) <br>
![Custom Roll Box](https://github.com/smyers24/DnD_Hub/raw/master/DnD_Hub/assets/CustomRollForm.png) <br>
![Making custom roll](https://github.com/smyers24/DnD_Hub/raw/master/DnD_Hub/assets/NewlyAddedCustomRoll.png)

* Manual Roll <br>
    * Type in a string and roll it. Option clear the box after rolling 
    ![Manual roll](https://github.com/smyers24/DnD_Hub/raw/master/DnD_Hub/assets/ManualRoll.png)
* Saving Throws
    * Parsed from CSV, populate table with saving throw names and modifiers
    * Double-click to roll
* Skills
    * Parse skills from CSV to table. Features name, bonus, modifier, and proficiency
    * [WIP] Needs a modifiers field and to pull from that
    * [WIP] Proficiency doesn't do anything right now, simply a visual indicator
* Load the map in a tab (may be changed to pop-out later)
* Most fields are saved on program close and loaded on program launch

##TO-DO
* Disadvantage/Advantage on rolls
    * Colors to show the two different rolls?
* Modifier field
* Better Roll Result box
* Better file IO (JSON?) for character profiles, rather than multiple CSVs
* Status field? 
* I would like to eventually have database access to spells for easier adding
* Inventory tab/area to keep track 

## Known Issues
* Dice box modifier only supports positive mods. Need improved RegEx instead of String.Split

