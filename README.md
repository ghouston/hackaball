# Hackaball

An experiment in hacking a game.  Started: Hacktember 2014 by BOSS.

[Hackaball on Github](https://github.com/bosshack/hackaball)

![ScreenShot](https://raw.github.com/bosshack/hackaball/screenshots/screenshots/hackaball_09_17_2014.png)

## Overview

A game of making a game.

The awesome part of opensource is you can learn and build upon the cool stuff everyone has made.  So why not make a game of making an opensource game?

The idea:

1. start with a very simple game
2. player-developers fork the game and make their own twists to it.
3. other player-developers build on that.
4. repeat.

Future:

* add meta-game things to gamify the game creation:
	* leaderboards
	* showcases
	* achievements
	* contests
	
## Approach

The initial game "hackaball" will use Unity3d and opensource the code and assets within the game.  While the Unity3d engine is not opensource, it has the advantage of being free (community edition) and well supported.  Beginners can learn with a couple of hours enough to tweak the initial game.

Everyone is encouraged to _fork_ the "hackaball" game, or _fork_ someones _fork_ of hackball.  Make an imporvement.  Take the game in a new direction.  Have fun!

## Rules

Every game has rules, even calvin ball has rules.  Hackaball has rules... but you can fork the game and make your own rules on your branch.

1. All assets and code should be opensource.
2. Play nice and attribute sources.
3. Dont stare at hackaball.  Dont expose hackball to direct sunlight.  Store hackaball in a cool dry place at room temperature.  Hackaball may be closer than it appears in your mirror.  Do not operate heavy machinery or drive while hacking hackaball.

## Getting Started

Hackaball is based on the tutorial [Roll-a-ball](http://unity3d.com/learn/tutorials/projects/roll-a-ball) by Unity3d.  This one hour tutorial covers what you need to know to get started with Unity3d and hackaball.

### Unity3d and Github

Unity3d is very controlling of its files.  You need to follow some simple steps to avoid issues.

1. Don't move, add, or delete Unity3d asset files in your operating system.  Instead use Unity3d's project window to move, add or delete files.
2. Exit Unity3d before using git.
2. Under **Edit > Project Settings > Editor**, use **Version Control > Mode = Visable Meta Files** and **Asset Serialization > Mode = Force Text** ([ProjectSettings/EditorSettings.asset](https://github.com/bosshack/hackaball/blob/master/ProjectSettings/EditorSettings.asset) already has this configured.)
3. It is best to avoid merging assets.  If possible avoid having two people work on a scene in parallel.
4. Keep your assets small.  Nobody wants to checkout a large git repository.

