namespace ServerSideHW1.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }

		static List<User> UsersList = new List<User>();

		public User(int id, string name, string email, string password, bool isActive = true)
		{
			Id = id;
			Name = name;
			Email = email;
			Password = password;
			IsActive = isActive;
		}

		public User()
		{
		}

		public bool Insert()
		{
			foreach (User user in UsersList)
			{
				if (Id == user.Id)
				{
					return false;
				}
			}
			UsersList.Add(this);
			return true;
		}

		public static List<User> Read()
		{
			return UsersList;
		}
	}
}
