using OrderManagementSystem.RequestResponse;

namespace OrderManagementSystem.Service
{
    public interface IOMSSevice
    {
        Task<List<UserResponse>> GetUsers();
        Task<List<PaymentResponse>> GetPayments(); //getall payment
        Task<List<RoleResponse>> GetRoles(); //role
        Task<List<ItemResponse>> GetItems(); //item
        Task<List<OrderResponse>> GetOrders(); //order
        Task<List<PaymentTypeResponse>> GetPaymentTypes(); //payment type
        Task<List<StatusResponse>> GetStatus(); //status
        Task<UserResponse> GetUserById(Guid id);
        Task<PaymentResponse> GetPaymentById(Guid id); //get 1 payment
        Task<RoleResponse> GetRoleById(Guid id); //role
        Task<ItemResponse> GetItemById(Guid id); //item
        Task<OrderResponse> GetOrderById(Guid id); //order
        Task<PaymentTypeResponse> GetPaymentTypeById(Guid id); //payment type
        Task<StatusResponse> GetStatusById(Guid id); //status
        Task<string> AddUser(UserResponse user);
        Task<string> AddPayment(PaymentResponse payment); //add payment
        Task<string> AddRole(RoleResponse role); //role
        Task<string> AddItem(ItemResponse item); //item
        Task<string> AddOrder(OrderResponse item); //order
        Task<string> AddPaymentType(PaymentTypeResponse paymenttype); //payment type
        Task<string> AddStatus(StatusResponse status); //status
        Task<string> UpdateUser(Guid id, UserResponse user);
        Task<string> UpdatePayment(Guid id, PaymentResponse payment); //update payment
        Task<string> UpdateRole(Guid id, RoleResponse role); //role
        Task<string> UpdateItem(Guid id, ItemResponse item); //item
        Task<string> UpdateOrder(Guid id, OrderResponse item); //order
        Task<string> UpdatePaymentType(Guid id, PaymentTypeResponse paymenttype); //payment type
        Task<string> UpdateStatus(Guid id, StatusResponse status); //status
        Task<string> DeleteUserById(Guid id);
        Task<string> DeletePaymentById(Guid id); //delete payment
        Task<string> DeleteRoleById(Guid id); //role
        Task<string> DeleteItemById(Guid id); //item
        Task<string> DeleteOrderById(Guid id); //order
        Task<string> DeletePaymentTypeById(Guid id); //payment type
        Task<string> DeleteStatusById(Guid id); //status
        
        //ORDER,PAYMENT,USER
        Task<AllDetailUserResponse> GetDetailsById(Guid id); //All details of user, payment, order

    }
}
