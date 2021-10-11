using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class FrmProjectionsAdministration : Form
    {
        public FrmProjectionsAdministration()
        {
            InitializeComponent();
            DataElements.initializeLists();
            initializeProjections();
        }
        void initializeProjections()
        {
            lbProjections.Items.Clear();
            foreach (Projection p in DataElements.lstPrj)
            {
                p.ProjectionDisplay = p.UniId + ") " + p.Movie.MovieName + " " + p.ProjectionDate.ToString("yyyy/MM/dd") + " -" + p.ProjectionStartTime + ". " +
                p.Theater.TheaterNumber;
                lbProjections.Items.Add(p.ProjectionDisplay);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbProjections.SelectedItem != null)
            {
                //Projection projection = (Projection)DataElements.lstPrj.Where(p => p.UniId == Convert.ToInt32(lbProjections.SelectedItem.ToString().Split(')')[0])).FirstOrDefault();
                foreach (Projection p in DataElements.lstPrj)
                {
                    if (p.UniId == Convert.ToInt32(lbProjections.SelectedItem.ToString().Split(')')[0]))
                    {
                        lbProjections.Items.Remove(lbProjections.SelectedItem);
                        DataElements.lstPrj.Remove(p);
                        DbManagement.insert_update_delete("delete from Projection1 where UniqueProjectionId1=" + p.UniId);
                        break;
                    }
                }
            }
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (lbProjections.SelectedItem != null)
            {

                Projection projection = (Projection)DataElements.lstPrj.Where(p => p.UniId == Convert.ToInt32(lbProjections.SelectedItem.ToString().Split(')')[0])).FirstOrDefault();
                FrmEditProjection frmEditProjection = new FrmEditProjection(projection);
                frmEditProjection.ShowDialog();
                if (frmEditProjection.DialogResult == DialogResult.OK)
                {
                    initializeProjections();
                }
            }
        }

        private void btwAddNew_Click(object sender, EventArgs e)
        {
            if (lbProjections.SelectedItem == null)
            {
                FrmNewProjection frmNewProjection = new FrmNewProjection();
                frmNewProjection.ShowDialog();
                if (frmNewProjection.DialogResult == DialogResult.OK)
                {
                    initializeProjections();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
