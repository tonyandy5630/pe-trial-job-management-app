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
using System.Windows.Forms.VisualStyles;

namespace JobManagementWinApp
{
    public partial class frmManagement : Form
    {
        BindingSource bindingSource;
        ICandidateProfileRepository candidateRepo = new CandidateProfileRepository();
        IJobPostingRepository jobPostingRepo = new JobPostingRepository();
        bool IsFirstTimeLoad = true;
        public frmManagement()
        {
            InitializeComponent();
        }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            IEnumerable<CandidateProfile> profileList = candidateRepo.GetCandidateProfilesList();
            try
            {
                LoadCandidate(profileList);
                IsFirstTimeLoad = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearText()
        {
            txtCandidateID.Text = string.Empty;
            txtFullname.Text = string.Empty;
            txtPositingID.Text = string.Empty;
            txtProfileShortDesription.Text = string.Empty;
            txtProfileURL.Text = string.Empty;
            dtBirthday.Value = new DateTime();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchFullname = txtSearchName.Text;
                IEnumerable<CandidateProfile> searchProfile = candidateRepo.SearchCandidateByFullname(searchFullname);
                LoadCandidate(searchProfile);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCandidate(IEnumerable<CandidateProfile> toLoadList)
        {

            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = toLoadList;

                dgvCandidateProfile.DataSource = null;
                dgvCandidateProfile.DataSource = bindingSource;
                bindingSource.DataSource = toLoadList;

                txtCandidateID.DataBindings.Clear();
                txtFullname.DataBindings.Clear();
                txtPositingID.DataBindings.Clear();
                txtProfileShortDesription.DataBindings.Clear();
                txtProfileURL.DataBindings.Clear();
                dtBirthday.DataBindings.Clear();

                txtCandidateID.DataBindings.Add("Text", bindingSource, "CandidateId");
                txtFullname.DataBindings.Add("Text", bindingSource, "Fullname");
                txtPositingID.DataBindings.Add("Text", bindingSource, "PostingId");
                txtProfileShortDesription.DataBindings.Add("Text", bindingSource, "ProfileShortDescription");
                txtProfileURL.DataBindings.Add("Text", bindingSource, "ProfileUrl");
                dtBirthday.DataBindings.Add("Text", bindingSource, "Birthday");

                txtCandidateID.Enabled = false;
                txtPositingID.Enabled = false;

                dgvCandidateProfile.Columns["Posting"].Visible = false;
                dgvCandidateProfile.Columns["PostingID"].Visible = false;
                dgvCandidateProfile.Columns["ProfileShortDescription"].Visible = false;
                dgvCandidateProfile.Columns["ProfileUrl"].Visible = false;

                if (toLoadList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    //toLoadList.ToList().ForEach(item => dgvCandidateProfile[5, index].Value = item.PO);
                    if (toLoadList != null)
                    {
                        if(IsFirstTimeLoad)
                        {
                            DataGridViewColumn newCol = new DataGridViewColumn();
                            newCol.HeaderText = "PostingTitle";
                            newCol.Name = "PostingTitle";
                            newCol.CellTemplate = new DataGridViewTextBoxCell();
                            // add new column to list 
                            dgvCandidateProfile.Columns.Insert(dgvCandidateProfile.ColumnCount, newCol);
                        }
                        else
                        {
                            dgvCandidateProfile.Columns.Remove("PostingTitle");
                            DataGridViewColumn newCol = new DataGridViewColumn();
                            newCol.CellTemplate = new DataGridViewTextBoxCell();
                            newCol.HeaderText = "PostingTitle";
                            newCol.Name = "PostingTitle";
                            dgvCandidateProfile.Columns.Insert(dgvCandidateProfile.ColumnCount, newCol);
                        }

                        int numberOfColumnInGrid = dgvCandidateProfile.ColumnCount;
                        IJobPostingRepository jobRepo = new JobPostingRepository();
                        for (int i = 0; i < toLoadList.ToList().Count; i++)
                        {
                            //if(dgvCandidateProfile[numberOfColumnInGrid - 1, i] == null)
                            //{
                            //    dgvCandidateProfile[numberOfColumnInGrid - 1, i].Value = toLoadList.ToList().ElementAt(i).Posting.JobPostingTitle;
                            //}
                            //else
                            //{
                            //    dgvCandidateProfile[numberOfColumnInGrid - 1, i].Value = null;
                               
                            //}
                            dgvCandidateProfile[numberOfColumnInGrid - 1, i].Value = jobRepo.GetJobPostingByID(toLoadList.ElementAt(i).PostingId).JobPostingTitle;
                            //MessageBox.Show((toLoadList.ToList().ElementAt(i) == null).ToString());

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Delete this Candidate Profile?", "Delete Candidate", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    int deleteCandidateID = int.Parse(txtCandidateID.Text);
                    bool deleteSuccess = candidateRepo.DeleteCandidateById(deleteCandidateID);
                    if(deleteSuccess)
                    {
                        MessageBox.Show("Deleted sucessfuly");
                        IEnumerable<CandidateProfile> profileList = candidateRepo.GetCandidateProfilesList();
                        LoadCandidate(profileList);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmAddCandidateForm addForm = new frmAddCandidateForm();
            addForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CandidateProfile updateCand = new CandidateProfile
                {
                    CandidateId = int.Parse(txtCandidateID.Text),
                    Birthday = dtBirthday.Value,
                    Fullname = txtFullname.Text,
                    ProfileShortDescription = txtProfileShortDesription.Text,
                    ProfileUrl = txtProfileURL.Text,
                    PostingId = int.Parse(txtPositingID.Text),
                };
                bool updateSuccess = candidateRepo.UpdateCandidate(updateCand);
                if(updateSuccess)
                {
                    MessageBox.Show("Sucessfully");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            IEnumerable<CandidateProfile> profileList = candidateRepo.GetCandidateProfilesList();
            LoadCandidate(profileList);

        }
    }
}
