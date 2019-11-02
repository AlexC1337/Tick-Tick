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
    public Vector2 CameraPosition;
    public Camera()
    {
        id = "camera";
    }
    public override void Update(GameTime gameTime)
    {
        Point Screen = new Point(GameEnvironment.Screen.X, GameEnvironment.Screen.Y);
        Player player = GameWorld.Find("player") as Player;
        CameraPosition = player.Position - new Vector2(Screen.X/2, Screen.Y/2);
    }
}


