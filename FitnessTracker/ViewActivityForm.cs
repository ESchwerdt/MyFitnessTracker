using FTLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class ViewActivityForm : Form
    {
        public ViewActivityForm()
        {
            InitializeComponent();
        }
        public ViewActivityForm(Activity activity)
        {
            InitializeComponent();

            var notes = activity.ActivityNotes.Replace("~", Environment.NewLine);
            
            this.titleLabel.Text = activity.Title;
            this.dateLabel.Text = activity.ActivityStart.ToString("M/d/yyyy");
            this.durationValueLabel.Text = activity.ActivityDuration.ToString();
            this.distanceValueLabel.Text = activity.ActivityDistance.ToString();
            //this.notesValueLabel.Text = activity.ActivityNotes;
            this.notesValueLabel.Text = notes;
        }
    }
}
