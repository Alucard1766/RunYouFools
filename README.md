# RunYouFools
Learning Project

##To Discuss
* IDE
* Naming Conventions
* Error handling
* Folder structure

###Game related
* Map structure
* Features (Must, Nice to have
  * StateManager - *Nice to have? See bottom "States"*
    * MainMenu
    * Game
    * InGameMenu?(Paused)
    * GameComplete
  * MainMenu - *Must*
    * New Game
    * Exit
  * TileMap - *Must*
    * Data and graphics separated
    * Extendable, dynamic
    * Good performance for big map because we need to implement this in our main project which has only one "map"
    * Multiple layers which are stacked to create game world. Player collides with some of the layers ([example]( https://cdn.tutsplus.com/gamedev/authors/daniel-schuller/jrpg-using-tilemap-layers.png))
  * Player - *Must*
    * Data and graphics seperated
    * Running animation
    * Colliding with tilemap
    * Collecting powerups
    * Is able to activate powerups
  * Powerups
    * Running faster - *Must*
    * Shooting projectile which stops other player for medium amount of time if hit - *Nice to have*
    * Lightning which stops other player for short amount of time, always hits - *Nice to have*
    * Protection which protects player from being stoped by a powerup - *Nice to have*

####States
States are **bold**

* StartPoint -> **MainMenu** -> Exit
* StartPoint -> **MainMenu** -> Start Game -> **Game** -> **GameComplete**(Finish reached) -> **MainMenu**
* StartPoint -> **MainMenu** -> Start Game -> **Game** -> ESC Pressed -> **InGameMenu** -> Continue -> **Game**
* StartPoint -> **MainMenu** -> Start Game -> **Game** -> ESC Pressed -> **InGameMenu** -> Exit -> **MainMenu**
