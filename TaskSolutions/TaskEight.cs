using DatabaseSimulation;
using System.Collections.Generic;
using System.Linq;

namespace TaskSolutions
{
    public class TaskEight
    {
        List<TaskEightDatabase> databaseObject = new();
        public int id { get; set; }

        public TaskEight()
        {
            //Mock data
            databaseObject = new List<TaskEightDatabase>
            {
                new TaskEightDatabase(){ID = 1, Author = "Mr Author", Title = "Book One"},
                new TaskEightDatabase(){ID = 2, Author = "Mr Author", Title = "Book Two"},
                new TaskEightDatabase(){ID = 3, Author = "Mr Author", Title = "Book Three"}
            };
        }

        public int AddNewBook(string author, string title)
        {
            if(databaseObject.Count > 0)            
                id = databaseObject.Count + 1;

            else
            {
                id = 1;
            }

            var newBook = new TaskEightDatabase() { ID = id, Author = author, Title = title };

            databaseObject.Add(newBook);

            return id;
        }

        public List<string> DisplayBookDetails()
        {
            List<string> result = new List<string>();

            foreach (var book in databaseObject)
            {
                result.Add(book.Title +" "+ book.Author); 
            }
            return result;
        }

        public string SearchBookByTitle(string title)
        {
            var search = (from d in databaseObject where d.Title == title select d).ToList();

            if (search.Count != 0)
                return "Book found";
            else
            {
                return "Cannot find book check spelling";
            }
        }

        public string DeleteBookByID(int id)
        {
            //query id here
            if (id!=0)            
                return "found";
            
            else
            {
                return "book not found or available";
            }
        }

        //options method here
        //to allow users to 
        //choose options
        //preferably a switch 
        //statement
    }

}
