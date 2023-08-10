using Microsoft.AspNetCore.Mvc;
using OyunDukkani.Data;
using System.Text;

namespace OyunDukkani.Controllers
{
    public class OyunlarController : Controller
    {
        private readonly OyunlarContext db;

        public OyunlarController(OyunlarContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View(db.oyunlar.ToList());
        }

        public IActionResult Yeni()
        {
            string yeniBarkod;
            bool varMi;

            // Yeni bir barkod oluşturana kadar döngüde kalın
            do
            {
                yeniBarkod = BarkodUret(); // Rastgele 13 haneli sayı oluştur

                // Veritabanında aynı barkod numarası var mı diye kontrol edin
                varMi = db.oyunlar.Any(o => o.BarkodNumarasi == yeniBarkod);
            } while (varMi);

            // Yeni oyun modeli oluşturun ve barkod numarasını atayın
            var yeniOyun = new Oyunlar
            {
                BarkodNumarasi = yeniBarkod
            };
            return View(yeniOyun);
        }

        

        [HttpPost]
        public IActionResult Yeni(Oyunlar oyun)
        {
            if (ModelState.IsValid)
            {

                db.oyunlar.Add(oyun);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public string BarkodUret()
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 13; i++)
            {
                int digit = random.Next(10); 
                sb.Append(digit); 
            }

            string randomNumber = sb.ToString();
            return randomNumber;
        }
    }
}
