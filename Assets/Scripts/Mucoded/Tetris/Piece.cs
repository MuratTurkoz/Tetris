using Mucoded.Tetris.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Mucoded.Tetris
{
    public class Piece : MonoBehaviour
    {
        public Board Board { get; private set; }
        public TetrominoData TetrominoData { get; private set; }
        public Vector3Int Position { get; private set; }
        public Vector3Int[] Cells { get; private set; }

        public void Initialize(Board board, Vector3Int position, TetrominoData tetrominoData)
        {
            this.Board = board;
            this.Position = position;
            this.TetrominoData = tetrominoData;

            if (this.Cells == null)
            {
                this.Cells = new Vector3Int[tetrominoData.cells.Length];
            }
            for (int i = 0; i < this.Cells.Length; i++)
            {
                this.Cells[i] = (Vector3Int)tetrominoData.cells[i];
            }
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Move(Vector2Int.left);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Move(Vector2Int.right);
            }
        }
        private void Move(Vector2Int translation)
        {
            
        }

    }
}
