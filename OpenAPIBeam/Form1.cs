using System;
using System.Windows.Forms;
using OpenAPIBeam.Create;
// Tekla Structures Namespace References
using Tekla.Structures.Model;



namespace OpenAPIBeam
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            // Connect Model
            Model Model = new Model();

            // Check to see if model is connected
            ModelValidation CheckModel = new ModelValidation(Model);

            //Create 10X15.3 channel using new instance of CreateChannel class
            CreateChannel HRChannel = new CreateChannel("C10X15.3", "A992", "9");           

            //Commit changes to model
            Model.CommitChanges();
        }
    }
}
