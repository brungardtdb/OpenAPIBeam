using System;
// Tekla Structures Namespace References
using Tekla.Structures.Model;
using T3D = Tekla.Structures.Geometry3d;

namespace OpenAPIBeam.Create
{
    public class CreateChannel
    {

        private T3D.Point start = new T3D.Point(0, 0, 0); // Start Point
        private T3D.Point finish = new T3D.Point(3000, 0, 0); // End Point

       
        string profileName; // Channel Profile
        string material; // Channel Material Type
        string beamClass; // Channel Class

        public String ProfileName { get; set; } // Channel Profile Property
        public String Material { get; set; } // Channel Material Property
        public String BeamClass { get; set; } // Channel Class Property

        // Create Channel
        Beam HRChannel = new Beam(); // Create Channel
        
        /* CreateChannel constructor that takes 3 arguements (the profile name, the
          material type, and the class of the beam)*/
        public CreateChannel(string ProfileName, string Material, string BeamClass)
        {

            profileName = ProfileName; // Set profile name
            material = Material; // Set material type
            beamClass = BeamClass; // Set beam class


            HRChannel.Profile.ProfileString = profileName; // Set channel profile
            HRChannel.Material.MaterialString = material; // Set channel material
            HRChannel.Class = beamClass; // Set channel class (as a string!)
            HRChannel.StartPoint = start; // Set start point at 0,0,0
            HRChannel.EndPoint = finish; // Set finish point at 1000,0,0



            // Inserts into model, doesn't show on screen
            HRChannel.Insert();

        }

      
            





    }
}
