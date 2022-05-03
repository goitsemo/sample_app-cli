using System;

namespace ConsoleApp
{
    interface ILoyaltyCardHolder
    {
        int TotalPoints { get; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }
}