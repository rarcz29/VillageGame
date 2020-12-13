﻿using SFML.Graphics;

namespace VillageGame.App.Level
{
    class Tile : ITile
    {
        public Sprite TileSprite { get; }

        public Tile(Texture texture)
        {
            TileSprite = new Sprite();
            TileSprite.Texture = texture;
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(TileSprite);
        }
    }
}