using System;

namespace Mike.Spikes.Windsor101
{
    public delegate DateTime Now();

    public class PaymentService : IPaymentService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IBus bus;
        private readonly Now now;

        public PaymentService(IAccountRepository accountRepository, IBus bus, Now now)
        {
            this.accountRepository = accountRepository;
            this.bus = bus;
            this.now = now;
        }

        public void Start()
        {
            bus.Subscribe<PayCustomer>(PayCustomerHandler);
        }

        public void PayCustomerHandler(PayCustomer payCustomer)
        {
            var account = accountRepository.GetAccountByCustomerId(payCustomer.CustomerId);
            account.MakePayment(payCustomer.Amount, now());
        }
    }
}