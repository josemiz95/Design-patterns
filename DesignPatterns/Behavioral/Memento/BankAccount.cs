using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class BankAccount
    {
        private int balance;
        private List<Memento> changes = new List<Memento>();
        private int current;

        public BankAccount(int balance)
        {
            this.balance = balance;
            changes.Add(new Memento(balance));
        }

        public Memento Deposit(int amount)
        {
            balance += amount;
            var m = new Memento(balance);
            changes.Add(m);
            ++current;

            return m;
        }

        public void Restore(Memento m)
        {
            if (m != null)
            {
                balance = m.Balance;
                changes.Add(m);
                current = changes.Count - 1;
            }
        }

        public Memento Undo()
        {
            Memento m = null;
            if (current > 0)
            {
                m = changes[--current];
                balance = m.Balance;
            }

            return m;
        }

        public Memento Redo()
        {
            Memento m = null;
            if (current + 1 < changes.Count)
            {
                m = changes[++current];
                balance = m.Balance;
            }

            return m;
        }

        public override string ToString() => $"{nameof(balance)}: {balance}";
    }
}
