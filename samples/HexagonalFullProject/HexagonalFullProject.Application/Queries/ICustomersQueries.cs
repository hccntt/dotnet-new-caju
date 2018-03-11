﻿namespace HexagonalFullProject.Application.Queries
{
    using HexagonalFullProject.Application.Results;
    using System;
    using System.Threading.Tasks;

    public interface ICustomersQueries
    {
        Task<CustomerResult> GetCustomer(Guid id);
    }
}