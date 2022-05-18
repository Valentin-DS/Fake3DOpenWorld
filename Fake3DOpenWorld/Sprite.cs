using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Fake3DOpenWorld  {
    public class Sprite {
        public Texture2D Texture {get; private set;}
        public int X {get; private set;}
        public int Y {get; private set;}
        public int Width {get; private set;}
        public int Height {get; private set;}
        public Sprite(Texture2D texture, int x, int y, int width, int height) {
            Texture = texture;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}