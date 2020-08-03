using System.Collections.Generic;
using hesapkitap.entity;
namespace hesapkitap.data.Abstract{
    public interface IGunSonuTutarRepository:IRepository<GunSonuTutar>
    {
        List<GunSonuTutar> GetGunSonuByTutar(string name);

    }
}