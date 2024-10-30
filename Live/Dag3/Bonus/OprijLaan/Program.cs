using DoomsdayPreppers;
using Gelro;
using Unifi;
using Yunex;

namespace OprijLaan;

class Program
{
    static void Main(string[] args)
    {
        var detectielus = new DetectieLus();
        var valkuil = new Valkuil();
        var hek = new Hek();
        var camera = new Camera();

        detectielus.Connect(hek);
        detectielus.Connect(camera);
        detectielus.Connect(valkuil);


        detectielus.Detecteer();
    }
}
