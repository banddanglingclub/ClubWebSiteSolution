﻿using AnglingClubShared.DTOs;
using AnglingClubWebServices.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnglingClubWebServices.Interfaces
{
    public interface IPaymentsService
    {

        //List<Payment> GetPayments();
        //Task<string> CreateCheckoutSession(CreateCheckoutSessionRequest createCheckoutSessionRequest);
        Task<string> CreateCheckoutSession(CreateCustomCheckoutSessionRequest createCheckoutSessionRequest);

        Task<OrderDetailDto> GetDetail(string dbKey);

    }
}
