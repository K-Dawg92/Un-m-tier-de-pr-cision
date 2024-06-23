using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Un_métier_de_précision
{
    internal class Building
    {
        public int floorLevel {  get; set; }
        public int heightOfBuilding { get; set; }
       
        // constructor initialising both floor level and height of building
        public Building(int floorLevel, int heightBuilding)
        {
            this.floorLevel = floorLevel;
            this.heightOfBuilding = heightBuilding;
        }
        // constructor initialising only the floor level by calculating the height
        public Building(int floorLevel) 
        {
            this.floorLevel = floorLevel;    
            this.heightOfBuilding = floorLevel*3;
        }
        //  renvoie la taille maximum que peut faire un étage du bâtiment
        public int GetFloorMaxSize()
        {
            return heightOfBuilding / floorLevel;
        }
        // renvoie la taille du bâtiment
        public int GetSize()
        {
            return heightOfBuilding;
        }
        // renvoie le nombre d'étages du bâtiment
        public int GetFloorCount()
        {
            return floorLevel*3;
        }
    }
}
