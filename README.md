# TanksVR
This Project is to be run in Unity, which can be downloaded from https://unity3d.com/get-unity/download
All plugins needed are included within the files of this git, Including the Oculus VR Implementation. However, use of Oculus Experimental Features requires an Oculus Device, and enabling of "Expieriemental Features" which can be found in Oculus Settings under "Extras"

# Bugs
At the moment, there are quite a bit of issues integrating the user within the moving object, the vbehicle. Any continuing support should be focus on "attaching" the user to the vehicle. Additionally, The Levers can often lead to a bit ofg turmoil when maniuplated too far, and this should also be looked into.

# File Structure

- Assets (Where the Fun Stuff is)
  - TerrainAutoUpgrade (Contains Scripts Pertaining to Use of the Realistic Terrain Collection Package. Used to create realistic terrain)
  - CustomResources (All of this is my personal work)
    - Items (Prefabs from the Scene)
      - Axle (Prefab for the 1 Axle and 2 Wheels)
      - Chassis (Uses 4 Axles and 1 Central Chassis to Chain them)
      - Cockpit (Contains a Cockpit prefab, includes 3 walls and 2 Levers)
      - Lever (First Draft of Lever, Inoperable)
      - Lever 1 (Second Model of Lever, Fully functional, with scripts attached)
      - SPUD1 (Prefab that includes chassis and cockpit, combined through a fixed join, with implemented scripts)
    - Materials (Physic Materials for Physical Interactions)
      - MaterialChassis (Material for the Chassis)
      - MaterialHands (Material for the Users Hands)
      - MaterialLeverBase (Material for the Lever Base)
      - MaterialLeverHandle (Material for the Lever Handle)
      - MaterialTableColor (Material for the Cockpit)
      - MaterialTransparent (Material for the invisible tracking block of the handle)
    - Scripts (Scripts I wrote for code)
      - FollowPhysics.Cs (Code for the invisible block on the lever)
      - FollowPlayer.cs (Attempt to have the player follow the vehicle, adapted from FollowPhysics)
      - LeverController.cs (Takes a Lever input and a Wheel, then translates manipulation of the lever into wheel movement)
    - Metas (Ignore these, Simply meta files about the code)
  - Oculus (Contains Scripts, Items, and Settings for Intergration, from the Unity Integration Stuff)
  - Realistic Terrain Collection (Contains Scripts Pertaining to Use of the Realistic Terrain Collection Package. Used to create realistic terrain)
  - Resources (Includes Assets toward Unity, no functional Code)
  - Scenes (Contains my 1 Scene: Main, That i Used to develop my VR application)
  - XR (Contains Scripts Pertaining to Use of XR/VR Production. Unity Default Package)
- Library (Includes install locations of Unity Shaders, Packages, etc... No Functional Code)
- Logs (Includes logs pertaining to the install locations of Unity Plugins and Unity Packages, no functional code)
- Packages (Includes install locations of Unity Plugins and Unity Packages, no functional code)
- Project Settings (Includes Assents toward Unity's Physics Engine, no functional Code)
- User Settings (Includes Assets toward Unity, no functional Code)
