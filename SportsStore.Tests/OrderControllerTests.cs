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

        [Fact]
        public void Cannot_Checkout_Invalid_ShippingDetails()
        {
            //Arrange - create repository imitation.
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();

            //Arrange - create cart with product.
            Cart cart = new Cart();
            cart.AddItem(new Product(), 1);

            //Arrange - create controller object.
            OrderController target = new OrderController(mock.Object, cart);

            //Arrange - add error to model.
            target.ModelState.AddModelError("error", "error");


            //Act - order checkout attempt.
            ViewResult result = target.Checkout(new Order()) as ViewResult;


            //Asserts - check if order wasn't transfered to repository.
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()), Times.Never);

            //Asserts - check if method returns default view.
            Assert.True(string.IsNullOrEmpty(result.ViewName));

            //Asserts - check if incorrect model is transfered to view.
            Assert.False(result.ViewData.ModelState.IsValid);

        }

        [Fact]
        public void Can_Checkout_And_Submit_Order()
        {
            //Arrange - create repository.
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();

            //Arrange - create cart with product.
            Cart cart = new Cart();
            cart.AddItem(new Product(), 1);

            //Arrange - create controller object.
            OrderController target = new OrderController(mock.Object, cart);


            //Act - attempt to checkout order.
            RedirectToActionResult result = target.Checkout(new Order()) as RedirectToActionResult;


            //Asserts - check if order wasn't transfered to repository.
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()), Times.Once);

            //Asserts - check if method redirects to action method Completed().
            Assert.Equal("Completed", result.ActionName);


        }
    }
}
