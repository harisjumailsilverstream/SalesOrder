using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalesOrder.DTOs;

namespace SalesOrder.Interfaces;

public interface IOrderRepository
{
    Task<List<OrderDto>> GetOrdersAsync(string keyword, DateTime? dateFrom, DateTime? dateTo);
    IQueryable<OrderDto> GetOrdersQueryable(string keyword, DateTime? dateFrom, DateTime? dateTo );
    Task<OrderDto> GetOrderByIdAsync(int id);
    Task<List<CustomerDto>> GetCustomersAsync();
    Task<OrderDto> CreateOrderAsync(OrderDto orderDto);
    Task<OrderDto> UpdateOrderAsync(OrderDto orderDto); // Tambahkan ini
    Task DeleteOrderAsync(long id);
}