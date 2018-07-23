
using System.Windows.Forms;
// Tekla Structures Namespace References
using Tekla.Structures.Model;

namespace OpenAPIBeam
{
    class ModelValidation
    {

        public ModelValidation(Model Model)
        {
           
            // Check model connection status
            if (!Model.GetConnectionStatus())
            {
                MessageBox.Show("Tekla Structures is not connected, please connect to Tekla Structures");
                return;
            }
        }
    }
}
