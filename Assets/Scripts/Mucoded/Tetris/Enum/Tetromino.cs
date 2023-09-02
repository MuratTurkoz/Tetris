using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Mucoded.Tetris.Enum
{
    public enum Tetromino
    {
        I,
        O,
        T,
        J,
        L,
        S,
        Z
    }
    [Serializable]
    public struct TetrominoData
    {
        public Tetromino tetromino;
        public Tile tile;
        public Vector2Int[] cells { get; private set; }

        public void Initialize()
        {
            this.cells = Data.Cells[this.tetromino];
        }
    }

}

