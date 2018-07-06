using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, Dictionary<string, long>> trainStation = new Dictionary<string, Dictionary<string, long>>();

            string validInputPattern = @"^(?<trainName>[^ \-:>=]+?) -> (?<wagonName>[^ \-:>=]+?) : (?<wagonPower>[\d]+?)$";
            string input = string.Empty;

            string addWagonsPatternToTrain = @"^(?<leftsideTrainName>[^ \-:>=]+?) -> (?<rightsideWagonName>[^ \-:>=]+?)$";
            string equalPattern = @"^(?<leftside>[^ \-:>=]+?) = (?<rightside>[^ \-:>=]+?)$";

            while ((input = Console.ReadLine()) != "It's Training Men!")
            {

                if (Regex.IsMatch(input, validInputPattern))
                {
                    Match infoToken = Regex.Match(input, validInputPattern);
                    string trainName = infoToken.Groups["trainName"].Value;
                    string wagonName = infoToken.Groups["wagonName"].Value;
                    int wagonPower = int.Parse(infoToken.Groups["wagonPower"].Value);
                    
                    if (!trainStation.ContainsKey(trainName))
                    {
                        trainStation[trainName] = new Dictionary<string, long>();
                    }

                    if (!trainStation[trainName].ContainsKey(wagonName))
                    {
                        trainStation[trainName][wagonName] = 0;
                    }

                    if (trainStation[trainName].ContainsKey(wagonName))
                    {
                        trainStation[trainName][wagonName] += wagonPower; 
                    }
                }
                
                if (Regex.IsMatch(input, addWagonsPatternToTrain))
                {
                    Match sides = Regex.Match(input, addWagonsPatternToTrain);
                    string leftsidetrainName = sides.Groups["leftsideTrainName"].Value;
                    string rightsidetrainName = sides.Groups["rightsideWagonName"].Value;
                    

                    if (!trainStation.ContainsKey(leftsidetrainName) && trainStation.ContainsKey(rightsidetrainName))
                    {

                        trainStation[leftsidetrainName] = new Dictionary<string, long>();
                        
                        foreach (var wagon in trainStation[rightsidetrainName])
                        {
                            trainStation[leftsidetrainName].Add(wagon.Key, wagon.Value);
                        }

                        trainStation.Remove(rightsidetrainName);


                    }
                    else 
                    {
                        foreach (var wagon in trainStation[rightsidetrainName])
                        {
                            trainStation[leftsidetrainName].Add(wagon.Key, wagon.Value);
                        }
                        trainStation.Remove(rightsidetrainName);
                    }

                }

                if (Regex.IsMatch(input, equalPattern))
                {
                    Match sides = Regex.Match(input, equalPattern);
                    string leftsidetrainName = sides.Groups["leftside"].Value;
                    string rightsidetrainName = sides.Groups["rightside"].Value;
                    
                    if (!trainStation.ContainsKey(leftsidetrainName))
                    {
                        trainStation[leftsidetrainName] = new Dictionary<string, long>();
                    }

                    trainStation[leftsidetrainName].Clear(); 

                    foreach (var wagons in trainStation[rightsidetrainName])
                    {
                        trainStation[leftsidetrainName].Add(wagons.Key, wagons.Value);
                    }

                }
            }
            

            foreach (var train in trainStation
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Value.Count))
            {
                string trainToken = train.Key;
                var wagonsAndPowers = train.Value;

                Console.WriteLine($"Train: {trainToken}");

                foreach (var wagonAndPower in wagonsAndPowers.OrderByDescending(x => x.Value))
                {
                    string wagon = wagonAndPower.Key;
                    long power = wagonAndPower.Value;

                    Console.WriteLine($"###{wagon} - {power}");
                }
            }

        }
    }
}