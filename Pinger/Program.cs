using System.Net.NetworkInformation;
using System.Text;

// Pinging Google DNS Server 4.2.2.2

Ping pingSender = new();
PingOptions optionsPing = new()
{
    DontFragment = true
};

string data = "Learn to code";
byte[] buffer = Encoding.ASCII.GetBytes(data);

