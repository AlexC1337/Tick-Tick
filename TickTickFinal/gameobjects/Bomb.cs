using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Bomb : AnimatedGameObject
{
    public Bomb(bool checkMirror, Vector2 startPosition) : base(0,"bomb")
    {
        LoadAnimation("Sprites/Bomb/spr_bomb@3", "default", true, 0.2f);
        PlayAnimation("default");
        this.Position = startPosition;
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
        //CheckEnemyCollision();
        Rectangle screenBox = new Rectangle(0, 0, GameEnvironment.Screen.X, GameEnvironment.Screen.Y);
        if (!screenBox.Intersects(this.BoundingBox))
        {
            GameWorld.Remove(this);
            Player.IsShooting = false;
        }
    }

    //public void CheckEnemyCollision()
    //{
    //    GameObjectList enemies = GameWorld.Find("enemies") as GameObjectList;
    //    foreach(SpriteGameObject enemy in enemies)
    //    {
    //        if (CollidesWith(enemy) && visible && isAlive)
    //        {
    //            enemy.isAlive = false;
    //        }
    //    }
    //}
}
