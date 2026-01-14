[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Bella Sloan she/her
 For our mini game one plan we basically just listed out the main GameObjects: Bunny, Plant, and UI. Underneath each we listed their attributes and actions. For the Bunny's movement action, in our code used the Update() method so that the Bunny sprite (GameObject) would move everyframe. To move the Bunny, we used _playerTransform.Translate() for every direction it could move in. Though the Bunny and the Seeds have their own separate scripts, they actually tie together because within the Bunny GameObject script we have the code that plants the seeds. We actually wrote this the wrong way in our plan and had to change it later. initially, in our plan, we had put the "planting the seeds action" under the Plant GameObject actions, when rather in our code, it's in the Bunny GameObject actions.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
