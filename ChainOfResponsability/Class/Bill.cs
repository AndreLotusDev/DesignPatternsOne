using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Class
{
    public class Bill
    {
        public int QuantityInStock { get; set; }
        public int Value { get; set; }

        public int QuantitiesOfWitDraw { get; set; }

        public Bill NextBill { get; set; }
        public Bill(int quantity, int value)
        {
            QuantityInStock = quantity;
            Value = value;
        }

        public void SetNextBill(Bill bill)
        {
            NextBill = bill;
        }

        public double WithDraw(double value)
        {
            if((value - Value) >= 0)
            {
                if (value > 0 && QuantityInStock > 0)
                {
                    QuantityInStock--;
                    QuantitiesOfWitDraw++;
                    var valueTemp = value -= Value;
                    return this.WithDraw(valueTemp);
                }
                else if (value > 0)
                {
                    return NextBill?.WithDraw(value) ?? value;
                }

                return value;
            }

            return value;
        }

        public override string ToString()
        {
            return $"\nQuantidades de retiradas da nota do valor - {Value}R$ - : {QuantitiesOfWitDraw}";
        }
    }
}
