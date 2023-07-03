﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.Singletons;


public static class EstadosDoBrasil
{
    public static readonly List<EstadoBrasileiro> Estados = new () {
        new () { Sigla = "AC", Nome = "Acre" },
        new () { Sigla = "AL", Nome = "Alagoas" },
        new () { Sigla = "AP", Nome = "Amapá" },
        new () { Sigla = "AM", Nome = "Amazonas" },
        new () { Sigla = "BA", Nome = "Bahia" },
        new () { Sigla = "CE", Nome = "Ceará" },
        new () { Sigla = "ES", Nome = "Espírito Santo" },
        new () { Sigla = "GO", Nome = "Goiás" },
        new () { Sigla = "MA", Nome = "Maranhão" },
        new () { Sigla = "MT", Nome = "Mato Grosso" },
        new () { Sigla = "MS", Nome = "Mato Grosso do Sul" },
        new () { Sigla = "MG", Nome = "Minas Gerais" },
        new () { Sigla = "PA", Nome = "Pará" },
        new () { Sigla = "PB", Nome = "Paraíba" },
        new () { Sigla = "PR", Nome = "Paraná" },
        new () { Sigla = "PE", Nome = "Pernambuco" },
        new () { Sigla = "PI", Nome = "Piauí" },
        new () { Sigla = "RJ", Nome = "Rio de Janeiro" },
        new () { Sigla = "RN", Nome = "Rio Grande do Norte" },
        new () { Sigla = "RS", Nome = "Rio Grande do Sul" },
        new () { Sigla = "RO", Nome = "Rondônia" },
        new () { Sigla = "RR", Nome = "Roraima" },
        new () { Sigla = "SC", Nome = "Santa Catarina" },
        new () { Sigla = "SP", Nome = "São Paulo" },
        new () { Sigla = "SE", Nome = "Sergipe" },
        new () { Sigla = "TO", Nome = "Tocantins" },
        new () { Sigla = "DF", Nome = "Distrito Federal" }
    };
}
