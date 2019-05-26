using System;
using System.Windows.Forms;

namespace ActionRobot
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// View model.
        /// </summary>
        private ViewModel _viewModel;

        /// <summary>
        /// Ctor.
        /// </summary>
        public frmMain()
        {
            _viewModel = new ViewModel();

            InitializeComponent();

            for (int i = 0; i < ViewModel.AREA_SIZE; i++)
            {
                grdArea.Columns.Add($"col{i}", string.Empty);
                grdArea.Columns[i].Width = (grdArea.Width / ViewModel.AREA_SIZE - 1);

                grdArea.Rows.Add();
                grdArea.Rows[i].Height = (grdArea.Height / ViewModel.AREA_SIZE - 1);                
            }
        }

        private void cmdUp_Click(object sender, EventArgs e)
        {
            _viewModel.SetUpMove();
        }

        private void cmdLeft_Click(object sender, EventArgs e)
        {
            _viewModel.SetLeftMove();
        }

        private void cmdDown_Click(object sender, EventArgs e)
        {
            _viewModel.SetDownMove();
        }

        private void cmdRight_Click(object sender, EventArgs e)
        {
            _viewModel.SetRightMove();
        }

        private void optStart_CheckedChanged(object sender, EventArgs e)
        {
            if (optStart.Checked)
                _viewModel.CurrentCellType = eCellType.Start;
        }

        private void optWall_CheckedChanged(object sender, EventArgs e)
        {
            if (optWall.Checked)
                _viewModel.CurrentCellType = eCellType.Wall;
        }

        private void optFinish_CheckedChanged(object sender, EventArgs e)
        {
            if (optFinish.Checked)
                _viewModel.CurrentCellType = eCellType.Finish;
        }

        private void cmdClearTiles_Click(object sender, EventArgs e)
        {
            _viewModel.ClearArea();
            grdArea.Refresh();
        }

        private void grdArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _viewModel.SetTile(e.RowIndex, e.ColumnIndex);
            grdArea.Refresh();
        }

        private void grdArea_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.Value = _viewModel.GetTile(e.RowIndex, e.ColumnIndex);
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            _viewModel.RunSimulation();
        }

        private void cmdClearMoves_Click(object sender, EventArgs e)
        {
            _viewModel.ClearMoves();
        }       
    }
}