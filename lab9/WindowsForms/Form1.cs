using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Media media = new Media();
        private int mediaId;
        private int personId;
        public string imageLocation;
        public IReadOnlyList<Media> allMedias;
        public MediaService MediaService = new MediaService();
        public  TagsService TagsService = new TagsService();
        public PersonsService PersonsService = new PersonsService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MediaUpdateButton.Enabled = false;
            MediaDeleteButton.Enabled = false;
            PopulateDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save
            media.Name = MediaNameInput.Text;
            media.Description = MediaDescriptionInput.Text;
            media.Event = MediaEventInput.Text;
            media.Location = MediaLocationInput.Text;
            media.Date = MediaDatePicker.Text;
            media.Type = MediaTypeSelect.Text;
            media.Path = openFileDialog1.FileName;

            MediaService.Create(media);
            PopulateDataGridView();
        }

        private void MediaResetButton_Click(object sender, EventArgs e)
        {
            MediaUpdateButton.Enabled = false;
            MediaDeleteButton.Enabled = false;
            PersonCreateButton.Enabled = false;
            MediaSaveButton.Enabled = true;
            clearFields();
            ClearPersonsGrid();
        }

        private void MediaName_Click(object sender, EventArgs e)
        {

        }


        void PopulateDataGridView()
        {
        allMedias = MediaService.GetAll();

        dataGridView1.DataSource = MediaService.GetAll();
        }

        void PopulatePersonsGrid()
        {
            PersonsGrid.DataSource = PersonsService.GetAll();
        }

        void ClearPersonsGrid()
        {
            PersonsGrid.DataSource = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //media 2x click
            MediaUpdateButton.Enabled = true;
            MediaDeleteButton.Enabled = true;
            PersonCreateButton.Enabled = true;
            MediaSaveButton.Enabled = false;
            var selectedRow = dataGridView1.CurrentRow.Index;
            mediaId = allMedias[selectedRow].Id;


            //mediaId = dataGridView1.CurrentRow.Index + 1;
            if (mediaId != -1)
            {
                var model = MediaService.GetById(mediaId);
                populateMediaFields(model);
            }

            PersonsGrid.DataSource =  PersonsService.GetByMediaId(mediaId);
        }

        private void populateMediaFields(Media model)
        {
            MediaNameInput.Text = model.Name;
            MediaDescriptionInput.Text = model.Description;
            MediaEventInput.Text =  model.Event;
            MediaLocationInput.Text = model.Location;
            MediaDatePicker.Text = model.Date;
            MediaTypeSelect.Text = model.Type;
            imageLocation = model.Path;
        }

        private void clearFields()
        {
            media = new Media();
            MediaNameInput.ResetText();
            MediaDescriptionInput.ResetText();
            MediaEventInput.ResetText();
            MediaLocationInput.ResetText();
            MediaDatePicker.ResetText();
            MediaTypeSelect.ResetText();
        }

        private void MediaUpdateButton_Click(object sender, EventArgs e)
        {
            media.Id = mediaId;
            media.Name = MediaNameInput.Text;
            media.Description = MediaDescriptionInput.Text;
            media.Event = MediaEventInput.Text;
            media.Location = MediaLocationInput.Text;
            media.Date = MediaDatePicker.Text;
            media.Type = MediaTypeSelect.Text;
            media.Path = openFileDialog1.FileName;
            MediaService.Update(media, mediaId);

            PopulateDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MediaDeleteButton_Click(object sender, EventArgs e)
        {
            MediaService.Delete(mediaId);
            PopulateDataGridView();
        }

        private void PersonNameInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            personId = PersonsGrid.CurrentRow.Index + 1;
            var person = PersonsService.GetById(personId);
            PersonNameInput.Text = person.Name;

        }

        private void PersonCreateButton_Click(object sender, EventArgs e)
        {
            var person = new Persons();
            person.MediaId = mediaId;
            person.Name = PersonNameInput.Text;

            PersonsService.Create(person);
            PopulatePersonsGrid();
        }

        private void PersonsUpdateButton_Click(object sender, EventArgs e)
        {
            var person = new Persons();
            person.MediaId = mediaId;
            person.Name = PersonNameInput.Text;

            PersonsService.Update(person, personId);
        }

        private void PersonsGrid_DoubleClick(object sender, EventArgs e)
        {
            personId = PersonsGrid.CurrentRow.Index + 1;
            var person = PersonsService.GetById(personId);
            PersonNameInput.Text = person.Name;
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*,*|";
            openFileDialog1.ShowDialog();

            imageLocation = openFileDialog1.FileName;

            //pictureBox1.ImageLocation = imageLocation;
        }

        private void ShouFileButton_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imageLocation;
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void SerachInput_TextChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 1)
            {
                var text = SerachInput.Text;
                var result = MediaService.SearchByName(text);
                SearchGrid.DataSource = result;
            }
        }
    }
}
