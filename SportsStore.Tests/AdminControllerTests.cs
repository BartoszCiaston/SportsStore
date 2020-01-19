using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using Xunit;

namespace SportsStore.Tests
{
    public class AdminControllerTests
    {
        [Fact]
        public void Index_Contains_All_Products()
        {
            //Arrange - create repository imitation.
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductID = 1, Name = "P1"},
                new Product {ProductID = 2, Name = "P2"},
                new Product {ProductID = 3, Name = "P3"}
            }.AsQueryable<Product>());

            //Arrange - create controller.
            AdminController target = new AdminController(mock.Object);

            //Act.
            Product[] result = GetViewModel<IEnumerable<Product>>(target.Index())?.ToArray();

            //Asserts.
            Assert.Equal(3, result.Length);
            Assert.Equal("P1", result[0].Name);
            Assert.Equal("P2", result[1].Name);
            Assert.Equal("P3", result[2].Name);
        }

        [Fact]
        public void Can_Edit_Product()
        {
            //Arrange - create repository imitation.
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product { ProductID = 1, Name = "P1"},
                new Product { ProductID = 2, Name = "P2"},
                new Product { ProductID = 3, Name = "P3"}
            }.AsQueryable<Product>());

            //Arrange - create controller.
            AdminController target = new AdminController(mock.Object);

            //Act.
            Product p1 = GetViewModel<Product>(target.Edit(1));
            Product p2 = GetViewModel<Product>(target.Edit(2));
            Product p3 = GetViewModel<Product>(target.Edit(3));

            //Asserts.
            Assert.Equal(1, p1.ProductID);
            Assert.Equal(2, p2.ProductID);
            Assert.Equal(3, p3.ProductID);
        }

        [Fact]
        public void Cannot_Edit_Nonexistent_Product()
        {
            //Arrange - create repository imitation.
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product { ProductID = 1, Name = "P1"},
                new Product { ProductID = 2, Name = "P2"},
                new Product { ProductID = 3, Name = "P3"}
            }.AsQueryable<Product>());

            //Arrange - create controller.
            AdminController target = new AdminController(mock.Object);

            //Act.
            Product result = GetViewModel<Product>(target.Edit(4));

            Assert.Null(result);
        }

        [Fact]
        public void Can_Save_Valid_Changes()
        {
            //Arrange - create repository imitation.
            Mock<IProductRepository> mock = new Mock<IProductRepository>();

            //Arrange - create TempData dictionary imitation.
            Mock<ITempDataDictionary> tempData = new Mock<ITempDataDictionary>();

            //Arrange - create controller.
            AdminController target = new AdminController(mock.Object)
            {
                TempData = tempData.Object
            };

            //Arrange - create product.
            Product product = new Product { Name = "Test" };


            //Act - attempt to save product.
            IActionResult result = target.Edit(product);

            //Asserts - verify if repository was called out.
            mock.Verify(m => m.SaveProduct(product));

            //Asserts - verify return type.
            Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", (result as RedirectToActionResult).ActionName);
        }

        [Fact]
        public void Cannot_Save_Invalid_Changes()
        {
            //Arrange - create repository imitation.
            Mock<IProductRepository> mock = new Mock<IProductRepository>();

            //Arrange - create controller.
            AdminController target = new AdminController(mock.Object);

            //Arrange - create product.
            Product product = new Product { Name = "Test" };

            //Arrange - add error to model state.
            target.ModelState.AddModelError("error", "error");

            //Act - attempt to save product.
            IActionResult result = target.Edit(product);

            //Asserts - verify if repository wasn't called out.
            mock.Verify(m => m.SaveProduct(It.IsAny<Product>()), Times.Never());

            //Asserts - verify return type.
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Can_Delete_Valid_Products()
        {
            //Arrange - create product.
            Product prod = new Product { ProductID = 2, Name = "Test" };

            //Arrange - create repository imitation.
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[] {
            new Product {ProductID = 1, Name = "P1" },
            new Product {ProductID = 3, Name = "P3" }
            }.AsQueryable<Product>());

            //Arrange - create controller.
            AdminController target = new AdminController(mock.Object);

            //Act - delete product.
            target.Delete(prod.ProductID);

            //Asserts - make sure that repository method was called out with correct product
            mock.Verify(m => m.DeleteProduct(prod.ProductID));

        }

        private T GetViewModel<T>(IActionResult result) where T : class
        {
            return (result as ViewResult)?.ViewData.Model as T;
        }
    }
}
