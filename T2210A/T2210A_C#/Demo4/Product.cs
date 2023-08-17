using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_C_.Demo4
{
    public delegate void UpdateQtyHandler(int n);
    public class Product
    {
        private int qty;
        public event UpdateQtyHandler QtyChanged;
        public Product()
        {
            QtyChanged = NotifychangeQty;

        }
        public int Qty
        {
            get => qty;
            set => qty = value;
        }
        public void NotifychangeQty(int n)
        {
            Console.WriteLine("Qty of product was changed " + n);
        }
        public void SendEmailToAdmin(int n)
        {

        }
        public void SendEmailToStoreManager(int n)
        {

        }
        public void IncrementQty(int q)
        {
            if(q>0)
            {
                qty += q;
                QtyChanged(q);
            }
        }
    }
}
