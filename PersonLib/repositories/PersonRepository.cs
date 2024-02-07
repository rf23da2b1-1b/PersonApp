using PersonLib.model;

namespace PersonLib.repositories
{
    public class PersonRepository
    {
        //aggregering til person
        private readonly List<Person> _personer;


        // constructor
        public PersonRepository()
        {
            _personer = new List<Person>();
        }


        // CRUD metoder
        public List<Person> GetAll()
        {
            return new List<Person>(_personer);
        }


        public Person GetById(int id)
        {
            Person? person = _personer.Find(p => p.Id == id);
            if (person == null)
            {
                throw new KeyNotFoundException();
            }

            return person;
        }

        public Person Add(Person person)
        {
            person.Id = NextId();
            _personer.Add(person);
            return person;
        }

        public Person Delete(int id)
        {
            Person person = GetById(id);
            _personer.Remove(person);
            return person;
        }

        public Person Update(int id, Person person)
        {
            Person updatePerson = GetById(id);
            int ix = _personer.IndexOf(updatePerson);
            _personer[ix] = person;
            return person;
        }


        // hjælpe funktion
        public int NextId()
        {
            int id;
            if (_personer.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = _personer.Max(p => p.Id) + 1;
            }

            return id;
        }
    }
}
