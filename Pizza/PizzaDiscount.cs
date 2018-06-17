using System.Collections.Generic;
using System.Linq;

namespace Pizza
{
    public delegate decimal DiscountPolicy(PizzaOrder order);

    public class BestDiscount {
        private List<DiscountPolicy> policies;

        public BestDiscount(List<DiscountPolicy> policies)
        {
            this.policies = policies;
        }

        public decimal ComputePolicy(PizzaOrder order) {
            return policies.Max(policy => policy.Invoke(order));
        }
    }

    public static class Policies {
        public static decimal BuyOneGetOneFree(PizzaOrder order) {
            var pizzas = order.Pizzas;
            if (pizzas.Count < 2)
                return 0m;
            return pizzas.Min(pizza => pizza.Price);
        }

        public static decimal FivePercentOffMoreThanFiftyDollars(PizzaOrder order) {
            decimal nonDiscounted = order.Pizzas.Sum(pizza => pizza.Price);
            return nonDiscounted >= 50 ? nonDiscounted * 0.05m : 0m;
        }

        public static decimal FiveDollarsOffStuffedCrust(PizzaOrder order)
        {
            return order.Pizzas.Sum(pizza => pizza.Crust == Crust.Stuffed ? 5m : 0m);
        }

        public static DiscountPolicy CreateBest(params DiscountPolicy[] policies) {
            return order => policies.Max(policy => policy.Invoke(order));
        }

        public static DiscountPolicy DiscountALLThePizzas() {
            return CreateBest(BuyOneGetOneFree, FivePercentOffMoreThanFiftyDollars, FiveDollarsOffStuffedCrust);
        }
    }
}
