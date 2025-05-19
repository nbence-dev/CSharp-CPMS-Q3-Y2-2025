namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> drones = new Dictionary<string, int>
            {
                { "1", 0 },
                { "2", 0 },
                { "3", 0 },
                { "4", 0 },
                { "5", 0 }
            };

            Random random = new Random();
            List<string> keys = new List<string>(drones.Keys);
            string winner = "";
            bool foundWinner = false;
            bool finishedRace = false;
            while (!finishedRace)
            {
                string randomKey = keys[random.Next(keys.Count)];
                if (drones[randomKey] < 25)
                {
                    drones[randomKey] += random.Next(1, 6);// Random speed between 1 and 3
                    Console.WriteLine($"Drone {randomKey} covered: {drones[randomKey]} km");
                    if (drones[randomKey] >= 25 && !foundWinner)
                    {
                        winner = randomKey;
                        foundWinner = true;
                    }
                    finishedRace = true;
                    foreach (var kvp in drones)
                    {
                        if (kvp.Value < 25)
                        {
                            finishedRace = false;
                            break;
                        }
                    }
                    Thread.Sleep(1000);
                }
                 
                
            }
            Console.WriteLine($"Drone {winner} is the winner!");
        }

    }
}
