using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codePractice
{
    public class BaseballPlayer
    {
        string _name;
        string _team;
        string _city;
        string _average;
        string _position;



        public BaseballPlayer(string name, string team, string city,string average, string position) 
        { 

           _name = name;
            _team = team;  
            _city = city;
            _average = average;
            _position =position;
                
        }

        public string Name { get => _name; set => _name = value; }
        public string Team { get => _team; set => _team = value; }
        public string City { get => _city; set => _city = value; }
        public string Average { get => _average; set => _average = value; }
        public string Position { get => _position; set => _position = value; }
    }
}
