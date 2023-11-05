namespace Laboratorium_3___App.Models
{
    public class MemoryContactService : IContactService
    {
        private readonly Dictionary<int, Contact> _items = new Dictionary<int, Contact>();
        private int id = 1;
        public void add(Contact contact)
        {
            contact.Id = id++;
            _items.Add(contact.Id, contact);
        }

        public List<Contact> FindAll()
        {
            return _items.Values.ToList();
        }

        public Contact? FindByID(int id)
        {
            return _items[id];
        }

        public void RemoveByID(int id)
        {
            _items.Remove(id);
        }

        public void Update(Contact contact)
        {
            if (_items.ContainsKey(contact.Id))
            {
                _items[contact.Id] = contact;
            }
        }
    }
}
