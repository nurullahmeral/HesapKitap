using System;
using System.Collections.Generic;
using hesapkitap.business.Abstract;
using hesapkitap.data.Abstract;
using hesapkitap.data.Concrete.EfCore;
using hesapkitap.entity;


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace HesapKitap.Controllers
{
    
    public class HomeController : Controller
    {
        
        private IHomeService _homeService;
        private IGunSonuKategoriService _gunSonuKategoriService;
        private ITransferEkleService _transferEkleService;
        private IGiderEkleService _giderEkleService;
        private IGunSonuTutarService _gunSonuTutarService;
        private IGiderKategoriService _giderKategoriService;
        private IUrunKategoriService _urunKategoriService;
        private ITransferKalemiService _transferKalemiService;
        private IDegerKisitlaService _degerKisitlaService;
        
        
        
        public HomeController(IHomeService homeService,IGunSonuKategoriService gunSonuKategoriService,ITransferEkleService transferEkleService,IGiderEkleService giderEkleService,IGunSonuTutarService gunSonuTutarService,IGiderKategoriService giderKategoriService,IUrunKategoriService urunKategoriService,ITransferKalemiService transferKalemiService,IDegerKisitlaService degerKisitlaService)
        {
            this._homeService = homeService;
            this._gunSonuKategoriService = gunSonuKategoriService;
            this._transferEkleService = transferEkleService;
            this._giderEkleService = giderEkleService;
            this._gunSonuTutarService = gunSonuTutarService;
            this._giderKategoriService = giderKategoriService;
            this._urunKategoriService = urunKategoriService;
            this._transferKalemiService = transferKalemiService;
            this._degerKisitlaService = degerKisitlaService;
            
            
        }
        

        public IActionResult Index()
        {


            return View();
        }

        public IActionResult About()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult TarihKisitla(DegerKisitla degerKisitla){
            _degerKisitlaService.Create(degerKisitla);
            
            
            return RedirectToAction("Gunsonurapor");
        }
        public IActionResult GunsonuraporGenel(){
            var homeViewModel = new HomeViewModels(){
                
                GunSonu =  _homeService.GetAll(),
                
                GunSonuTutars = _gunSonuTutarService.GetAll(),
                
                

            };
            return View(homeViewModel);

        }
        public IActionResult GunsonuDetay(){
            var homeViewModel = new HomeViewModels(){
                // Categories = category,
                GunSonu =  _homeService.GetAll(),
                GunSonuKategoris = _gunSonuKategoriService.GetAll(),
                TransferKalemis = _transferKalemiService.GetAll(),
                
            };
            return View(homeViewModel);

        }
        public IActionResult Nakitakisi(){
            var homeViewModel = new HomeViewModels(){
                // Categories = category,
                GunSonu =  _homeService.GetAll(),
                GunSonuKategoris = _gunSonuKategoriService.GetAll(),
                TransferKalemis = _transferKalemiService.GetAll(),
                GunSonuTutars = _gunSonuTutarService.GetAll()
                // GunSonuTutars = GunSonuTutarRepository.GunSonuTutars
            };

            return View(homeViewModel);
        }
        public IActionResult Giderlerigor(){
            var homeViewModel = new HomeViewModels(){
                
                // GunSonu =  HomeRepository.Homes,
                GiderEkles = _giderEkleService.GetAll()
                
                

            };
            return View(homeViewModel);
        }
        public IActionResult Transferlerigor(){
            var homeViewModel = new HomeViewModels(){
                
                // GunSonu =  HomeRepository.Homes,
                TransferEkles = _transferEkleService.GetAll()
                
                

            };
            return View(homeViewModel);
        }
        public IActionResult Gunsonukategoriekle(){
            var homeViewModel = new HomeViewModels(){
                // Categories = category,
                GunSonu =  _homeService.GetAll(),
                GunSonuKategoris = _gunSonuKategoriService.GetAll()
                // GunSonuTutars = GunSonuTutarRepository.GunSonuTutars
            };
            
            return View(homeViewModel);
            
        }
        [HttpPost]
        public IActionResult Gunsonukategoriekle(Home p){
            _homeService.Create(p);
            var homeViewModel = new HomeViewModels(){
                // Categories = category,
                GunSonu =  _homeService.GetAll(),
                GunSonuKategoris = _gunSonuKategoriService.GetAll()
                // GunSonuTutars = GunSonuTutarRepository.GunSonuTutars
            };
            
            return View(homeViewModel);
        }
        public IActionResult Transferekle(){
            var homeViewModel = new HomeViewModels(){
                // Categories = category,
                TransferEkles =  _transferEkleService.GetAll(),
                TransferKalemis = _transferKalemiService.GetAll()
                // GunSonuTutars = GunSonuTutarRepository.GunSonuTutars
            };
            return View(homeViewModel);
        }

        [HttpPost]
        public IActionResult Transferekle(TransferEkle transferEkle){
            var homeViewModel = new HomeViewModels(){
                // Categories = category,
                TransferEkles =  _transferEkleService.GetAll(),
                TransferKalemis = _transferKalemiService.GetAll()
                // GunSonuTutars = GunSonuTutarRepository.GunSonuTutars
            };
            
            _transferEkleService.Create(transferEkle);
            return View(homeViewModel);
        }
        public IActionResult Giderekle(){
            var homeViewModel = new HomeViewModels(){
                
                GiderKategoris =  _giderKategoriService.GetAll(),
                UrunKategoris = _urunKategoriService.GetAll(),
                
                
                

            };
            return View(homeViewModel);
          
        }
        [HttpPost]
        public IActionResult Giderekle(GiderEkle giderEkle){
            var homeViewModel = new HomeViewModels(){
                
                GiderKategoris =  _giderKategoriService.GetAll(),
                UrunKategoris = _urunKategoriService.GetAll(),
                
                
                

            };

            _giderEkleService.Create(giderEkle);
            
            return View(homeViewModel);
        }
        public IActionResult Gunsonurapor(){
            
           
            var homeViewModel = new HomeViewModels(){
                
                GunSonu =  _homeService.GetAll(),

                DegerKisitlas = _degerKisitlaService.GetAll(),
                
                
                GunSonuTutars = _gunSonuTutarService.GetAll(),
                
                
                

            };
            
            return View(homeViewModel);
            
        }
        public IActionResult Gunsonu(){
           
            
            var homeViewModel = new HomeViewModels(){
                // Categories = category,
                GunSonu =  _homeService.GetAll(),
                GunSonuKategoris = _gunSonuKategoriService.GetAll(),
                GiderEkles = _giderEkleService.GetAll(),
                // GunSonuTutars = GunSonuTutarRepository.GunSonuTutars
            };
            
            return View(homeViewModel);
            
        }
        [HttpPost]
        public IActionResult Gunsonu(List<GunSonuTutar> gunSonuTutars){
            var context = new HesapKitapContext();
            var homeViewModel = new HomeViewModels(){
                // Categories = category,
                GunSonu =  _homeService.GetAll(),
                GunSonuKategoris = _gunSonuKategoriService.GetAll(),
                GiderEkles = _giderEkleService.GetAll(),
                // GunSonuTutars = GunSonuTutarRepository.GunSonuTutars
            };
            // _gunSonuTutarService.Create(gunSonuTutar);
            context.GunSonuTutars.AddRange(gunSonuTutars);
            context.SaveChanges();
            // _gunSonuTutarService.Create(gunSonuTutars);
            
            
            

            
            
            return View(homeViewModel);
        }
        public IActionResult DeleteGunSonu(int id){
            // Console.Write(id);
            var entity = _homeService.GetById(id);
            if(entity!=null){
                _homeService.Delete(entity);
            }
            return RedirectToAction("Gunsonukategoriekle");
        }
        public IActionResult GiderKategoriEkle(GiderKategori giderEkle){
            _giderKategoriService.Create(giderEkle);

            return RedirectToAction("Giderekle");

        }
        public IActionResult UrunKategoriEkle(UrunKategori urunKategori){

            _urunKategoriService.Create(urunKategori);

            return RedirectToAction("Giderekle");

        }
        public IActionResult TransferKalemiEkle(TransferKalemi transferKalemi){
            _transferKalemiService.Create(transferKalemi);
            return RedirectToAction("Transferekle");
        }
        
        // public IActionResult NakitAkisiSirala(string category){
        //     GunSonuTutars = _gunSonuTutarService.GetGunSonuByTutars(category);
        //     return RedirectToAction("Transferekle");

        // }
    }
}