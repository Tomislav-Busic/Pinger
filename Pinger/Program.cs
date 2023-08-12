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
int timeout = 120;
string address = "4.2.2.2";

PingReply reply = pingSender.Send(address, timeout, buffer, optionsPing);

if (reply.Status == IPStatus.Success)
{
    Console.WriteLine("Success");
}
