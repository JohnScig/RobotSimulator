using System;
using System.Collections.Generic;
using System.Drawing;

namespace ActionRobot
{

    /// <summary>
    /// Enum for tile types.
    /// </summary>
    enum eCellType
    {
        None = 0,
        Wall = 1,
        Start = 2,
        Finish = 3
    }

    /// <summary>
    /// View model.
    /// </summary>
    internal class ViewModel
    {

        #region Constants

        /// <summary>
        /// Size of area for robot movements.
        /// </summary>
        public const int AREA_SIZE = 10;

        #endregion

        #region Attributes

        /// <summary>
        /// Area for robot movements.
        /// </summary>
        private eCellType[,] _area;

        /// <summary>
        /// List of robot moves.
        /// </summary>
        private Queue<Func<Point, Point>> _moves;

        #endregion

        #region Properties

        /// <summary>
        /// Current cell type.
        /// </summary>
        public eCellType CurrentCellType { get; set; } = eCellType.Start;

        #endregion

        #region Constructors

        /// <summary>
        /// Ctor.
        /// </summary>
        public ViewModel()
        {
            _area = new eCellType[AREA_SIZE, AREA_SIZE];
            _moves = new Queue<Func<Point, Point>>();
        }

        #endregion

        #region Area

        /// <summary>
        /// Clears area.
        /// </summary>
        public void ClearArea()
        {
            for (int x = 0; x < AREA_SIZE; x++)
                for (int y = 0; y < AREA_SIZE; y++)
                    _area[x, y] = eCellType.None;
        }

        /// <summary>
        /// Removes all occurences of specific cell type.
        /// </summary>
        /// <param name="cellType">Cell type.</param>
        private void RemoveAllOccurences(eCellType cellType)
        {
            for (int x = 0; x < AREA_SIZE; x++)
                for (int y = 0; y < AREA_SIZE; y++)
                    if (_area[x, y] == cellType)
                        _area[x, y] = eCellType.None;
        }

        /// <summary>
        /// Sets area tile with current tile type.
        /// </summary>
        /// <param name="x">X-coordinate.</param>
        /// <param name="y">Y-coordinate.</param>
        public void SetTile(int x, int y)
        {
            if (CurrentCellType == eCellType.Start || CurrentCellType == eCellType.Finish)
            {
                RemoveAllOccurences(CurrentCellType);
            }
            _area[x, y] = CurrentCellType;
        }

        /// <summary>
        /// Gets cell type char.
        /// </summary>
        /// <param name="x">X-coordinate.</param>
        /// <param name="y">Y-coordinate.</param>
        /// <returns>Char to write in area cell symbolizing cell type.</returns>
        public char GetTile(int x, int y)
        {
            switch (_area[x, y])
            {
                case eCellType.Start: return 'S';
                case eCellType.Finish: return 'F';
                case eCellType.Wall: return 'X';
                default: return ' ';
            }
        }

        #endregion

        #region Moves

        /// <summary>
        /// Adds move up.
        /// </summary>
        public void SetUpMove()
        {
            // IMPLEMENT
        }

        /// <summary>
        /// Adds move down.
        /// </summary>
        public void SetDownMove()
        {
            // IMPLEMENT
        }

        /// <summary>
        /// Adds move left.
        /// </summary>
        public void SetLeftMove()
        {
            // IMPLEMENT
        }

        /// <summary>
        /// Adds move right.
        /// </summary>
        public void SetRightMove()
        {
            // IMPLEMENT
        }

        /// <summary>
        /// Clears robot moves.
        /// </summary>
        public void ClearMoves()
        {
            _moves.Clear();
        }

        #endregion

        #region Simulation

        /// <summary>
        /// Runs simulation.
        /// </summary>
        public void RunSimulation()
        {
            // IMPLEMENT
        }

        #endregion

    }

}