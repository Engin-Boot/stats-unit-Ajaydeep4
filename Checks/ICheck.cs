using System;

namespace Checks
{
    public interface ICheck
    {
        bool checkElement(double threshold, double element);
    }
}
