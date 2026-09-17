using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05.DieGame
{
    internal class PairOfDice
    {
        private Die die1;
        private Die die2;
        public PairOfDice()
        {
            die1 = new Die();
            die2 = new Die();
        }
        public void Roll()
        {
            die1.roll();
            die2.roll();
        }

        public int getDiceScore()
        {
            return die1.Face + die2.Face;
        }

        public bool isDouble()
        {
            return die1.Face == die2.Face;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not PairOfDice) return false;
            return (this.die1.Equals(((PairOfDice)obj).die2) && this.die2.Equals(((PairOfDice)obj).die1)) || (this.die1.Equals(((PairOfDice)obj).die1) && this.die2.Equals(((PairOfDice)obj).die2));
        }

        public override int GetHashCode()
        {
            return die1.GetHashCode() + die2.GetHashCode();
        }

        public override string ToString()
        {
            return $"Pair of dice: [{die1.Face}], [{die2.Face}]";
        }
    }
    
    
}
