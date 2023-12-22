namespace oms_d
{
	public class userProfile
	{
		private string userID;
		private string userName;

		public userProfile(string userID, string userName)
		{
			this.userID = userID;
			this.userName = userName;
		}

		public string UserID { get { return userID; } set { userID = value; } }
		public string UserName { get { return userName; } set {  userName = value; } }
	}
}
