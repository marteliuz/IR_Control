using System.Net.Sockets;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("...::: EZ IRcontrol v0.0.0.0.1 :::...");
        Console.WriteLine(":::::: this version only control AOC Display and a little more :::...");
        Console.WriteLine(":::::: ");
        Console.WriteLine(":::::: ");
        Console.WriteLine(":::::: Choose your option:");
        Console.WriteLine(":::::: ☞ 0: exit");
        Console.WriteLine(":::::: ☞ 1: ON/OFF");
        Console.WriteLine(":::::: ☞ 2: VOLUME UP");
        Console.WriteLine(":::::: ☞ 3: VOLUME DOWN");
        Console.WriteLine(":::::: ☞ 4: MUTE/UNMUTE");
        Console.WriteLine(":::::: ");
        Console.WriteLine(":::::: ☞ B: BLUSTER TEST");

        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(input))
                continue;

            if (string.Equals(input, "0", StringComparison.OrdinalIgnoreCase))
                break;

            if (string.Equals(input, "1", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    string host = "192.168.0.50"; // Cambia por la IP real del CG-100
                    int port = 4998;

                    TelnetClient telnet = new TelnetClient(host, port);
                    // ON / OFF TOGGLE
                    telnet.SendCommand("sendir,2:1,1,39000,1,69,341,172,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,64,21,21,21,64,21,64,21,64,21,64,21,21,21,64,21,64,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,64,21,64,21,64,21,64,21,64,21,64,21,64,21,1612,341,86,21,3654\r\n");
                    Console.WriteLine("IR codes sent.");
                    telnet.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("I'm sorry, something happend while trying send the command. " + ex.Message.ToString());
                }
            }

            if (string.Equals(input, "2", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    string host = "192.168.0.50"; // Cambia por la IP real del CG-100
                    int port = 4998;

                    TelnetClient telnet = new TelnetClient(host, port);
                    // VOLUME UP
                    telnet.SendCommand("sendir,2:1,1,39000,1,69,341,172,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,64,20,20,20,64,20,64,20,64,20,64,20,20,20,64,20,20,20,20,20,64,20,64,20,20,20,20,20,20,20,20,20,64,20,64,20,20,20,20,20,64,20,64,20,64,20,64,20,1612,341,86,20,3654\r\n");
                    Console.WriteLine("IR codes sent.");
                    telnet.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("I'm sorry, something happend while trying send the command. " + ex.Message.ToString());
                }
            }

            if (string.Equals(input, "3", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    string host = "192.168.0.50"; // Cambia por la IP real del CG-100
                    int port = 4998;

                    TelnetClient telnet = new TelnetClient(host, port);
                    // VOLUME DOWN
                    telnet.SendCommand("sendir,2:1,1,39000,1,69,341,172,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,64,20,20,20,64,20,64,20,64,20,64,20,20,20,64,20,20,20,20,20,20,20,20,20,64,20,20,20,20,20,20,20,64,20,64,20,64,20,64,20,20,20,64,20,64,20,64,20,1612,341,86,20,3654\r\n");
                    Console.WriteLine("IR codes sent.");
                    telnet.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("I'm sorry, something happend while trying send the command. " + ex.Message.ToString());
                }
            }

            if (string.Equals(input, "4", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    string host = "192.168.0.50"; // Cambia por la IP real del CG-100
                    int port = 4998;

                    TelnetClient telnet = new TelnetClient(host, port);
                    // MUTE/UNMUTE
                    telnet.SendCommand("sendir,2:1,1,39000,1,69,341,172,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,64,21,21,21,64,21,64,21,64,21,64,21,21,21,64,21,21,21,21,21,64,21,21,21,21,21,21,21,21,21,21,21,64,21,64,21,21,21,64,21,64,21,64,21,64,21,64,21,1612,341,86,21,3654\r\n");
                    Console.WriteLine("IR codes sent.");
                    telnet.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("I'm sorry, something happend while trying send the command. " + ex.Message.ToString());
                }
            }



            // BLAST ZONE

            if (string.Equals(input, "B", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    string host = "192.168.0.50"; // Cambia por la IP real del CG-100
                    int port = 4998;

                    TelnetClient telnet = new TelnetClient(host, port);
                    //
                    //string cmd = "​sendir,2:2,1,38000,1,1,97,31,17,30,17,15,17,15,17,30,33,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,33,15,17,30,17,15,17,3010,97,31,17,30,17,15,17,15,17,30,33,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,33,15,17,30,17,15,17,3625";
                    telnet.SendCommand("sendir,2:2,1,38000,1,1,97,31,17,30,17,15,17,15,17,30,33,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,33,15,17,30,17,15,17,3010,97,31,17,30,17,15,17,15,17,30,33,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,17,15,33,15,17,30,17,15,17,362\r\n");
                    Console.WriteLine("IR codes sent.");
                    telnet.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("I'm sorry, something happend while trying send the command. " + ex.Message.ToString());
                }
            }

        }
    }
}


class TelnetClient
{
    private TcpClient tcpClient;
    private StreamWriter writer;
    private StreamReader reader;

    public TelnetClient(string host, int port)
    {
        tcpClient = new TcpClient(host, port);
        var stream = tcpClient.GetStream();
        writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true };
        reader = new StreamReader(stream, Encoding.ASCII);
    }

    public void SendCommand(string command)
    {
        writer.WriteLine(command);
    }

    public string ReadResponse()
    {
        if (tcpClient.Available > 0)
            return reader.ReadLine() ?? "";
        return "";
    }

    public void Close()
    {
        writer.Close();
        reader.Close();
        tcpClient.Close();
    }
}



// VGA/HDMI TOGGLE
//telnetClient.SendCommand("sendir,2:1,1,39000,1,69,341,172,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,64,21,21,21,64,21,64,21,64,21,64,21,21,21,64,21,21,21,64,21,64,21,21,21,21,21,21,21,21,21,21,21,64,21,21,21,21,21,64,21,64,21,64,21,64,21,64,21,1612,341,86,21,3654\r\n");
//Thread.Sleep(5000);
//telnetClient.SendCommand("sendir,2:1,1,39000,1,69,341,172,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,64,21,21,21,64,21,64,21,64,21,64,21,21,21,64,21,21,21,64,21,64,21,21,21,21,21,21,21,21,21,21,21,64,21,21,21,21,21,64,21,64,21,64,21,64,21,64,21,1612,341,86,21,3654\r\n");

// INPUT SCROLL (MENU)
//telnetClient.SendCommand("sendir,2:1,1,39000,1,69,341,172,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,64,20,20,20,64,20,64,20,64,20,64,20,20,20,64,20,20,20,20,20,20,20,64,20,20,20,20,20,20,20,20,20,64,20,64,20,64,20,20,20,64,20,64,20,64,20,64,20,1612,341,86,20,3654\r\n");

// CURSOR UP
//telnetClient.SendCommand("sendir,2:1,1,39000,1,69,341,171,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,64,20,20,20,64,20,64,20,64,20,64,20,20,20,64,20,64,20,64,20,20,20,64,20,20,20,20,20,20,20,20,20,20,20,20,20,64,20,20,20,64,20,64,20,64,20,64,20,1612,341,86,20,3654\r\n");

// ENTER
//telnetClient.SendCommand("sendir,2:1,1,38000,1,69,341,172,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,64,20,20,20,64,20,64,20,64,20,64,20,20,20,64,20,64,20,20,20,64,20,64,20,20,20,20,20,20,20,20,20,20,20,64,20,20,20,20,20,64,20,64,20,64,20,64,20,1612,341,86,20,3654\r\n");