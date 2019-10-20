using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Mars.Domain.Interfaces
{
    public interface ICommand
    {
        void ExcecuteCommand(string commands);
    }
}
