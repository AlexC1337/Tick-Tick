using System;
using Microsoft.Xna.Framework;

class Bomb : AnimatedGameObject
{
    Vector2 startPosition;
    public Bomb(bool checkMirror, Vector2 startPosition)
    {
        LoadAnimation("Sprites/Rocket/spr_rocket@3", "default", true, 0.2f);
        PlayAnimation("default");
        this.startPosition = startPosition;
        if (checkMirror) Mirror = checkMirror;
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
        visible = true;
        velocity.X = 600;
        if (Mirror)
        {
            velocity.X *= -1;
        }
    }
}
