# Cartoon Crossover

This is a game I created for StudentHack VII as part of a team of 4. The theme of the hackathon was cartoons so we have created a card based fighting game.

Cartoon Crossover draws inspiration from various games, the most obvious inspiration comes from major card games like Pokemon and Yu-Gi-Oh, whist other mechanics take inspiration from things like the real world navigation element of Pokemon Go.

## Level Codes


Level 1 - UltronUsed:EnergyBlast
Level 2 - YoureDeadSpiderMan
Level 2 - LikeATurdInTheWind
Level 3 - IveNeverSeenThisManInMyLife
Level 5 - AsAllThingsShouldBe

## Gameplay Guide

When the game begins the player is taken to a level code input screen. Here they will input the appropriate code for the level there are on which will take them to the fight (whilst the game does follow a linear narrative there is no mechanism in place currently to ensure that the player goes from level 1 to level 2 and so on. The reasoning behind the level code system will be elaborated on below).
All in all the fights are relatively simple. They consists of a 1 on 1 battle. Each character has 4 moves, some of these will heal but most will damage (unfortunately these are not labeled and will have to be learn through trial and error). The goal is to defeat the enemy. Each level consists of a brief intro which proved context into the fight. This is then followed by the actual fight which depending on the outcome will have win/lose screens.

## Level System

Without having been in the hackathon the inclusion of a level code system seems to be pretty arbitrary and frustrating as it segments gameplay. During the design of the game, Pokemon Go was having a mini resurgence and some members of the team were active players. We thought it would be interesting if we could implement something that resembled the real world traversal aspect that so many players were a fan of. However none of us had any experience working with GPS tracking and frankly there were other problems the would prevent from us from following this idea e.g 
- Our game was not made for mobile platforms and carrying your laptop around would be clunky
- The hackathon was only 24 hours long and we weren't confident that we could learn how to use GPS tracking in that period of time
- If we managed to implement the feature testing and debugging would become much more complicated 
All these reasons deterred us from following this idea and so we had to find a workaround. I came up with the low tech solution of sticking codes around the building. This would force users to move around and experience the fun of finding a code without us having to worry about GPS tracking. This would also mean the user could find the codes without bringing their laptop with them as they could just write down the code.All we had to do is declare these codes in the game and just compare the user input with our database of codes which made testing and debugging easier. Another plus is that we could theme the code with the level as you can see in the codes given above. All in all this proved to be a simple yet successful workaround the implement a complex feature in a short amount of time












