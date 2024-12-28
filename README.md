# IAV_GOAP

## Agents

This project has three different agents and each one of them has two different actions to perform.

### Zombie

The goal of the zombie agent is to help other zombies to rise. To accomplish that, the zombie must dig graves to invoke more of his kin. The actions of this agent are:
1. GACT_DigGrave: the agent will target one of the graves that haven't been dug yet.
2. GACT_InvokeZombie: the zombie will invoke another zombie.

https://github.com/user-attachments/assets/d73e26fb-3dd7-4d40-b66f-a8b4038a2b51

### Digger

The goal of the digger agent is to fill all the graves that have been dug by a zombie. His actions are:
1. GACT_PickShovelUp: the digger must find a shovel first and pick it up to start filling the graves. The shovels are limited to a number of uses before it breaks. When the shovel breaks, the digger must pick another shovel up.
2. GACT_FillGrave: the digger will target a dug grave and he must fill it

https://github.com/user-attachments/assets/85035bef-674c-4a73-8adf-3c60205f67d4

### Hunter

The goal of the hunter is to break the gravestones in the graveyard. When a gravestone is destroyed, a zombie will die. His actions are:
1. GACT_DestroyGravestone: the hunter will target a gravestone that haven't been destroyed yet. Once he does it, a zombie will die.
2. GACT_RecoverEnergy: breaking gravestones can exhaust the hunter. So from time to time he must eat a pumpkin to restore his energy.

https://github.com/user-attachments/assets/f9a98d28-dab8-4cd0-8740-2bec52a857b3

## Credits

All assets were made by Kenney: https://kenney.nl/assets
