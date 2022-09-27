using DELASALLE.PRACTICA1.Core.Entities;
using DELASALLE.PRACTICA1.Core.Managers.Interfaces;
using DELASALLE.PRACTICA1.Core.Services.Interfaces;

namespace DELASALLE.PRACTICA1.Core.Managers;

public class PesoManager : IPesoManager
{
    private readonly IPesoService _service;

    public PesoManager (IPesoService service)
    {
        _service = service;
    }

    public Peso CalcPeso (Peso peso){
        return _service.ProcessPeso(peso);
    }

}