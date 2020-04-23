namespace Kolokwium1.Controllers

{

    [Route("api/prescriptions")]

    [ApiController]

    public class PrescriptionsController : ControllerBase

    {

        [HttpGet("{id}")]

        public IActionResult GetPerscription(int id)
        {
        using (SqlConnection con = new SqlConnection("Data Source = db-mssql; Initial Catalog=s18830; Integrated Security=True"))
                com.Connection = con;
                using (SqlCommand com = new SqlCommand())

                {

                try

                {
                    var list = new List<Prescriptions>();

                    var lista = new List<PrescriptionsMedicament>();
                    
                    com.Parameters.AddWithValue("IdPrescription", id);

                    com.CommandText = "select Name as 'lek',Type as 'rodzaj',Date as 'data wystawienia',DueDate as 'data waznosci',
Description as opis,Dose as dawka, IdPatient as 'pacjent nr.',IdDoctor as 'Doktor nr.' from Prescription_Medicament
JOIN Prescription on Prescription.IdPrescription = Prescription_Medicament.IdPrescription
JOIN Medicament on Medicament.IdMedicament = Prescription_Medicament.IdMedicament where IdPrescription =@id";

                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();
        
        
        }
        
    }
    
}
