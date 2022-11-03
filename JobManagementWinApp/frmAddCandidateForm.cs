using JobManagementLibrary.DataAccess;
using JobManagementLibrary.Repository;
using JobManagementLibrary.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobManagementWinApp
{
    public partial class frmAddCandidateForm : Form
    {
        IJobPostingRepository jobPostingRepo = new JobPostingRepository();
        ICandidateProfileRepository candidateProfileRepository = new CandidateProfileRepository();
        public frmAddCandidateForm()
        {
            InitializeComponent();
        }

        private void frmAddCandidateForm_Load(object sender, EventArgs e)
        {
            IEnumerable<JobPosting> list = jobPostingRepo.GetJobPostings();
            foreach (JobPosting jobPosting in list)
            {
                comboPostingTitle.Items.Add(jobPosting.JobPostingTitle);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            try
            {
                int postingId = jobPostingRepo.GetJobPostingIdByTitle(comboPostingTitle.Text);

                CandidateProfile addCandidate = new CandidateProfile
                {
                    CandidateId = int.Parse(txtCandidateId.Text),
                    Fullname = txtCandidateName.Text,
                    Birthday = dtBirthday.Value,
                    ProfileShortDescription = txtProfileDesc.Text,
                    ProfileUrl = txtURL.Text,
                    PostingId = postingId,
                };

                bool addSuccess = candidateProfileRepository.AddNewCandidate(addCandidate);
                if (addSuccess)
                {
                    MessageBox.Show("Add Successfully");
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Reset()
        {
            txtCandidateId.Text = null;
            txtCandidateName.Text = null;
            dtBirthday.Value = new DateTime();
            txtProfileDesc.Text = null;
            txtURL.Text = null;
        }
    }
}
