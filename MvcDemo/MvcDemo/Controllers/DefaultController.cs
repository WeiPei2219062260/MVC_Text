using MvcDemo.Models;
using System.Linq;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class DefaultController : Controller
    {
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
            var goods = entities.Goods.FirstOrDefault(x => x.GoodsID == id);
            entities.Goods.Remove(goods);
            entities.SaveChanges();
            return Content("OK");
        }
    }
}