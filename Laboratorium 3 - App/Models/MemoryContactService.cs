namespace Laboratorium_3___App.Models
{
    public class MemoryContactService : IContactService
    {
        private readonly Dictionary<int, Contact> _items = new Dictionary<int, Contact>();
        private int id = 1;

        IDateTimeProvider _timeProvider;
        public MemoryContactService(IDateTimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public void add(Contact _item)
        {
            int id = _items.Count != 0 ? _items.Keys.Max() : 0;
            _item.Id = id + 1;
            _item.Created = _timeProvider.GetDateTime();
            _items.Add(_item.Id, _item);
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
                DateTime originalCreated = _items[contact.Id].Created;
                contact.Created = originalCreated;
                _items[contact.Id] = contact;
            }
        }
    }
}
