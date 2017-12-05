using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.Data.Infrastructure;
using Shop.Data.Repository;
using Shop.Model.Models;
using System.Linq;

namespace Shop.UniTest.RespositoryTest
{
    [TestClass]
    public class PostCategoryRespositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Respository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(5,list.Count);

        }

        [TestMethod]
        public void PostCategory_Respository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test category";
            category.Status = true;

            var result = objRepository.Add(category);

            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.ID);

        }
    }
}