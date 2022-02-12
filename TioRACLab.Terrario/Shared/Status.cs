using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TioRACLab.Terrario.Shared
{
    public enum Status
    {
        DESLIGADO = 0,
        ILUMINACAO = 1,            //Luz de iluminação ligada.
        ESPECTRO = 2,              //Luz de espectro vermleho para as plantas ligadas.
        LAGO_NIVEL1 = 4,           //Nível 1 do lago. (11 = Alto, 10 = Médio, 01 = Baixo, 00 = Vazio)
        LAGO_NIVEL2 = 8,           //Nível 2 do lago. (11 = Alto, 10 = Médio, 01 = Baixo, 00 = Vazio)
        RESERVATORIO = 16,         //Nível do reservatório baixo.
        BOMBA_LAGO = 32,           //Bomba do lago ligada.
        BOMBA_RESERVATORIO = 64,   //Bomba do reservatório ligada.
        CASCATA = 128,             //Válvula da cachoeira ligada.
        IRRIGACAO = 256,           //Válvula da irrigação ligada.
        NEBLINA = 512,             //Os nebolizadores estão ligados.
        ARCOIRIS = 1024,           //O arco íris está ligado.
        TREM_FRENTE = 2048,        //O trêm está andando para frente.
        TREM_REVERSO = 4096,       //O três está andando para trás.
        TREM_LENTO = 8192,         //Velocidade do trêm é lenta.
        TREM_MEDIO = 16384,        //Velocidade do trêm é mediana.
        TREM_RAPIDO = 32768,       //Velocidade do trêm é rápido.
    }
}
