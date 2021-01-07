namespace API.Entities
{
    public class Connection
    {
        public Connection()
        {
            
        }
        public Connection(string connection, string username)
        {
            ConnectionId = connection;
            Username = username;
        }

        public string ConnectionId { get; set; }
        public string Username { get; set; }
    }
}