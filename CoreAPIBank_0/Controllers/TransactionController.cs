using CoreAPIBank_0.Models.ContextClasses;
using CoreAPIBank_0.Models.Entities;
using CoreAPIBank_0.RequestModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreAPIBank_0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        MyContext _db;
        public TransactionController(MyContext db)
        {
            _db = db;
        }

        //[HttpGet]
        //public List<PaymentRequestModel> GetInfoes()
        //{
        //    return _db.CardInfoes.Select(x => new PaymentRequestModel
        //    {
        //        CardNumber = x.CardNumber,
        //        CVC = x.CVC,
        //        CardUserName = x.CardUserName,
        //        ExpiryMonth = x.ExpiryMonth
        //    }).ToList();
        //}

        [HttpPost]
        public async Task<IActionResult> StartTransaction(PaymentRequestModel item)
        {
            if(_db.CardInfoes.Any(x => x.CardNumber == item.CardNumber && x.CVC == item.CVC && x.CardUserName == item.CardUserName)) //Kart bilgileri tutuyorsa(Aslında burada daha ayrıntılı bir kontrol yapılır)
            {
                UserCardInfo? uCInfo = await _db.CardInfoes.SingleOrDefaultAsync(x => x.CardNumber == item.CardNumber && x.CVC == item.CVC && x.CardUserName == item.CardUserName);
                #region TarihKontrolleri
                //if(uCInfo.ExpiryYear > DateTime.Now.Year)
                //{

                //}
                //else if(uCInfo.ExpiryYear == DateTime.Now.Year)
                //{
                //    if(uCInfo.ExpiryMonth > DateTime.Now.Month)
                //    {

                //    }
                //}
                //else
                //{
                //    return Ok("Kartınızın tarihi gecersiz");
                //} 
                #endregion

                if (uCInfo.Balance >= item.ShoppingPrice)
                {
                    #region UOW

                    //Unit Of Works
                    //Öncelikle kullanicinin balance'i düsürülür
                    //Komisyon alınır
                    //satıcıya net miktar gönderilir
                    //Ondan sonra kaydedilir 
                    #endregion
                    uCInfo.Balance -= item.ShoppingPrice; //Fiyat, kartın balance'inden düsüyor
                    await _db.SaveChangesAsync();

                    return Ok("Odeme basarıyla alındı");
                }
                else return StatusCode(400, "Kart bakiyesi yetersiz bulundu");
            }

            return StatusCode(400, "Kart bulunamadı");
        }
    }
}
