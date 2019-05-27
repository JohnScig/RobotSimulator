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
        Finish = 3,
        Moved = 4
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
        public Point CurrentRobotPosition { get; set; }
        public string EndOfGame { get; set; } = "Could't get to the finish";

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
            if (CurrentCellType == eCellType.Start)
                CurrentRobotPosition = new Point(x, y);
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
                case eCellType.Moved: return 'R';
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
            //_moves.Enqueue(UpMove);
            _moves.Enqueue(point => new Point(--point.X, point.Y));
        }

        public Point UpMove(Point from)
        {
            return new Point(--from.X, from.Y);
        }

        /// <summary>
        /// Adds move down.
        /// </summary>
        public void SetDownMove()
        {
            //_moves.Enqueue(DownMove);
            _moves.Enqueue(point => new Point(++point.X, point.Y));
        }

        public Point DownMove(Point from)
        {
            return new Point(++from.X, from.Y);
        }

        /// <summary>
        /// Adds move left.
        /// </summary>
        public void SetLeftMove()
        {
            //_moves.Enqueue(LeftMove);
            _moves.Enqueue(point => new Point(point.X, --point.Y));
        }

        public Point LeftMove(Point from)
        {
            return new Point(from.X, --from.Y);
        }

        /// <summary>
        /// Adds move right.
        /// </summary>
        public void SetRightMove()
        {
            //_moves.Enqueue(RightMove);
            _moves.Enqueue(point => new Point(point.X, ++point.Y));
        }

        public Point RightMove(Point from)
        {
            return new Point(from.X, ++from.Y);
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
            CurrentCellType = eCellType.Moved;
            int iteration = _moves.Count;

            for (int i = 0; i < iteration; i++)
            {
                CurrentRobotPosition = _moves.Dequeue().Invoke(CurrentRobotPosition);

                if (CheckFail())
                {
                    EndOfGame = "Oops, you failed";
                    break;
                }

                if (CheckWin())
                {
                    EndOfGame = "Finish! YAY!";
                    break;
                }


                SetTile(CurrentRobotPosition.X, CurrentRobotPosition.Y);
            }
        }

        public bool CheckWin()
        {
            if (GetTile(CurrentRobotPosition.X, CurrentRobotPosition.Y) == 'F')
            { return true; }

            return false;
        }

        public bool CheckFail()
        {

            if (CurrentRobotPosition.X < 0 || CurrentRobotPosition.X > 9 || CurrentRobotPosition.Y > 9 || CurrentRobotPosition.Y < 0)
            { return true; }

            if (GetTile(CurrentRobotPosition.X, CurrentRobotPosition.Y) == 'X')
            { return true; }

            return false;
        }

        #endregion

    }

}