using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventProject.Models
{
    public class SampleData : DropCreateDatabaseAlways<EventProjectDB>
    {
        protected override void Seed(EventProjectDB context)
        {
            var EventTypes = new List<EventType>
            {
                new EventType {Type = "Concerts"},
                new EventType {Type = "Dances"},
                new EventType  {Type = "Fairs"},
                new EventType  {Type = "Movie Screenings"},
                new EventType  {Type = "Musicals"},
                new EventType  {Type = "Plays"},
                new EventType  {Type = "Shopping"},
                new EventType  {Type = "Bar Trivia"},
                new EventType  {Type = "Yoga"},
                new EventType  {Type = "Sports"}
            };

       
            new List<Event>
            {
               // new Event {EventTitle = "Western Dance Night", EventDesc = "Enjoy dancing to country music", StartDate = "11/15/2019", EndDate = "11/15/2019",StartTime = "5:00 pm", EndTime = "8:00 pm", Location = "Cuyahoga Rec Center", EventType = EventTypes.Single(e => e.Type == "Dances"), MaxTix = 2, AvailableTix = 150, OrgName = "Tom"},  //Past
                new Event {EventTitle = "Star Wars Marathon", EventDesc = "Watching all Star Wars movies in order", StartDate = "12/25/2019" , EndDate = "12/26/2019", StartTime ="12:00 pm" , EndTime ="12:00 am" , Location = "AMC Theatre", EventType = EventTypes.Single(e => e.Type == "Movie Screenings"), MaxTix = 6, AvailableTix = 200, OrgName = "Alex"},
            //    new Event {EventTitle = "Star Wars Trivia", EventDesc = "Test your knowledge on Star Wars and win  prizes", StartDate = "11/15/2019", EndDate = "11/15/2019", StartTime = "7:00 pm", EndTime = "9:00 pm", Location = "Davids Place", EventType = EventTypes.Single(e => e.Type == "Bar Trivia"), MaxTix = 4, AvailableTix = 100, OrgName = "Alec"}, //past
                new Event {EventTitle = "Ohio State Watch Party", EventDesc = "Watch Ohio State Play against Clemson Tigers", StartDate = "12/20/2019", EndDate ="12/20/2019" , StartTime = "12:00 pm", EndTime = "3:00 pm", Location = "OSU Campus", EventType = EventTypes.Single(e => e.Type == "Sports"), MaxTix = 12, AvailableTix = 1000, OrgName = "Matt"},
             //   new Event {EventTitle = "Polish Fair", EventDesc = "Experience Polish Culture", StartDate = "11/20/2019", EndDate ="11/23/2019" , StartTime = "10:00 am", EndTime = "4:00 pm", Location = "Tri-C Western Campus", EventType = EventTypes.Single(e => e.Type == "Fairs"), MaxTix = 6, AvailableTix = 600, OrgName = "Ricky"}, //past
             //   new Event {EventTitle = "Hamlet Play", EventDesc = "Enjoy Shakespeare's Hamlet as a play ", StartDate = "11/02/2019", EndDate ="11/02/2019" , StartTime = "11:00 am", EndTime = "1:30 pm", Location = "Playhouse Square", EventType = EventTypes.Single(e => e.Type == "Plays"), MaxTix =10, AvailableTix = 500, OrgName = "Alexis"}, //past
             //   new Event {EventTitle = "Black Friday Shopping Spree at Target", EventDesc = "Do your Black Friday shopping at Target for discounts", StartDate = "11/29/2019", EndDate ="11/29/2019" , StartTime = "6:00 am", EndTime = "11:00 pm", Location = "Target", EventType = EventTypes.Single(e => e.Type == "Shopping"), MaxTix = 2, AvailableTix = 130, OrgName = "Mark"}, //past
                new Event {EventTitle = "Cats the Musical", EventDesc = "Enjoy the musical Cats on Broadway", StartDate = "01/02/2020", EndDate ="01/02/2020" , StartTime = "10:00 am", EndTime = "12:00 pm", Location = "Broadway Theatre", EventType = EventTypes.Single(e => e.Type == "Musicals"), MaxTix = 5, AvailableTix = 600, OrgName = "Eli" },
                new Event {EventTitle = "EDM Dance Night", EventDesc = "Dance with others to EDM", StartDate = "03/02/2020", EndDate ="03/03/2020" , StartTime = "8:00 pm", EndTime = "2:00 am", Location = "Cleveland NightClub", EventType = EventTypes.Single(e => e.Type == "Dances"), MaxTix = 4, AvailableTix = 200, OrgName = "Anthony" },
                new Event {EventTitle = "Cornhole Games", EventDesc = "Bring your team to compete eachother in games of Cornhole", StartDate = "01/06/2020", EndDate ="01/06/2020" , StartTime = "12:00 pm", EndTime = "4:00 pm", Location = "Cuyahoga Rec Center", EventType = EventTypes.Single(e => e.Type == "Sports"), MaxTix = 2, AvailableTix = 20, OrgName = "Chet" },

                new Event {EventTitle = "Yoga Class", EventDesc = "Relax and do yoga as a class", StartDate = "12/15/2019", EndDate ="12/15/2019" , StartTime = "3:00 pm", EndTime = "6:00 pm", Location = "Cuyahoga Rec Center", EventType = EventTypes.Single(e => e.Type == "Yoga"), MaxTix = 4, AvailableTix = 40, OrgName = "Sam"},
                new Event {EventTitle = "The Play of Romeo and Juliet", EventDesc = "Enjoy a performance of Shakespeare's Hamlet", StartDate = "02/11/2020", EndDate ="02/11/2020" , StartTime = "6:00 pm", EndTime = "9:00 pm", Location = "Playhouse Square", EventType = EventTypes.Single(e => e.Type == "Plays"), MaxTix = 10, AvailableTix = 500, OrgName = "Sebastion"},
                new Event {EventTitle = "Tyler the Creator's Camp Flog Gnaw", EventDesc = "A carnival style music festivel", StartDate = "12/20/2019", EndDate ="12/23/2019" , StartTime = "6:00 pm", EndTime = "12:00 am", Location = "Dodger's Stadium", EventType = EventTypes.Single(e => e.Type == "Concerts"), MaxTix = 10, AvailableTix = 600, OrgName = "Max"},
                new Event {EventTitle = "Bowling Tournament", EventDesc = "A bowling tournament, compete against other teams for prizes ", StartDate = "01/15/2020", EndDate = "01/15/2020" , StartTime = "4:00 pm", EndTime = "8:00 pm", Location = "Yorktown Lanes", EventType = EventTypes.Single(e => e.Type == "Sports"), MaxTix = 4, AvailableTix = 80, OrgName = "David"},
                new Event {EventTitle = "Disney Movie Marathon", EventDesc = "We'll be screening 3 random Disney movies back to back", StartDate = "02/06/2020", EndDate ="02/06/2020" , StartTime = "12:00 pm", EndTime = "7:00 pm", Location = "AMC Theatre", EventType = EventTypes.Single(e => e.Type == "Movie Screenings"), MaxTix = 6, AvailableTix = 200, OrgName = "James"},
                new Event {EventTitle = "Kanye West Concert", EventDesc = "Kanye West performs songs from his previous albums", StartDate = "03/02/2020", EndDate ="03/02/2020" , StartTime = "8:30 pm", EndTime = "12:30 am", Location = "OSU Campus", EventType = EventTypes.Single(e => e.Type == "Concerts"), MaxTix = 4, AvailableTix = 150, OrgName = "Nico"},
                new Event {EventTitle = "Indoor Mini Golf", EventDesc = "Have games of mini golf", StartDate = "12/02/2019", EndDate ="12/02/2019" , StartTime = "12:00pm", EndTime = "6:00 pm", Location = "Cuyahoga Rec Center", EventType = EventTypes.Single(e => e.Type == "Sports"), MaxTix = 2, AvailableTix = 40, OrgName = "Kanny"},
                new Event {EventTitle = "Disny's High School Musical", EventDesc = "Bring your kids to see the musical performed live", StartDate = "02/20/2020", EndDate ="02/20/2020" , StartTime = "12:00 pm", EndTime = "3:00 pm", Location = "Playhouse Square", EventType = EventTypes.Single(e => e.Type == "Musicals"), MaxTix = 4, AvailableTix = 200, OrgName = "Zack"},
                new Event {EventTitle = "Rib N Rock", EventDesc = "Enjoy BBQ and rock music", StartDate = "07/15/2020", EndDate ="07/18/2020" , StartTime = "4:00 pm", EndTime = "9:00 pm", Location = "Tri-c Western Campus", EventType = EventTypes.Single(e => e.Type == "Fairs"), MaxTix = 5, AvailableTix = 300, OrgName = "Dom"},
                new Event {EventTitle = "90's Bar Trivia", EventDesc = "Get quized on things from the 90's", StartDate = "02/06/2020", EndDate ="02/06/2020" , StartTime = "2:00 pm", EndTime = "6:00 pm", Location = "Fat Fish Blue", EventType = EventTypes.Single(e => e.Type == "Bar Trivia"), MaxTix = 4, AvailableTix = 60, OrgName = "Charles"},

                new Event {EventTitle = "John Williams Performance with Cleveland Orchestra", EventDesc = "John Williams Conducts music from the Star Wars Movies", StartDate = "12/06/2019", EndDate ="12/06/2019" , StartTime = "6:00 pm", EndTime = "8:30 pm", Location = "Playhouse Square", EventType = EventTypes.Single(e => e.Type == "Concerts"), MaxTix = 6, AvailableTix = 150, OrgName = "John"},
                new Event {EventTitle = "Rock N Roll Dance Night", EventDesc = "Dance out to  classic rock music", StartDate = "12/03/2019", EndDate ="12/03/2019" , StartTime = "7:00 pm", EndTime = "11:00 pm", Location = "The Velvet Dog", EventType = EventTypes.Single(e => e.Type == "Dances"), MaxTix = 2, AvailableTix = 20, OrgName = "Dave"},
                new Event {EventTitle = "David Bowie Listening Party", EventDesc = "Remember the works of David Bowie by listening to his music", StartDate = "01/10/2020", EndDate ="01/10/2020" , StartTime = "5:00 pm", EndTime = "8:00 pm", Location = "Nathan Hale Park", EventType = EventTypes.Single(e => e.Type == "Concerts"), MaxTix =6 , AvailableTix = 30, OrgName = "Nate"},
                new Event {EventTitle = "Pool Night", EventDesc = "Enjoy Discount drinks and free games of pool", StartDate = "04/06/2020", EndDate ="04/06/2020" , StartTime = "8:00 pm", EndTime = "11:00 pm", Location = "David's Place", EventType = EventTypes.Single(e => e.Type == "Sports"), MaxTix = 2, AvailableTix = 15, OrgName = "David"},
                new Event {EventTitle = "Indiana Jones Movie Marathon", EventDesc = "Watch all Indiana Jones movies in order", StartDate = "03/15/2020", EndDate ="03/16/2020" , StartTime = "6:00 pm", EndTime = "1:00 am", Location = "AMC Theatre", EventType = EventTypes.Single(e => e.Type == "Movie Screenings"), MaxTix = 10, AvailableTix = 100, OrgName = "Suzanne"},
                new Event {EventTitle = "German Festivel", EventDesc = "Celebrate German Heritage by Enjoying German food, music, and culture", StartDate = "12/15/2019", EndDate ="12/17/2019" , StartTime = "5:00 pm", EndTime = "10:00 pm", Location = "Tri-c Western Campus", EventType = EventTypes.Single(e => e.Type == "Fairs"), MaxTix = 2, AvailableTix = 50, OrgName = "Will"},
                new Event {EventTitle = "Death of a Salesman Play", EventDesc = "Experience a live performance of Death of a Salesman", StartDate = "01/20/2020", EndDate ="01/20/2020" , StartTime = "4:00 pm", EndTime = "6:00 pm", Location = "Playhouse Square", EventType = EventTypes.Single(e => e.Type == "Plays"), MaxTix = 5, AvailableTix = 60, OrgName = "Jess"},
                new Event {EventTitle = "Shop till you Drop", EventDesc = "Enjoy a shopping experience with plenty of discounts", StartDate = "02/20/2020", EndDate ="02/20/2020" , StartTime = "7:00 am", EndTime = "11:00 pm", Location = "Don's Market", EventType = EventTypes.Single(e => e.Type == "Shopping"), MaxTix = 2, AvailableTix = 20, OrgName = "Don"},
                new Event {EventTitle = "Yoga Night", EventDesc = "Relax your body with yoga", StartDate = "01/22/2020", EndDate ="01/22/2020" , StartTime = "11:00 am", EndTime = "2:00 pm", Location = "Tri-c Western Campus", EventType = EventTypes.Single(e => e.Type == "Yoga"), MaxTix = 4, AvailableTix = 20, OrgName = "Eliza"},
                new Event {EventTitle = "Free Tennis", EventDesc = "Promote physical activity with free games of tennis all day long", StartDate = "06/02/2020", EndDate ="06/02/2020" , StartTime = "12:00 pm", EndTime = "6:00 pm", Location = "Memorial Park Tennis Courts", EventType = EventTypes.Single(e => e.Type == "Sports"), MaxTix =  4, AvailableTix = 15, OrgName = "Nick"}

                // new Event {EventTitle = "", EventDesc = "", StartDate = "", EndDate ="" , StartTime = "", EndTime = "", Location = "", EventType = "", MaxTix = , AvailableTix = },

            }.ForEach(e => context.Events.Add(e));

        }
    }
}