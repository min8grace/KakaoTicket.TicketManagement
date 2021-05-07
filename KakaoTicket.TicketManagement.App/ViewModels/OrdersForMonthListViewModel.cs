using System;

namespace KakaoTicket.TicketManagement.App.ViewModels
{
    public class OrdersForMonthListViewModel
    {
        public Guid Id { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}
