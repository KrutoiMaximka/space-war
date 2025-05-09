using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using space_war.Classes;

namespace space_war.Classes
{

    public class Asteroid
    {
        private Texture2D _texture;
        private Vector2 _position;
        private Rectangle _collis;

        public Rectangle _Collis
        {
            get
            {
                return _collis;
            }
        }



        public int Width
        {
            get
            {
                return _texture.Width;
            }
        }

        public Vector2 Position
        {
            set
            {
                _position = value;
            }

            get
            {
               return _position;
            }
        }

        public Asteroid() : this(Vector2.Zero)
        {

        }
        



        public Asteroid(Vector2 position)
        {
            _texture = null;
            _position = position;
        }

        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("asteroid");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }

        public void Update()
        {
            _position.Y += 2;
            _collis = new Rectangle((int)_position.X, (int)_position.Y, _texture.Width, _texture.Height);
        }
    }
}
