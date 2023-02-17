using System;
namespace escapeRoom.Models
{
	public class Group
	{
        public int Id { get; }
        static private int nextId = 1;
		public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
		public int GroupSize { get; set; }

		public Group()
		{
			Id = nextId;
			nextId++;
		}

		public Group(string phone, int groupSize) : this()
		{
			PhoneNumber = phone;
			GroupSize = groupSize;
		}

        public Group(string name, string phone, int groupSize) : this()
        {
			ContactName = name;
        }

        public override string ToString()
        {
			return "Group #" + Id + "\nSize: " + GroupSize + "\nPhone: " + PhoneNumber;
        }
        
    }
}

