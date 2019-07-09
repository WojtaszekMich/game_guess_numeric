using ModelGry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ModelGry.Ruch;

namespace GraGUI.Ai
{
    public partial class AiGame
    {
        private int StartingNumber;
        private int EndingNumber;
        private int? LastPickedNumber = null;
        private bool? LastIsBigger = null;
        private int newRangeBeggining;
        private int newRangeEnding;
        public int PickedNumber { get; set; }

        private List<int> NumberHistory = new List<int>();

        public AiGame(int? startingNumber, int? endingNumber)
        {
            History = new List<Ruch>();
            Random rand = new Random();
            if (startingNumber == null)
                StartingNumber = rand.Next(0, 99);
            else
                StartingNumber = startingNumber.Value;

            if (endingNumber == null)
                EndingNumber = rand.Next(100, 300);
            else
                EndingNumber = endingNumber.Value;

            newRangeBeggining = StartingNumber;
            newRangeEnding = EndingNumber;
        }

        public int GetStartingNumber()
        {
            return StartingNumber;
        }

        public int GetEndingNumber()
        {
            return EndingNumber;
        }

        public int? PickFirstNumber()
        {
            LastPickedNumber = (EndingNumber + StartingNumber) / 2;
            NumberHistory.Add(LastPickedNumber.Value);
            NumberHistory.Add(LastPickedNumber.Value);
            return LastPickedNumber;
        }

        public int? PickNumber(bool isBigger)
        {
            if (LastIsBigger == null)
            {
                LastIsBigger = isBigger;
            }

            if (isBigger)
            {
                LastPickedNumber = PickBiggerNumber(LastPickedNumber.Value);
                History.Add(new Ruch(LastPickedNumber.Value, Odp.ZaDuzo));
            } else
            {
                LastPickedNumber = PickSmallerNumber(LastPickedNumber.Value);
                History.Add(new Ruch(LastPickedNumber.Value, Odp.ZaMalo));
            }
                

            NumberHistory.Add(LastPickedNumber.Value);
            LastIsBigger = isBigger;
            return LastPickedNumber;
        }

        public int PickBiggerNumber(int lastPickedNumber)
        {
                newRangeBeggining = lastPickedNumber;
                return (newRangeEnding + lastPickedNumber) / 2;
        }

        public int PickSmallerNumber(int lastPickedNumber)
        {
            newRangeEnding = lastPickedNumber;
            return (newRangeBeggining + lastPickedNumber) / 2;
        }

        public bool CheckIfBiggerNumber()
        {
            if (LastPickedNumber <= PickedNumber)   
                return false;
            else
                return true;
        }

        public bool CheckIfSmallerNumber()
        {
            if (LastPickedNumber >= PickedNumber)
                return false;
            else
                return true;
        }

        public void WinGame()
        {
            History.RemoveAt(History.Count - 1);
            History.Add(new Ruch(LastPickedNumber.Value, Odp.Trafiono));
        }

        public int GetLastPickedNumber()
        {
            return LastPickedNumber.Value;
        }
    }
}
