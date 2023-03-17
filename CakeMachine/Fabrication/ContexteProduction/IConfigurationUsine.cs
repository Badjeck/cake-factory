﻿namespace CakeMachine.Fabrication.ContexteProduction;

internal interface IConfigurationUsine
{
    ushort TailleMaxUsine { get; }

    ushort NombrePréparateurs { get; set; }
    ushort NombreFours { get; set; }
    ushort NombreEmballeuses { get; set; }
}