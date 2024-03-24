using HospitalManagementSystem;
using HospitalManagementSystem.Database;
using HospitalManagementSystem.Forms;
using HospitalManagementSystem.Forms.LoginForms;
using HospitalManagementSystem.Helper;

namespace HospitalManagementSystem
{
    public partial class LoginGUI : Form
    {
        Helper.Helper helper;
        public LoginGUI()
        {
            InitializeComponent();          
        }
        private void LoginGUI_Load(object sender, EventArgs e)
        {
            // Panelde Default MainLoginButtons ac
            helper = new Helper.Helper(panelFormController);
            MainLoginButtons mainLoginButtons = new MainLoginButtons(panelFormController);
            helper.formGoster(mainLoginButtons, mainLoginButtons.Name);

            var hasta = new Patient()
            {
                name = "bilal",
                surname = "cifci",
                GSM_No = "05441220426",
                identification = "34786885728",
                password = "Password",
                againPassword = "Password"
            };
            var doktor = new Doctor()
            {
                name = "bilal",
                surname = "cifci",
                GSM_No = "05441220426",
                identification = "34786885728",
                password = "Password",
                branch = "Kalp"
            };
            var sekreter = new Secretary()
            {
                name = "bilal",
                surname = "cifci",
                GSM_No = "05441220426",
                identification = "34786885728",
                password = "Password",
                locationClinic = "Yesil Alan"
            };
            var admin = new Admin()
            {
                name = "bilal",
                surname = "cifci",
                GSM_No = "05441220426",
                identification = "34786885728",
                password = "Password",
                
            };

            using (var context = new HospitalDbContext())
            {
                context.Patients.Add(hasta);
                context.Doctors.Add(doktor);
                context.Admins.Add(admin);
                context.Secretarys.Add(sekreter);
                //context.SaveChanges();
            }
        }
    }
}
