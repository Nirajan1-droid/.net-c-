using System;

// EventOrganizer interface which can organize events
public interface IEventOrganizer
{
    void OrganizeEvent();
}

// Concrete implementation of EventOrganizer
public class EventOrganizer : IEventOrganizer
{
    private string name;
    private string organizer;

    public EventOrganizer(string name, string organizer = null)
    {
        this.name = name;
        this.organizer = organizer;
    }

    public void OrganizeEvent()
    {
        if (organizer != null)
        {
            Console.WriteLine($"{name} is organized by {organizer}.");
        }
        else
        {
            Console.WriteLine($"{name} is organized independently.");
        }
    }
}

// College class which depends on IEventOrganizer
public class College
{
    private string name;
    private IEventOrganizer eventOrganizer;

    public College(string name, IEventOrganizer eventOrganizer)
    {
        this.name = name;
        this.eventOrganizer = eventOrganizer;
    }

    public void ConductEvent()
    {
        eventOrganizer.OrganizeEvent();
        Console.WriteLine("this event is hosted on "+name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of EventOrganizer
        IEventOrganizer organizer1 = new EventOrganizer("Tech Fest");
        IEventOrganizer organizer2 = new EventOrganizer("Cultural Night", "Student Council");

        // College instance
        College college = new College("ABC College", organizer1);
// it is recieving the instance of the IEventOrganizer to the college object through its constructor (called dependency injection)
        // College conducting event
        college.ConductEvent();  // Output: Tech Fest is organized independently.
//we are inverting the control of EventOrganier (as firstly object of the event being created seperatly) and then the college object asks for the object which may or may not available while passing in the constructor.

        // College changing organizer
        college = new College("CBD College", organizer2);
        college.ConductEvent();  // Output: Cultural Night is organized by Student Council.
    }
}
