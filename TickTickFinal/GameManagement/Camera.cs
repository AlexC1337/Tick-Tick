using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;


class Camera : GameObject
{
    public Vector2 CameraPosition = new Vector2(0,0);
    public Camera()
    {

    }
    public override void Update(GameTime gameTime)
    {
        Player player = GameWorld.Find("player") as Player;
        CameraPosition = player.Position + new Vector2(GameEnvironment.windowSize.X/2, GameEnvironment.windowSize.Y/2);
    }
}


