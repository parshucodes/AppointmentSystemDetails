namespace AppointmentSystemDetails;
class Program
{
    static void Main(string[] args)
    {
        AppointSystem nose = new AppointSystem();
        Appointment raghupati = new Appointment("raghupati", "Stomach ache", new DateTime(2024, 02, 15));
        Appointment raghav = new Appointment("Raghav", "Mild Fever", new DateTime(2024, 02, 16));

        nose.AddPatient(raghav);
        nose.AddPatient(raghupati);

        nose.DisplayPatientInforamtion();
        Console.ReadLine();

    }
}