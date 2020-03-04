# Dogginator 

## unity version
  - 2019.3.1f1

## Controller mapping           
  - Y:                  reset game
  - left_hand:          speed up
  - right trigger       shot bullet
  - left_thumbstick:    rotate aircraft view
  - right controller:   pointer to enemy
  - left start:         Menu UI

## update 

### patch 5 (3/2/2020)
  - add vibrate when shoot
  - add flight sound when get close to enenmy
  - add lake scene
  - add pause game menu UI
  - add enemy for scene grass hill

### patch 4 (2/27/2020)
  - add health to enemy
    - enemy now drop to the ground when destroy
  - add explosion when enemy destroyed 
  - enemy attack player when near by
  - adjust Z-axis after rotating
  - add pointer for shooting
    - player now use right controller point to enemy to shoot
  

### patch 3 (2/24/2020)
  - add bullet effect
    - smoke
    - flare
  - add shooting function
  - add aim scope
    - rotate aim_scope
  - add shoot audio sound
  - add hit audio sound
  - add ground scene
  - add enemy moving route
 
### patch 2 (2/ 19/2020)
  - add aircraft rotation function
 
### patch 1 (2/14/2020)
  - add aircraft
  - add scene background (moutain dessert)
  
### mode
  - air 
  
  - ground
    - terrain
    - tank model
    - sound source
    - shot effect
    - enemy model 
    - 


### functions
  - shoot()
    - has effect when hit enenmy
    - can detect if hit enemy
  - enemy attack player()
    - get closer to player
    - attack player
   


## Background 
flying in the sky is everyone’s dream since thousands of years ago. In 1903, the Wright brothers made the first airplane which changed the way humans travel. Traveling anywhere on the earth is no longer a problem. 
However, not anyone can fly an airplane, especially one with weapons. Becoming a pilot requires you to pay a hefty amount for pilot school, go through lengthy training and pass various tests. Now you can do it all in Dogginator!
There are already several flight simulator games on the market, which vary from being photorealistic to some rather cartoonish attempts.

## Motivation
virtual reality will bring first-person aircraft fighting game to another level. Most of the flight simulator games available right now simply let you pilot the airplanes, which can get rather boring after a while. An aircraft fighting game packed with actions would be an interesting new spin of this genre. 

## Description
Players will be fighting others in a fight jet. There will be many interesting characters to unlock for the player to play as. We are going to create scenes of different backgrounds, terrains and obstacles. There will be AI piloted aircrafts that the player needs to destroy. There will be different levels with increasing difficulties. Players rack up credits when winning the game, which can be used for aircraft and weapon upgrades and unlocking more characters. 
We will develop the game using Unity 3D, and since we are not professional designers, we will look into the Unity Asset Store for pre-built models such as aircrafts. We will use C# scripts (and probably state machines) to control AI enemy aircrafts.

## Deliverables
The player’s view would be a first person camera (main camera) , player can use joystick and button on the oculus controller to move the aircraft, aim the target, and use the weapons. There are different aircraft and weapon upgrades that players can earn, and increasingly difficult game levels. 

## Human factors
The fights will be exciting and fast-paced, but players can sit back and relax. There can be fast lighting changes and camera movement during the game, which can cause dizziness. 
Players can pause the game at any time to do something else and return to the paused state. The game levels will start with “more sedate, slower-paced interactions that ease them into the game”, but we might not be able to find many novice players to try out the game. We will put warnings of the content in the game since fighting in the air could very well get intense. 
We will try to incorporate motion parallax for the monocular depth clues. Information will be built into the environment, things like maps, weapon status will be displayed on the cockpit rather than a floating HUD.

## Milestones
Week 7: creating background terrain and obstacles.
  - World size
  - Obstacles shape
    - It could be destroyed
    - Make small objects to combine a wall
  - Terrain height

Week 7 (cont’d): creating different aircraft models which can be upgraded or replaced in the game
  - Different weapons
    - Power
    - ability Cooldown
  - Different aircrafts with upgrades
    - Speed
    - Armor 
    - Health
    - Special Ability(optional)

Week 8: making sure players can control the aircrafts in the game
  - Moving
  - Shooting
  - Switching weapon

Week 9: creating AI controlled enemy aircrafts

Week 10: create different levels
  - Increasing difficult
  - Maybe different maps
  - Different items and amount of credits earned
