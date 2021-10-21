using System;
using System.Collections.Generic;//For LinkedList

namespace Builder
{
    public interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        
        void InsertWheels();
        void AddHeadlights();
        void EndOperations();
        Product GetVehicle();
    }
}