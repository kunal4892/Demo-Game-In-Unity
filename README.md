# Demo-Game-in-Unity
Implemenattion of Ball Pickup from Specific spot
and Ball Throw at a specific spot by a Player.
The player can move across the plane.

Implementation details:

1. The player can hover around outiside of the plane
2. The balls can be picked up using direct coordinate assignment or lerp
3. The pick-trigger-zone around the balls are implemented as a child of the ball gameObject for scalability.
4. The throw-trigger-zone is implemented as a child of the pad gameObject for scalability.
4. The Player is implemented as a PreFab. It's more efficient for rendering. It is also modular.
