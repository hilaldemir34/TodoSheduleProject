using Project.Models;

namespace Project.CQRS.Handler
{
    public class CreateEventCommandHandler
    {
        private readonly CalendarContext _calendarContext;
        public CreateEventCommandHandler(CalendarContext calendarContext)
        {
            _calendarContext = calendarContext;
        }
        public void Handle(Event @event)
        {
            _calendarContext.Events.Add(new Event
            {
                Color = @event.Color,
                End= @event.End,    
                Start = @event.Start,   
                Text = @event.Text
            });    
            _calendarContext.SaveChanges(); 
        }
    }
}
