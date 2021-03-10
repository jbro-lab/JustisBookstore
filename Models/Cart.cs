using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustisBookstore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Book bk, int qty)//made virtual so we can override
        {
            CartLine Line = Lines.Where(b => b.Book.BookId == bk.BookId)
                .FirstOrDefault();

            if (Line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = bk,
                    Quantity = qty,

                });
            }
            else
            {
                Line.Quantity += qty;
            }
        }

        public virtual void RemoveLine(Book book)//made virtual so we can override
        {
            Lines.RemoveAll(b => b.Book.BookId == book.BookId);
        }

        public virtual void Clear() => Lines.Clear();//made virtual so we can override

        public double ComputeTotalSum()
        {
           return (Lines.Sum(e => e.Book.price * e.Quantity));
        }

        public class CartLine
        {
            public int CartLineID { get; set; }

            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
