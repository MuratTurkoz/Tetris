using Mucoded.Tetris.Enum;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Mucoded.Tetris
{
    public class Board : MonoBehaviour
    {
        public TetrominoData[] tetrominoes;
        public Piece activePiece {  get; private set; }
        public Tilemap tilemap { get; private set; }
        public Vector3Int spawnPosition;
        private void Awake()
        {
            this.tilemap = GetComponentInChildren<Tilemap>();
            this.activePiece = GetComponentInChildren<Piece>();
            for (int i = 0; i < tetrominoes.Length; i++)
            {
                this.tetrominoes[i].Initialize();
            }
        }
        private void Start()
        {
            SpawnPiece();
        }
        public void SpawnPiece()
        {
            int random = Random.Range(0,this.tetrominoes.Length);
            TetrominoData data = this.tetrominoes[random];

            this.activePiece.Initialize(this,this.spawnPosition,data);
            Set(activePiece);
        }
        public void Set(Piece piece)
        {
            for (int i = 0;i < piece.Cells.Length;i++)
            {
                Vector3Int tilePosition = piece.Cells[i]+piece.Position;
                this.tilemap.SetTile(tilePosition,piece.TetrominoData.tile);
            }
        }
    }

}
