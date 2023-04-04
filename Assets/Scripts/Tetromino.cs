using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetromino
{
    I,
    O,
    T,
    J,
    L,
    S,
    Z,
}

[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }
    public Vector2Int[,] walkicks { get; private set; }

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino];
        this.walkicks = Data.WallKicks[this.tetromino];
    }
}
