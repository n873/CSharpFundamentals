using System.Linq;

namespace Pizza
{
    class PizzaOrderingSystem
    {
        readonly DiscountPolicy discountPolicy;
        public PizzaOrderingSystem(DiscountPolicy discountPolicy)
        {
            this.discountPolicy = discountPolicy;
        }

        public decimal ComputePrice(PizzaOrder order)
        {
            decimal nonDiscounted = order.Pizzas.Sum(pizza => pizza.Price);
            decimal discountValue = discountPolicy(order);
            return nonDiscounted - discountValue;
        }

    }
}
