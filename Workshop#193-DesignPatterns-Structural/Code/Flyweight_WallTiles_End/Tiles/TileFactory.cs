using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_WallTiles_End.Tiles
{
    public enum TileTypes
    {
        Marble,
        Dots,
        Squares
    }

    public class TileFactory
    {
        private Dictionary<TileTypes, Tile> _tilePool;

        public TileFactory()
        {
            _tilePool = new Dictionary<TileTypes, Tile>();
        }

        public Tile GetTile(TileTypes tileType)
        {
            switch (tileType)
            {
                case TileTypes.Dots:
                    {
                        if (_tilePool.ContainsKey(TileTypes.Dots))
                        {
                            return _tilePool[TileTypes.Dots];
                        }
                        else
                        {
                            var tile = new DotsTile();
                            _tilePool.Add(TileTypes.Dots, tile);
                            return tile;
                        }
                    }

                case TileTypes.Squares:
                    {
                        if (_tilePool.ContainsKey(TileTypes.Squares))
                        {
                            return _tilePool[TileTypes.Squares];
                        }
                        else
                        {
                            var tile = new SquaresTile();
                            _tilePool.Add(TileTypes.Squares, tile);
                            return tile;
                        }
                    }

                case TileTypes.Marble:
                    {
                        if (_tilePool.ContainsKey(TileTypes.Marble))
                        {
                            return _tilePool[TileTypes.Marble];
                        }
                        else
                        {
                            var tile = new MarbleTile();
                            _tilePool.Add(TileTypes.Marble, tile);
                            return tile;
                        }
                    }
            }
            return null;
        }
    }
}
