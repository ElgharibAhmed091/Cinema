using Stripe.Checkout;

namespace Cinema.Service
{
    public class StripePaymentService
    {
        public string CreateCheckoutSession(double total)
        {
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(total * 100), // Stripe بالـ cents
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = "Cinema Tickets"
                        },
                    },
                    Quantity = 1,
                },
            },
                Mode = "payment",
                SuccessUrl = "https://localhost:7234/Order/Success",
                CancelUrl = "https://localhost:7234/Order/Cancel",
            };

            var service = new SessionService();
            var session = service.Create(options);

            return session.Url;
        }
    }
}