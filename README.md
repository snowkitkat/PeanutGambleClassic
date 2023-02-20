# PeanutGambleClassic
Brings back the old SCP-173 room gambling as seen in pre-Parabellum.

# Features
- Detects if the user is in 173 and replaces their item with a whitelisted item.

# Default config:
```yaml
PeanutGambleClassic:
  is_enabled: true
  # Whether debug logs should be shown in the console.
  debug: true
  # Allowed ItemIDs to spawn. (Ex; 48 to allow the Com45 from spawning. Valid numbers are 0-48. Use -1 for none.
  whitelist:
  - -1
  - 0
  - 1
  - 2
  - 3
  - 4
  - 5
```
# Installation

**[EXILED](https://github.com/galaxy119/EXILED) must be installed for this to work.**

Place the "PeeanutGambleClassic.dll" file in your Plugins folder.

# Item IDs for Whitelist
```yaml
    None = -1,
    KeycardJanitor = 0,
    KeycardScientist = 1,
    KeycardResearchCoordinator = 2,
    KeycardZoneManager = 3,
    KeycardGuard = 4,
    KeycardNTFOfficer = 5,
    KeycardContainmentEngineer = 6,
    KeycardNTFLieutenant = 7,
    KeycardNTFCommander = 8,
    KeycardFacilityManager = 9,
    KeycardChaosInsurgency = 10,
    KeycardO5 = 11,
    Radio = 12,
    GunCOM15 = 13,
    Medkit = 14,
    Flashlight = 15,
    MicroHID = 16,
    SCP500 = 17,
    SCP207 = 18,
    Ammo12gauge = 19,
    GunE11SR = 20,
    GunCrossvec = 21,
    Ammo556x45 = 22,
    GunFSP9 = 23,
    GunLogicer = 24,
    GrenadeHE = 25,
    GrenadeFlash = 26,
    Ammo44cal = 27,
    Ammo762x39 = 28,
    Ammo9x19 = 29,
    GunCOM18 = 30,
    SCP018 = 31,
    SCP268 = 32,
    Adrenaline = 33,
    Painkillers = 34,
    Coin = 35,
    ArmorLight = 36,
    ArmorCombat = 37,
    ArmorHeavy = 38,
    GunRevolver = 39,
    GunAK = 40,
    GunShotgun = 41,
    SCP330 = 42,
    SCP2176 = 43,
    SCP244a = 44,
    SCP244b = 45,
    SCP1853 = 46,
    ParticleDisruptor = 47,
    GunCom45 = 48,
    SCP1576 = 49,
    Coal = 50,
    Scp2536_2 = 51,
    Jailbird = 52
```
