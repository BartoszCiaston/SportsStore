using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using Xunit;

namespace SportsStore.Tests
{
    public class OrderControllerTests
    {
        [Fact]
        public void Cannot_Checkout_Empty_Cart()
        {
            //Arrange - create repository imitation.
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();

            //Arrange - create empty cart.
            Cart cart = new Cart();

            //Arrange - create order.
            Order order = new Order();

            //Arrange - create controller object.
            OrderController target = new OrderController(mock.Object, cart);


            //Act.
            ViewResult result = target.Checkout(order) as ViewResult;

            //Asserts - check if order was put into repository.
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()), Times.Never);

            //Asserts - check if method returns default view.
            Assert.True(string.IsNullOrEmpty(result.ViewName));

            //Asserts - check if model  sent to view is correct.
            Assert.False(result.ViewData.ModelState.IsValid);

        }
    }
}
