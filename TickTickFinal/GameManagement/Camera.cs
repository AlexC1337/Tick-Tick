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
    Point Screen;
    public Camera()
    {
        id = "camera";
        //TileField tiles = GameWorld.Find("tiles") as TileField;
        Screen = new Point(GameEnvironment.Screen.X, GameEnvironment.Screen.Y);
    }
    public override void Update(GameTime gameTime)
    {
        Player player = GameWorld.Find("player") as Player;
        Position = player.Position - new Vector2(Screen.X/2, Screen.Y/2);
    }
}
