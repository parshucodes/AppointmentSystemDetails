namespace AppointmentSystemDetails;

class Appointment
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }

    public Appointment(string name, string description, DateTime date)
    {
        Name = name;
        Description = description;
        Date = date;
    }
}

class AppointSystem
{
    private List<Appointment> items;

    public AppointSystem()
    {
        items = new List<Appointment>();
    }

    public void AddPatient(Appointment appointment)
    {
        items.Add(appointment);
    }

    public void DisplayPatientInforamtion()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"Patient Name:{item.Name} \nDesription: {item.Description} \nDate of Appointment:{item.Date.ToShortDateString()} \n");
        }
        
    }
}