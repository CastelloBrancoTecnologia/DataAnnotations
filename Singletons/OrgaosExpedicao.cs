using System;
using System.Collections.Generic;
using System.Text;

namespace CastelloBranco.Singletons;

public static class OrgaosExpedicao
{
    public static List<OrgaoExpedicao> Orgaos = new ()
    { 
        new  () { Sigla = "AB",             Orgao = "Aeronautica do Brasil" },
        new  () { Sigla = "CARTORIO CIVIL", Orgao = "Cartório Civil" },
        new  () { Sigla = "CREA",           Orgao = "Conselho Regional de Engenharia e Arquitetura" },
        new  () { Sigla = "CRM",            Orgao = "Conselho Regional de Medicina" },
        new  () { Sigla = "DETRAN",         Orgao = "Departamento de Trânsito" },
        new  () { Sigla = "DPC",            Orgao = "Departamento de Policia Civil" },
        new  () { Sigla = "DPF",            Orgao = "Departamento de Polícia Federal" },
        new  () { Sigla = "DPM",            Orgao = "Departamento de Polícia Militar" },
        new  () { Sigla = "EB",             Orgao = "Exercito do Brasil" },
        new  () { Sigla = "MB",             Orgao = "Marinha do Brasil" },
        new  () { Sigla = "MT",             Orgao = "Ministério do Trabalho" },
        new  () { Sigla = "MTE",            Orgao = "Ministério do Trabalho e Emprego" },
        new  () { Sigla = "OAB",            Orgao = "Ordem dos Advogados do Brasil" },
        new  () { Sigla = "SSP",            Orgao = "Secretaria de Segurança Pública" },
        new  () { Sigla = "SPTC",           Orgao = "Secretaria de Polícia Técnico-Científica" },
    };
}
