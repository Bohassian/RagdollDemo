# RagdollDemo
Ragdoll Demo for CSCI 3510

## Step By Step Guide to make your own demo:
1. Create a new scene.
2. Add a floor to the scene(such as one of the floor prototypes in Standard Assets
3. Add a non-ragdolled model to the scene
- Non-ragdolled models are located in the following folders:
  - Standard Assets/Characters/ThirdPersonCharacter/Prefabs/ or
  - SoldiersPack/ArmyOne/
4. Select the model in your hierarchy.
5. Go to the "GameObject" menu, then access the "3D Object" submenu, and select "Ragdoll..."
6. Drag the bones within the model to the corresponding slots in the Ragdoll Wizard dialog.
7. Click create.
8. Add the ragdolled model to your Assets/Prefabs folder and remove from your hierarchy.
9. Now you can re-add the non-ragdolled model to the scene
- These should still be located in the folders listed in step 3 unless you've moved those prefabs.
10. Add a FPSController to the scene from the Standard Assets prefabs
11. Add an empty game object to the scene called EnemyManager
12. Drag the EnemyManager script to the EnemyManager object and add the model object to one of the enemy slots.
13. Add the Kill script to your FPSController and set the Ragdoll prefab you created in step 8 to the slot that 
corresponds to the enemy slot you added the model to (i.e. if you added the model object to the Enemy 1 slot, add
the Ragdoll prefab to the Enemy 1 Ragdoll Prefab slot on the Kill script)
14. Test your demo! You should find that when you approach the enemy they will suddenly go ragdoll once you are 
within the kill radius (2 by default).
