using MvcDemo.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class DefaultController : Controller
    {
        private Good good = new Good();
        private GoodsDBEntities1 entities = new GoodsDBEntities1();

        // GET: Default
        public ActionResult Index()
        {
            var goods = entities.Goods.ToList();
            ViewBag.goods = goods;
            return View();
        }

        public ActionResult Delete(int id)
        {
            good.GoodsID = id;
            entities.Goods.Attach(good);
            entities.Entry(good).State = EntityState.Deleted;
            entities.SaveChanges();
            return Content("ok");
        }
    }
}