using Microsoft.EntityFrameworkCore;
using OrderManagementSystem.Context;
using OrderManagementSystem.Models;
using OrderManagementSystem.RequestResponse;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OrderManagementSystem.Service
{
    public class OMSService : IOMSSevice
    {
        private readonly OMSContext _context;
        public OMSService(OMSContext context) 
        {
            _context = context;
        }

        //add user
        public async Task<string> AddUser(UserResponse user)
        {
            UserEntity obj = new UserEntity()
            {
                Id = Guid.NewGuid(),
                UserCode = user.UserCode,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Mobile = user.Mobile,
                Address = user.Address,
                RoleId = user.RoleId,
                IsActive = user.IsActive,
            };
            _context.Users.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }
        //add item
        public async Task<string> AddItem(ItemResponse item)
        {
            ItemEntity obj = new ItemEntity()
            {
                Id = Guid.NewGuid(),
                ItemCode = item.ItemCode,
                Name = item.Name,
                Description = item.Description,
                ActualPrice = item.ActualPrice,
                DiscountPrice = item.DiscountPrice,
                NewPrice = item.NewPrice,
                IsAvailable = item.IsAvailable,
                IsActive = item.IsActive,
            };
            _context.Items.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }
        //add order
        public async Task<string> AddOrder(OrderResponse order)
        {
            OrderEntity obj = new OrderEntity()
            {
                Id = Guid.NewGuid(),
                UserId = order.UserId,
                PaymentId = order.PaymentId,
                Date = order.Date,
                StatusId = order.StatusId,                
            };
            _context.Orders.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }
        //add payment
        public async Task<string> AddPayment(PaymentResponse payment)
        {
            PaymentEntity obj = new PaymentEntity()
            {
                Id = Guid.NewGuid(),
                UserId = payment.UserId,
                ProductId = payment.ProductId,
                ProductQuantity = payment.ProductQuantity,
                Amount = payment.Amount,
                Date = payment.Date,
                PaymentTypeId = payment.PaymentTypeId,
                StatusId = payment.StatusId,
            };
            _context.Payments.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }
        //add payment type
        public async Task<string> AddPaymentType(PaymentTypeResponse payment)
        {
            PaymentTypeEntity obj = new PaymentTypeEntity()
            {
                Id = Guid.NewGuid(),
                PaymentTypeCode = payment.PaymentTypeCode,
                Name = payment.Name,                
            };
            _context.PaymentTypes.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }
        //add status
        public async Task<string> AddStatus(StatusResponse st)
        {
            StatusEntity obj = new StatusEntity()
            {
                Id = Guid.NewGuid(),
                StatusCode = st.StatusCode,
                Name = st.Name,
            };
            _context.Status.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }
        //add role
        public async Task<string> AddRole(RoleResponse role)
        {
            RoleEntity obj = new RoleEntity()
            {
                Id = Guid.NewGuid(),
                RoleCode = role.RoleCode,
                Name = role.Name,
                Description = role.Description,
                IsActive = role.IsActive,
            };
            _context.Roles.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }

        //get all user
        public async Task<List<UserResponse>> GetUsers()
        {
            var res = await _context.Users.Select(item => new UserResponse
            {
                Id = item.Id,
                UserCode = item.UserCode,
                Name = item.Name,
                Email = item.Email,
                Password = item.Password,
                Mobile = item.Mobile,
                Address = item.Address,
                RoleId = item.RoleId,
                IsActive = item.IsActive,
            }).ToListAsync();
            return res;
        }

        //get all item
        public async Task<List<ItemResponse>> GetItems()
        {
            var res = await _context.Items.Select(item => new ItemResponse
            {
                Id = item.Id,
                ItemCode = item.ItemCode,
                Name = item.Name,
                Description = item.Description,
                ActualPrice = item.ActualPrice,
                DiscountPrice = item.DiscountPrice,
                NewPrice = item.NewPrice,
                IsAvailable = item.IsAvailable,
                IsActive = item.IsActive,
            }).ToListAsync();
            return res;
        }

        //get all order
        public async Task<List<OrderResponse>> GetOrders()
        {
            var res = await _context.Orders.Select(item => new OrderResponse
            {
                Id = item.Id,
                UserId = item.UserId,
                PaymentId = item.PaymentId,
                Date = item.Date,
                StatusId = item.StatusId,
            }).ToListAsync();
            return res;
        }

        //get all payments
        public async Task<List<PaymentResponse>> GetPayments()
        {
            var res = await _context.Payments.Select(item => new PaymentResponse
            {
                Id = item.Id,
                UserId = item.UserId,
                ProductId = item.ProductId,
                ProductQuantity = item.ProductQuantity,
                Amount = item.Amount,
                Date = item.Date,
                PaymentTypeId = item.PaymentTypeId,
                StatusId = item.StatusId,
            }).ToListAsync();
            return res;
        }
        //get all payment types
        public async Task<List<PaymentTypeResponse>> GetPaymentTypes()
        {
            var res = await _context.PaymentTypes.Select(item => new PaymentTypeResponse
            {
                Id = item.Id,
                PaymentTypeCode = item.PaymentTypeCode,
                Name = item.Name,
            }).ToListAsync();
            return res;
        }
        //get all status
        public async Task<List<StatusResponse>> GetStatus()
        {
            var res = await _context.Status.Select(item => new StatusResponse
            {
                Id = item.Id,
                StatusCode = item.StatusCode,
                Name = item.Name,
            }).ToListAsync();
            return res;
        }
        //get all role
        public async Task<List<RoleResponse>> GetRoles()
        {
            var res = await _context.Roles.Select(item => new RoleResponse
            {
                Id = item.Id,
                RoleCode = item.RoleCode,
                Name = item.Name,
                Description = item.Description,
                IsActive = item.IsActive,
            }).ToListAsync();
            return res;
        }
        //get single user
        public async Task<UserResponse> GetUserById(Guid id)
        {
            var res = await _context.Users.Where(item => item.Id == id).Select(item => new UserResponse
            {
                Id = item.Id,
                UserCode = item.UserCode,
                Name = item.Name,
                Email = item.Email,
                Password = item.Password,
                Mobile = item.Mobile,
                Address = item.Address,
                RoleId = item.RoleId,
                IsActive = item.IsActive,
            }).FirstOrDefaultAsync();
            return res;
        }
        //get single item
        public async Task<ItemResponse> GetItemById(Guid id)
        {
            var res = await _context.Items.Where(item => item.Id == id).Select(item => new ItemResponse
            {
                Id = item.Id,
                ItemCode = item.ItemCode,
                Name = item.Name,
                Description = item.Description,
                ActualPrice = item.ActualPrice,
                DiscountPrice = item.DiscountPrice,
                NewPrice = item.NewPrice,
                IsAvailable = item.IsAvailable,
                IsActive = item.IsActive,
            }).FirstOrDefaultAsync();
            return res;
        }
        //get single order
        public async Task<OrderResponse> GetOrderById(Guid id)
        {
            var res = await _context.Orders.Where(item => item.Id == id).Select(item => new OrderResponse
            {
                Id = item.Id,
                UserId = item.UserId,
                PaymentId = item.PaymentId,
                Date = item.Date,
                StatusId = item.StatusId,
            }).FirstOrDefaultAsync();
            return res;
        }
        //get single payment
        public async Task<PaymentResponse> GetPaymentById(Guid id)
        {
            var res = await _context.Payments.Where(item => item.Id == id).Select(item => new PaymentResponse
            {
                Id = item.Id,
                UserId = item.UserId,
                ProductId = item.ProductId,
                ProductQuantity = item.ProductQuantity,
                Amount = item.Amount,
                Date = item.Date,
                PaymentTypeId = item.PaymentTypeId,
                StatusId = item.StatusId,
            }).FirstOrDefaultAsync();
            return res;
        }
        //get single payment type
        public async Task<PaymentTypeResponse> GetPaymentTypeById(Guid id)
        {
            var res = await _context.PaymentTypes.Where(item => item.Id == id).Select(item => new PaymentTypeResponse
            {
                Id = item.Id,
                PaymentTypeCode = item.PaymentTypeCode,
                Name = item.Name,
            }).FirstOrDefaultAsync();
            return res;
        }
        //get single status
        public async Task<StatusResponse> GetStatusById(Guid id)
        {
            var res = await _context.Status.Where(item => item.Id == id).Select(item => new StatusResponse
            {
                Id = item.Id,
                StatusCode = item.StatusCode,
                Name = item.Name,
            }).FirstOrDefaultAsync();
            return res;
        }
        //get single role
        public async Task<RoleResponse> GetRoleById(Guid id)
        {
            var res = await _context.Roles.Where(item => item.Id == id).Select(item => new RoleResponse
            {
                Id = item.Id,
                RoleCode = item.RoleCode,
                Name = item.Name,
                Description = item.Description,
                IsActive = item.IsActive,
            }).FirstOrDefaultAsync();
            return res;
        }
        //delete user
        public async Task<string> DeleteUserById(Guid id)
        {
            var res = await _context.Users.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Users.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }
        //delete item
        public async Task<string> DeleteItemById(Guid id)
        {
            var res = await _context.Items.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Items.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }
        //delete order
        public async Task<string> DeleteOrderById(Guid id)
        {
            var res = await _context.Orders.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Orders.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }
        //delete payment
        public async Task<string> DeletePaymentById(Guid id)
        {
            var res = await _context.Payments.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Payments.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }
        //delete payment type
        public async Task<string> DeletePaymentTypeById(Guid id)
        {
            var res = await _context.PaymentTypes.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.PaymentTypes.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }
        //delete status
        public async Task<string> DeleteStatusById(Guid id)
        {
            var res = await _context.Status.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Status.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }
        //delete role
        public async Task<string> DeleteRoleById(Guid id)
        {
            var res = await _context.Roles.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Roles.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }
        //update user
        public async Task<string> UpdateUser(Guid id, UserResponse user)
        {
            var res = await _context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.UserCode = user.UserCode;
                res.Name = user.Name;
                res.Email = user.Email;
                res.Password = user.Password;
                res.Mobile = user.Mobile;
                res.Address = user.Address;
                res.RoleId = user.RoleId;
                res.IsActive = user.IsActive;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }
        //update item
        public async Task<string> UpdateItem(Guid id, ItemResponse item)
        {
            var res = await _context.Items.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.ItemCode = item.ItemCode;
                res.Name = item.Name;
                res.Description = item.Description;
                res.ActualPrice = item.ActualPrice;
                res.DiscountPrice = item.DiscountPrice;
                res.NewPrice = item.NewPrice;
                res.IsAvailable = item.IsAvailable;
                res.IsActive = item.IsActive;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }
        //update order
        public async Task<string> UpdateOrder(Guid id, OrderResponse order)
        {
            var res = await _context.Orders.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.UserId = order.UserId;
                res.PaymentId = order.PaymentId;
                res.Date = order.Date;
                res.StatusId = order.StatusId;
                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }
        //update payment
        public async Task<string> UpdatePayment(Guid id, PaymentResponse payment)
        {
            var res = await _context.Payments.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.UserId = payment.UserId;
                res.ProductId = payment.ProductId;
                res.ProductQuantity = payment.ProductQuantity;
                res.Amount = payment.Amount;
                res.Date = payment.Date;
                res.PaymentTypeId = payment.PaymentTypeId;
                res.StatusId = payment.StatusId;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }
        //update payment type
        public async Task<string> UpdatePaymentType(Guid id, PaymentTypeResponse payment)
        {
            var res = await _context.PaymentTypes.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.PaymentTypeCode = payment.PaymentTypeCode;
                res.Name = payment.Name;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }
        //update status
        public async Task<string> UpdateStatus(Guid id, StatusResponse payment)
        {
            var res = await _context.Status.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.StatusCode = payment.StatusCode;
                res.Name = payment.Name;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }
        //update role
        public async Task<string> UpdateRole(Guid id, RoleResponse role)
        {
            var res = await _context.Roles.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.RoleCode = role.RoleCode;
                res.Name = role.Name;
                res.Description = role.Description;
                res.IsActive = role.IsActive;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }

        //get single user with payment and order
        public async Task<AllDetailUserResponse> GetDetailsById(Guid id)
        {
            var result = await _context.Users
                .Join(
                    _context.Payments,
                    user => user.Id,
                    payment => payment.UserId,
                    (user, payment) => new { user, payment }
                )
                .Join(
                    _context.Orders,
                    combined => combined.user.Id,
                    order => order.UserId,
                    (combined, order) => new { combined.user, combined.payment, order }
                )
                .Where(x => x.user.Id == id)
                .ToListAsync();

            var res = result.Select(x => new AllDetailUserResponse
            {
                UserId = x.user.Id,
                UserCode = x.user.UserCode, 
                Name = x.user.Name,  
                Email = x.user.Email,
                Password = x.user.Password,
                Mobile = x.user.Mobile,
                Address = x.user.Address,
                PaymentId = x.payment.Id,
                ProductId = x.payment.ProductId,
                ProductQuantity = x.payment.ProductQuantity,
                Amount = x.payment.Amount,
                PaymentDate = x.payment.Date,
                PaymentTypeId = x.payment.PaymentTypeId,
                PaymentStatusId = x.payment.StatusId,
                OrderId = x.order.Id,
                OrderDate = x.order.Date,
                OrderStatusId = x.order.StatusId,
            }).FirstOrDefault(); 

            return res;
        }
    }
}
