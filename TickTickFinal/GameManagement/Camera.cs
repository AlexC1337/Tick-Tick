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
        Screen = new Point(GameEnvironment.Screen.X, GameEnvironment.Screen.Y);
    }
    public override void Update(GameTime gameTime)
    {
        TileField tiles = GameWorld.Find("tiles") as TileField;
        int width = tiles.Columns * tiles.CellWidth;
        int height = tiles.Rows * tiles.CellHeight;
        Player player = GameWorld.Find("player") as Player;
        position = player.Position - new Vector2(Screen.X / 2, Screen.Y / 2);
        if (Position.X < 0)
        {
            position.X = 0;
        }
        if (Position.X > width - Screen.X)
        {
            position.X = width - Screen.X;
        }
        if (Position.Y > height - Screen.Y)
        {
            position.Y = height - Screen.Y;
        }
    }
}
