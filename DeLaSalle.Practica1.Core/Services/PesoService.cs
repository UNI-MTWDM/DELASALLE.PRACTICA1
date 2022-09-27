using DELASALLE.PRACTICA1.Core.Entities;
using DELASALLE.PRACTICA1.Core.Services.Interfaces;

namespace DELASALLE.PRACTICA1.Core.Services;

public class PesoService : IPesoService
{
    public Peso ProcessPeso (Peso peso)
    {
        var marte = new Peso();

        marte.PesoTierra = peso.PesoTierra;
        marte.PesoMarte = (float)(marte.PesoTierra/9.81*3.711);

        return marte;
    }
}