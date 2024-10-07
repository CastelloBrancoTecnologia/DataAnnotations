using CastelloBranco.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastelloBranco.DataAnnotations.Singletons;

public static class WorldStatesDemonyms
{
    public static readonly List<StateDemonyms> WorldDemonyms = new()
    {
        // Ararbia Saudita

        new () { State = "RI", Demonym = "riadeense", Country = "SA" }, // Riad
        new () { State = "ME", Demonym = "mecaense", Country = "SA" }, // Meca
        new () { State = "MD", Demonym = "medinense", Country = "SA" }, // Medina
        new () { State = "ED", Demonym = "dammamense", Country = "SA" }, // Dammam
        new () { State = "JA", Demonym = "jizanense", Country = "SA" }, // Jizan
        new () { State = "AQ", Demonym = "aqarense", Country = "SA" }, // Aqar
        new () { State = "TA", Demonym = "tabukense", Country = "SA" }, // Tabuk
        new () { State = "AS", Demonym = "asiri", Country = "SA" }, // Asir
        new () { State = "NS", Demonym = "najdino", Country = "SA" }, // Najd
        new () { State = "HL", Demonym = "alhassa", Country = "SA" }, // Al Hassa

        // Argentina

        new() { State = "BA", Demonym = "Bonaerense", Country = "AR" }, // Buenos Aires Province
        new() { State = "CA", Demonym = "Catamarqueño", Country = "AR" },
        new() { State = "CH", Demonym = "Chaco", Country = "AR" },
        new() { State = "CU", Demonym = "Correntino", Country = "AR" },
        new() { State = "ER", Demonym = "Entrerriano", Country = "AR" },
        new() { State = "JY", Demonym = "Jujeño", Country = "AR" },
        new() { State = "LP", Demonym = "La Pampa", Country = "AR" },
        new() { State = "LR", Demonym = "La Rioja", Country = "AR" },
        new() { State = "MZ", Demonym = "Mendocino", Country = "AR" },
        new() { State = "NA", Demonym = "Neuquino", Country = "AR" },
        new() { State = "RN", Demonym = "Rionegrino", Country = "AR" },
        new() { State = "SA", Demonym = "Salteño", Country = "AR" },
        new() { State = "SJ", Demonym = "Sanjuanino", Country = "AR" },
        new() { State = "SL", Demonym = "Sanluiseño", Country = "AR" },
        new() { State = "SC", Demonym = "Santiagueño", Country = "AR" },
        new() { State = "TF", Demonym = "Tucumano", Country = "AR" },
        new() { State = "CH", Demonym = "Chubutense", Country = "AR" },
        new() { State = "PG", Demonym = "Formoseño", Country = "AR" },
        new() { State = "SH", Demonym = "Porteño", Country = "AR" }, // Buenos Aires City
        new() { State = "SC", Demonym = "Santa Cruz", Country = "AR" },
        new() { State = "SF", Demonym = "Santa Fe", Country = "AR" },
        new() { State = "TG", Demonym = "Tierra del Fuego", Country = "AR" },

        // Australia
        new () { State = "ACT", Demonym = "Canberran", Country = "AU" }, // Australian Capital Territory
        new () { State = "NSW", Demonym = "New South Welshman", Country = "AU" }, // New South Wales
        new () { State = "NT", Demonym = "Territorian", Country = "AU" }, // Northern Territory
        new () { State = "QLD", Demonym = "Queenslander", Country = "AU" }, // Queensland
        new () { State = "SA", Demonym = "South Australian", Country = "AU" }, // South Australia
        new () { State = "TAS", Demonym = "Tasmanian", Country = "AU" }, // Tasmania
        new () { State = "VIC", Demonym = "Victorian", Country = "AU" }, // Victoria
        new () { State = "WA", Demonym = "Western Australian", Country = "AU" }, // Western Australia
        
        // AUstria

        new () { State = "1", Demonym = "vienense", Country = "AT" }, // Viena
        new () { State = "2", Demonym = "níderlandês", Country = "AT" }, // Baixa Áustria
        new () { State = "3", Demonym = "burgenlandês", Country = "AT" }, // Burgenland
        new () { State = "4", Demonym = "estiriano", Country = "AT" }, // Estíria
        new () { State = "5", Demonym = "caríntio", Country = "AT" }, // Caríntia
        new () { State = "6", Demonym = "salzburguês", Country = "AT" }, // Salzburgo
        new () { State = "7", Demonym = "tirolês", Country = "AT" }, // Tirol
        new () { State = "8", Demonym = "vorarlberguês", Country = "AT" }, // Vorarlberg
        new () { State = "9", Demonym = "alto-austríaco", Country = "AT" }, // Alta Áustria
       
        // Bolivia

        new () { State = "LP", Demonym = "Paceño", Country = "BO" }, // La Paz
        new () { State = "CB", Demonym = "Cochabambino", Country = "BO" }, // Cochabamba
        new () { State = "CR", Demonym = "Cruzense", Country = "BO" }, // Santa Cruz
        new () { State = "BN", Demonym = "Beniano", Country = "BO" }, // Beni
        new () { State = "PD", Demonym = "Pando", Country = "BO" }, // Pando
        new () { State = "TJ", Demonym = "Tarijeño", Country = "BO" }, // Tarija
        new () { State = "OR", Demonym = "Orureño", Country = "BO" }, // Oruro
        new () { State = "CH", Demonym = "Chuquisaqueño", Country = "BO" }, // Chuquisaca
        new () { State = "LP", Demonym = "La Paz", Country = "BO" }, // La Paz
        new () { State = "SJ", Demonym = "Sanandreseño", Country = "BO" }, // San Andrés
        new () { State = "NI", Demonym = "Nicolás", Country = "BO" }, // Nicolás

        // Brazil

        new () { State = "AC", Demonym = "Acreano", Country = "BR" },
        new() { State = "AL", Demonym = "Alagoano", Country = "BR" },
        new() { State = "AP", Demonym = "Amapaense", Country = "BR" },
        new() { State = "AM", Demonym = "Amazonense", Country = "BR" },
        new() { State = "BA", Demonym = "Baiano", Country = "BR" },
        new() { State = "CE", Demonym = "Cearense", Country = "BR" },
        new() { State = "DF", Demonym = "Brasiliense", Country = "BR" },
        new() { State = "ES", Demonym = "Capixaba", Country = "BR" },
        new() { State = "GO", Demonym = "Goiano", Country = "BR" },
        new() { State = "MA", Demonym = "Maranhense", Country = "BR" },
        new() { State = "MT", Demonym = "Mato-Grossense", Country = "BR" },
        new() { State = "MS", Demonym = "Sul-Mato-Grossense", Country = "BR" },
        new() { State = "MG", Demonym = "Mineiro", Country = "BR" },
        new() { State = "PA", Demonym = "Paraense", Country = "BR" },
        new() { State = "PB", Demonym = "Paraibano", Country = "BR" },
        new() { State = "PR", Demonym = "Paranaense", Country = "BR" },
        new() { State = "PE", Demonym = "Pernambucano", Country = "BR" },
        new() { State = "PI", Demonym = "Piauiense", Country = "BR" },
        new() { State = "RJ", Demonym = "Carioca", Country = "BR" },
        new() { State = "RN", Demonym = "Potiguar", Country = "BR" },
        new() { State = "RS", Demonym = "Gaúcho", Country = "BR" },
        new() { State = "RO", Demonym = "Rondoniense", Country = "BR" },
        new() { State = "RR", Demonym = "Roraimense", Country = "BR" },
        new() { State = "SC", Demonym = "Catarinense", Country = "BR" },
        new() { State = "SP", Demonym = "Paulista", Country = "BR" },
        new() { State = "SE", Demonym = "Sergipano", Country = "BR" },
        new() { State = "TO", Demonym = "Tocantinense", Country = "BR" },

        // Canada

        new() { State = "AB", Demonym = "Albertan", Country = "CA" },
        new() { State = "BC", Demonym = "British Columbian", Country = "CA" },
        new() { State = "MB", Demonym = "Manitoban", Country = "CA" },
        new() { State = "NB", Demonym = "New Brunswicker", Country = "CA" },
        new() { State = "NL", Demonym = "Newfoundlander", Country = "CA" },
        new() { State = "NS", Demonym = "Nova Scotian", Country = "CA" },
        new() { State = "ON", Demonym = "Ontarian", Country = "CA" },
        new() { State = "PE", Demonym = "Prince Edward Islander", Country = "CA" },
        new() { State = "QC", Demonym = "Quebecer", Country = "CA" },
        new() { State = "SK", Demonym = "Saskatchewanean", Country = "CA" },
        new() { State = "NT", Demonym = "Northwest Territorian", Country = "CA" },
        new() { State = "NU", Demonym = "Nunavutian", Country = "CA" },
        new() { State = "YT", Demonym = "Yukoner", Country = "CA" },

        // Chile

        new() { State = "AR", Demonym = "Ariqueño", Country = "CL" }, // Arica y Parinacota
        new() { State = "LI", Demonym = "Linarense", Country = "CL" }, // Libertador General Bernardo O'Higgins
        new() { State = "MA", Demonym = "Maule", Country = "CL" }, // Maule
        new() { State = "CO", Demonym = "Coquimbano", Country = "CL" }, // Coquimbo
        new() { State = "AT", Demonym = "Atacameño", Country = "CL" }, // Atacama
        new() { State = "AN", Demonym = "Antofagastino", Country = "CL" }, // Antofagasta
        new() { State = "BI", Demonym = "Biobiano", Country = "CL" }, // Biobío
        new() { State = "LA", Demonym = "Llanquihue", Country = "CL" }, // Los Lagos
        new() { State = "AO", Demonym = "Aysenino", Country = "CL" }, // Aysén
        new() { State = "MA", Demonym = "Magallánico", Country = "CL" }, // Magallanes
        new() { State = "RM", Demonym = "Metropolitano", Country = "CL" }, // Región Metropolitana

        // China

        new () { State = "AN", Demonym = "Anhui", Country = "CN" }, // Anhui
        new () { State = "BJ", Demonym = "Beijingese", Country = "CN" }, // Beijing
        new () { State = "FJ", Demonym = "Fujianese", Country = "CN" }, // Fujian
        new () { State = "GD", Demonym = "Guangdongese", Country = "CN" }, // Guangdong
        new () { State = "GX", Demonym = "Guangxian", Country = "CN" }, // Guangxi
        new () { State = "GZ", Demonym = "Guizhouese", Country = "CN" }, // Guizhou
        new () { State = "HA", Demonym = "Henanese", Country = "CN" }, // Henan
        new () { State = "HB", Demonym = "Hubei", Country = "CN" }, // Hubei
        new () { State = "HN", Demonym = "Hunanese", Country = "CN" }, // Hunan
        new () { State = "JL", Demonym = "Jilinese", Country = "CN" }, // Jilin
        new () { State = "LN", Demonym = "Liaoningese", Country = "CN" }, // Liaoning
        new () { State = "NX", Demonym = "Ningxia", Country = "CN" }, // Ningxia
        new () { State = "QH", Demonym = "Qinghai", Country = "CN" }, // Qinghai
        new () { State = "SC", Demonym = "Sichuanese", Country = "CN" }, // Sichuan
        new () { State = "SD", Demonym = "Shandongese", Country = "CN" }, // Shandong
        new () { State = "SH", Demonym = "Shanghai", Country = "CN" }, // Shanghai
        new () { State = "SN", Demonym = "Shaanxi", Country = "CN" }, // Shaanxi
        new () { State = "SX", Demonym = "Shanxi", Country = "CN" }, // Shanxi
        new () { State = "TI", Demonym = "Tianjinese", Country = "CN" }, // Tianjin
        new () { State = "XJ", Demonym = "Xinjiang", Country = "CN" }, // Xinjiang
        new () { State = "XZ", Demonym = "Tibet", Country = "CN" }, // Tibet
        new () { State = "YN", Demonym = "Yunnanese", Country = "CN" }, // Yunnan
        new () { State = "ZJ", Demonym = "Zhejiangese", Country = "CN" }, // Zhejiang
      
        // Colombia

        new () { State = "AMA", Demonym = "Amazonense", Country = "CO" }, // Amazonas
        new () { State = "ANT", Demonym = "Antioqueño", Country = "CO" }, // Antioquia
        new () { State = "ARA", Demonym = "Araucano", Country = "CO" }, // Arauca
        new () { State = "ATL", Demonym = "Atlántico", Country = "CO" }, // Atlántico
        new () { State = "BOL", Demonym = "Bolivarense", Country = "CO" }, // Bolívar
        new () { State = "BOY", Demonym = "Boyacense", Country = "CO" }, // Boyacá
        new () { State = "CAL", Demonym = "Caldense", Country = "CO" }, // Caldas
        new () { State = "CAS", Demonym = "Casanareño", Country = "CO" }, // Casanare
        new () { State = "CAU", Demonym = "Caucan", Country = "CO" }, // Cauca
        new () { State = "CES", Demonym = "Cesareño", Country = "CO" }, // Cesar
        new () { State = "CHO", Demonym = "Chocano", Country = "CO" }, // Chocó
        new () { State = "CÓR", Demonym = "Cundinamarqués", Country = "CO" }, // Cundinamarca
        new () { State = "GUA", Demonym = "Guajiro", Country = "CO" }, // La Guajira
        new () { State = "HUI", Demonym = "Huilense", Country = "CO" }, // Huila
        new () { State = "MAG", Demonym = "Magdalenense", Country = "CO" }, // Magdalena
        new () { State = "META", Demonym = "Metense", Country = "CO" }, // Meta
        new () { State = "NAR", Demonym = "Nariñense", Country = "CO" }, // Nariño
        new () { State = "NQ", Demonym = "Norte de Santander", Country = "CO" }, // Norte de Santander
        new () { State = "PUT", Demonym = "Putumayo", Country = "CO" }, // Putumayo
        new () { State = "QUI", Demonym = "Quindiano", Country = "CO" }, // Quindío
        new () { State = "RIS", Demonym = "Risarlense", Country = "CO" }, // Risaralda
        new () { State = "SAN", Demonym = "Santandereano", Country = "CO" }, // Santander
        new () { State = "SUC", Demonym = "Sucreño", Country = "CO" }, // Sucre
        new () { State = "TOL", Demonym = "Tolimense", Country = "CO" }, // Tolima
        new () { State = "VAL", Demonym = "Vallecaucano", Country = "CO" }, // Valle del Cauca
        new () { State = "VAU", Demonym = "Vaupés", Country = "CO" }, // Vaupés
        new () { State = "VIC", Demonym = "Vichada", Country = "CO" }, // Vichada

        // Cuba

        new () { State = "01", Demonym = "Habano", Country = "CU" }, // La Habana
        new () { State = "02", Demonym = "Pinarense", Country = "CU" }, // Pinar del Río
        new () { State = "03", Demonym = "Matancero", Country = "CU" }, // Matanzas
        new () { State = "04", Demonym = "Villaclareño", Country = "CU" }, // Villa Clara
        new () { State = "05", Demonym = "Cienfueguero", Country = "CU" }, // Cienfuegos
        new () { State = "06", Demonym = "Sanctispirense", Country = "CU" }, // Sancti Spíritus
        new () { State = "07", Demonym = "Ciego de Ávila", Country = "CU" }, // Ciego de Ávila
        new () { State = "08", Demonym = "Camagüeyano", Country = "CU" }, // Camagüey
        new () { State = "09", Demonym = "Las Tunas", Country = "CU" }, // Las Tunas
        new () { State = "10", Demonym = "Holguinero", Country = "CU" }, // Holguín
        new () { State = "11", Demonym = "Granmanero", Country = "CU" }, // Granma
        new () { State = "12", Demonym = "Santiaguero", Country = "CU" }, // Santiago de Cuba
        new () { State = "13", Demonym = "Guantanamero", Country = "CU" }, // Guantánamo
        new () { State = "14", Demonym = "Isleño", Country = "CU" }, // Isla de la Juventud
       
        // Egito

        new () { State = "C", Demonym = "cairoense", Country = "EG" }, // Cairo
        new () { State = "G", Demonym = "gizaense", Country = "EG" }, // Giza
        new () { State = "Q", Demonym = "qenaense", Country = "EG" }, // Qena
        new () { State = "S", Demonym = "suecense", Country = "EG" }, // Suez
        new () { State = "LN", Demonym = "latonense", Country = "EG" }, // Latão
        new () { State = "BA", Demonym = "bahareinense", Country = "EG" }, // Baharein
        new () { State = "MN", Demonym = "minufense", Country = "EG" }, // Minuf
        new () { State = "DZ", Demonym = "damasceno", Country = "EG" }, // Damasceno
        new () { State = "AS", Demonym = "aswanense", Country = "EG" }, // Aswan
        new () { State = "SU", Demonym = "suezo", Country = "EG" }, // Suez
     
        // Emirados Arabes
        
        new () { State = "DU", Demonym = "duquense", Country = "AE" }, // Dubai
        new () { State = "AB", Demonym = "abudabiense", Country = "AE" }, // Abu Dhabi
        new () { State = "SH", Demonym = "sharjense", Country = "AE" }, // Sharjah
        new () { State = "AJ", Demonym = "ajmanense", Country = "AE" }, // Ajman
        new () { State = "FU", Demonym = "fujairense", Country = "AE" }, // Fujairah
        new () { State = "RA", Demonym = "rasalhaimense", Country = "AE" }, // Ras Al Khaimah
        new () { State = "UM", Demonym = "ummalquainense", Country = "AE" }, // Umm Al-Quwain
    
        // Espanha 

        new () { State = "AN", Demonym = "andaluz", Country = "ES" }, // Andaluzia
        new () { State = "AR", Demonym = "aragonês", Country = "ES" }, // Aragão
        new () { State = "AS", Demonym = "asturiano", Country = "ES" }, // Astúrias
        new () { State = "CN", Demonym = "canário", Country = "ES" }, // Ilhas Canárias
        new () { State = "CB", Demonym = "cantabrês", Country = "ES" }, // Cantábria
        new () { State = "CL", Demonym = "castelhano", Country = "ES" }, // Castela e Leão
        new () { State = "CM", Demonym = "castelhano-manchego", Country = "ES" }, // Castela-Mancha
        new () { State = "CT", Demonym = "catalão", Country = "ES" }, // Catalunha
        new () { State = "EX", Demonym = "extremeno", Country = "ES" }, // Extremadura
        new () { State = "GA", Demonym = "galego", Country = "ES" }, // Galícia
        new () { State = "IB", Demonym = "ilhotense", Country = "ES" }, // Ilhas Baleares
        new () { State = "MD", Demonym = "madrilenho", Country = "ES" }, // Madri
        new () { State = "MC", Demonym = "murciano", Country = "ES" }, // Múrcia
        new () { State = "NA", Demonym = "navarro", Country = "ES" }, // Navarra
        new () { State = "PV", Demonym = "basco", Country = "ES" }, // País Basco
        new () { State = "RI", Demonym = "riojano", Country = "ES" }, // La Rioja
        new () { State = "VA", Demonym = "valenciano", Country = "ES" }, // Comunidade Valenciana
       
        // Finland 

        new () { State = "AH", Demonym = "alandense", Country = "FI" }, // Åland
        new () { State = "UL", Demonym = "uleåense", Country = "FI" }, // Uusimaa
        new () { State = "ES", Demonym = "estadense", Country = "FI" }, // Etelä-Suomi (Finlândia do Sul)
        new () { State = "PO", Demonym = "pohjolano", Country = "FI" }, // Pohjois-Suomi (Finlândia do Norte)
        new () { State = "KAA", Demonym = "kaakkoisiano", Country = "FI" }, // Kaakkois-Suomi (Finlândia do Sudeste)
        new () { State = "LAP", Demonym = "lapão", Country = "FI" }, // Lapônia (Lappi)
        new () { State = "KOS", Demonym = "kymenlaakson", Country = "FI" }, // Kymenlaakso
        new () { State = "HÄM", Demonym = "hameense", Country = "FI" }, // Häme
        new () { State = "POH", Demonym = "pohjano", Country = "FI" }, // Pohjois-Karjala (Carélia do Norte)
        new () { State = "SUO", Demonym = "suoemiano", Country = "FI" }, // Suomenselkä
   
        // Franca

        new () { State = "AÎ", Demonym = "Aindinois", Country = "FR" }, // Ain
        new () { State = "AUP", Demonym = "Aupois", Country = "FR" }, // Auvergne-Rhône-Alpes
        new () { State = "AQU", Demonym = "Aquitaine", Country = "FR" }, // Nouvelle-Aquitaine
        new () { State = "BFC", Demonym = "Bourgogne", Country = "FR" }, // Bourgogne-Franche-Comté
        new () { State = "BRI", Demonym = "Brittanique", Country = "FR" }, // Bretagne
        new () { State = "CEN", Demonym = "Centrais", Country = "FR" }, // Centre-Val de Loire
        new () { State = "HAU", Demonym = "Haut-Savoyard", Country = "FR" }, // Hauts-de-France
        new () { State = "ILE", Demonym = "Île-de-France", Country = "FR" }, // Île-de-France
        new () { State = "LIM", Demonym = "Limousin", Country = "FR" }, // Limousin
        new () { State = "MAY", Demonym = "Mayennais", Country = "FR" }, // Mayenne
        new () { State = "NORM", Demonym = "Normand", Country = "FR" }, // Normandie
        new () { State = "PAC", Demonym = "Provençal", Country = "FR" }, // Provence-Alpes-Côte d'Azur
        new () { State = "PAC", Demonym = "Paca", Country = "FR" }, // Provence-Alpes-Côte d'Azur
        new () { State = "PAYS", Demonym = "Paysan", Country = "FR" }, // Pays de la Loire
        new () { State = "SAV", Demonym = "Savoyard", Country = "FR" }, // Savoie
        new () { State = "COR", Demonym = "Corse", Country = "FR" }, // Corse

        new () { State = "PF", Demonym = "Polynésien", Country = "FR" }, // French Polynesia
        new () { State = "NC", Demonym = "Calédonien", Country = "FR" }, // New Caledonia
        new () { State = "WF", Demonym = "Wallisien", Country = "FR" }, // Wallis and Futuna
      
        // Guiana Francesa

        new () { State = "GF", Demonym = "guianense", Country = "GF" }, // Guiana Francesa

        // German

        new () { State = "BW", Demonym = "Baden-Württembergian", Country = "DE" }, // Baden-Württemberg
        new () { State = "BY", Demonym = "Bavarian", Country = "DE" }, // Bayern (Bavaria)
        new () { State = "BE", Demonym = "Berlinese", Country = "DE" }, // Berlin
        new () { State = "BR", Demonym = "Brandenburgian", Country = "DE" }, // Brandenburg
        new () { State = "HB", Demonym = "Bremenese", Country = "DE" }, // Bremen
        new () { State = "HH", Demonym = "Hamburgian", Country = "DE" }, // Hamburg
        new () { State = "HE", Demonym = "Hessian", Country = "DE" }, // Hessen (Hesse)
        new () { State = "MV", Demonym = "Mecklenburgian", Country = "DE" }, // Mecklenburg-Vorpommern
        new () { State = "NI", Demonym = "Lower Saxonian", Country = "DE" }, // Niedersachsen (Lower Saxony)
        new () { State = "NW", Demonym = "North Rhine-Westphalian", Country = "DE" }, // Nordrhein-Westfalen
        new () { State = "RP", Demonym = "Rhinelander", Country = "DE" }, // Rheinland-Pfalz
        new () { State = "SL", Demonym = "Saarlander", Country = "DE" }, // Saarland
        new () { State = "SN", Demonym = "Saxon", Country = "DE" }, // Sachsen (Saxony)
        new () { State = "ST", Demonym = "Saxony-Anhaltian", Country = "DE" }, // Sachsen-Anhalt
        new () { State = "TH", Demonym = "Thuringian", Country = "DE" }, // Thüringen (Thuringia)
      
        // India

        new () { State = "AP", Demonym = "Andhra Pradeshian", Country = "IN" }, // Andhra Pradesh
        new () { State = "AR", Demonym = "Arunachali", Country = "IN" }, // Arunachal Pradesh
        new () { State = "AS", Demonym = "Assamese", Country = "IN" }, // Assam
        new () { State = "BR", Demonym = "Bihari", Country = "IN" }, // Bihar
        new () { State = "CT", Demonym = "Chhattisgarhi", Country = "IN" }, // Chhattisgarh
        new () { State = "GA", Demonym = "Goan", Country = "IN" }, // Goa
        new () { State = "GJ", Demonym = "Gujaratis", Country = "IN" }, // Gujarat
        new () { State = "HR", Demonym = "Haryana", Country = "IN" }, // Haryana
        new () { State = "HP", Demonym = "Himachali", Country = "IN" }, // Himachal Pradesh
        new () { State = "JK", Demonym = "Jammu and Kashmiri", Country = "IN" }, // Jammu and Kashmir
        new () { State = "JH", Demonym = "Jharkhandi", Country = "IN" }, // Jharkhand
        new () { State = "KA", Demonym = "Karnataka", Country = "IN" }, // Karnataka
        new () { State = "KL", Demonym = "Keralite", Country = "IN" }, // Kerala
        new () { State = "MP", Demonym = "Madhya Pradeshi", Country = "IN" }, // Madhya Pradesh
        new () { State = "MH", Demonym = "Maharashtrian", Country = "IN" }, // Maharashtra
        new () { State = "MN", Demonym = "Manipuri", Country = "IN" }, // Manipur
        new () { State = "ML", Demonym = "Mizoram", Country = "IN" }, // Mizoram
        new () { State = "NL", Demonym = "Nagalandese", Country = "IN" }, // Nagaland
        new () { State = "OD", Demonym = "Odisha", Country = "IN" }, // Odisha
        new () { State = "PB", Demonym = "Punjabi", Country = "IN" }, // Punjab
        new () { State = "RJ", Demonym = "Rajasthan", Country = "IN" }, // Rajasthan
        new () { State = "SK", Demonym = "Sikkimese", Country = "IN" }, // Sikkim
        new () { State = "TN", Demonym = "Tamil", Country = "IN" }, // Tamil Nadu
        new () { State = "TG", Demonym = "Telangana", Country = "IN" }, // Telangana
        new () { State = "UT", Demonym = "Uttarakhandi", Country = "IN" }, // Uttarakhand
        new () { State = "UP", Demonym = "Uttar Pradesh", Country = "IN" }, // Uttar Pradesh
        new () { State = "WB", Demonym = "Bengali", Country = "IN" }, // West Bengal
        new () { State = "AN", Demonym = "Andamanese", Country = "IN" }, // Andaman and Nicobar Islands
        new () { State = "CH", Demonym = "Chandigarh", Country = "IN" }, // Chandigarh
        new () { State = "DN", Demonym = "Dadra and Nagar Haveli", Country = "IN" }, // Dadra and Nagar Haveli
        new () { State = "DD", Demonym = "Damanese", Country = "IN" }, // Daman and Diu
        new () { State = "LD", Demonym = "Lakshadweep", Country = "IN" }, // Lakshadweep
        new () { State = "PY", Demonym = "Puducherry", Country = "IN" }, // Puducherry     

        // Italy

        new () { State = "ABR", Demonym = "Abruzzese", Country = "IT" }, // Abruzzo
        new () { State = "BAS", Demonym = "Basilicatese", Country = "IT" }, // Basilicata
        new () { State = "CAL", Demonym = "Calabrese", Country = "IT" }, // Calabria
        new () { State = "CAM", Demonym = "Campano", Country = "IT" }, // Campania
        new () { State = "EMI", Demonym = "Emiliano", Country = "IT" }, // Emilia-Romagna
        new () { State = "FRI", Demonym = "Friulano", Country = "IT" }, // Friuli Venezia Giulia
        new () { State = "LAZ", Demonym = "Laziale", Country = "IT" }, // Lazio
        new () { State = "LIG", Demonym = "Ligure", Country = "IT" }, // Liguria
        new () { State = "LOM", Demonym = "Lombardo", Country = "IT" }, // Lombardia
        new () { State = "MAR", Demonym = "Marchigiano", Country = "IT" }, // Marche
        new () { State = "MOL", Demonym = "Molisano", Country = "IT" }, // Molise
        new () { State = "PIE", Demonym = "Piemontese", Country = "IT" }, // Piemonte
        new () { State = "SAR", Demonym = "Sardo", Country = "IT" }, // Sardegna
        new () { State = "SIC", Demonym = "Siciliano", Country = "IT" }, // Sicilia
        new () { State = "TOS", Demonym = "Toscano", Country = "IT" }, // Toscana
        new () { State = "UMB", Demonym = "Umbro", Country = "IT" }, // Umbria
        new () { State = "VEN", Demonym = "Veneto", Country = "IT" }, // Veneto
       
        // Israel

        new () { State = "TA", Demonym = "taurense", Country = "IL" }, // Tel Aviv
        new () { State = "HA", Demonym = "haifaense", Country = "IL" }, // Haifa
        new () { State = "JE", Demonym = "jerusalemense", Country = "IL" }, // Jerusalém
        new () { State = "BE", Demonym = "bercelete", Country = "IL" }, // Be'er Sheva
        new () { State = "NA", Demonym = "nazareno", Country = "IL" }, // Nazaré
        new () { State = "AH", Demonym = "aharonense", Country = "IL" }, // Aharon
        new () { State = "HA", Demonym = "haranense", Country = "IL" }, // Haran
        new () { State = "ZC", Demonym = "zeqelense", Country = "IL" }, // Zeqel
        new () { State = "TA", Demonym = "tamarense", Country = "IL" }, // Tamar
        new () { State = "AF", Demonym = "afiquense", Country = "IL" }, // Afiq
      
        // Japan

        new () { State = "HOK-01", Demonym = "hokkaidense", Country = "JP" }, // Hokkaido
        new () { State = "AOM-02", Demonym = "aomoriano", Country = "JP" }, // Aomori
        new () { State = "IWA-03", Demonym = "iwateano", Country = "JP" }, // Iwate
        new () { State = "MIY-04", Demonym = "miyagiano", Country = "JP" }, // Miyagi
        new () { State = "AKI-05", Demonym = "akitano", Country = "JP" }, // Akita
        new () { State = "YAM-06", Demonym = "yamagataense", Country = "JP" }, // Yamagata
        new () { State = "FUK-07", Demonym = "fukushimense", Country = "JP" }, // Fukushima
        new () { State = "IBA-08", Demonym = "ibarakiense", Country = "JP" }, // Ibaraki
        new () { State = "TOC-09", Demonym = "tochigiano", Country = "JP" }, // Tochigi
        new () { State = "GUN-10", Demonym = "gunmaense", Country = "JP" }, // Gunma
        new () { State = "SAI-11", Demonym = "saitamense", Country = "JP" }, // Saitama
        new () { State = "CHI-12", Demonym = "chibano", Country = "JP" }, // Chiba
        new () { State = "TOK-13", Demonym = "tokiense", Country = "JP" }, // Tóquio
        new () { State = "KAN-14", Demonym = "kanagawense", Country = "JP" }, // Kanagawa
        new () { State = "NII-15", Demonym = "niigataense", Country = "JP" }, // Niigata
        new () { State = "TOY-16", Demonym = "toyamense", Country = "JP" }, // Toyama
        new () { State = "ISH-17", Demonym = "ishikawano", Country = "JP" }, // Ishikawa
        new () { State = "FUK-18", Demonym = "fukuiense", Country = "JP" }, // Fukui
        new () { State = "YAM-19", Demonym = "yamanashiense", Country = "JP" }, // Yamanashi
        new () { State = "NAG-20", Demonym = "naganense", Country = "JP" }, // Nagano
        new () { State = "GIF-21", Demonym = "gifuno", Country = "JP" }, // Gifu
        new () { State = "SHI-22", Demonym = "shizuokano", Country = "JP" }, // Shizuoka
        new () { State = "AIC-23", Demonym = "aichiano", Country = "JP" }, // Aichi
        new () { State = "MIE-24", Demonym = "miense", Country = "JP" }, // Mie
        new () { State = "SHI-25", Demonym = "shigano", Country = "JP" }, // Shiga
        new () { State = "KYO-26", Demonym = "kyotense", Country = "JP" }, // Quioto
        new () { State = "OSA-27", Demonym = "osaquense", Country = "JP" }, // Osaka
        new () { State = "HYO-28", Demonym = "hyogano", Country = "JP" }, // Hyogo
        new () { State = "NAR-29", Demonym = "naraense", Country = "JP" }, // Nara
        new () { State = "WAK-30", Demonym = "wakayamense", Country = "JP" }, // Wakayama
        new () { State = "TOT-31", Demonym = "tottoriano", Country = "JP" }, // Tottori
        new () { State = "SHI-32", Demonym = "shimanense", Country = "JP" }, // Shimane
        new () { State = "OKA-33", Demonym = "okayamense", Country = "JP" }, // Okayama
        new () { State = "HIR-34", Demonym = "hiroshimense", Country = "JP" }, // Hiroshima
        new () { State = "YAM-35", Demonym = "yamabuchiano", Country = "JP" }, // Yamaguchi
        new () { State = "TOK-36", Demonym = "tokushimano", Country = "JP" }, // Tokushima
        new () { State = "KAG-37", Demonym = "kagawano", Country = "JP" }, // Kagawa
        new () { State = "EHI-38", Demonym = "ehimense", Country = "JP" }, // Ehime
        new () { State = "KOC-39", Demonym = "kochiano", Country = "JP" }, // Kochi
        new () { State = "FUK-40", Demonym = "fukuokano", Country = "JP" }, // Fukuoka
        new () { State = "SAG-41", Demonym = "sagano", Country = "JP" }, // Saga
        new () { State = "NAG-42", Demonym = "nagasakiano", Country = "JP" }, // Nagasaki
        new () { State = "KUM-43", Demonym = "kumamotoense", Country = "JP" }, // Kumamoto
        new () { State = "OIT-44", Demonym = "oitano", Country = "JP" }, // Oita
        new () { State = "MIY-45", Demonym = "miyazakiense", Country = "JP" }, // Miyazaki
        new () { State = "KAG-46", Demonym = "kagoshimano", Country = "JP" }, // Kagoshima
        new () { State = "OKI-47", Demonym = "okinawano", Country = "JP" }, // Okinawa
      
        // Maldivas

        new () { State = "MLE", Demonym = "maldivense", Country = "MV" }, // Maldivas

        // Mexico

        new () { State = "AG", Demonym = "Aguascalentense", Country = "MX" },
        new() { State = "BC", Demonym = "Baja Californiano", Country = "MX" },
        new() { State = "BS", Demonym = "Baja Californiano Sur", Country = "MX" },
        new() { State = "CM", Demonym = "Campechano", Country = "MX" },
        new() { State = "CS", Demonym = "Chihuahuense", Country = "MX" },
        new() { State = "CH", Demonym = "Chihuahuense", Country = "MX" },
        new() { State = "DF", Demonym = "Chilango", Country = "MX" }, // Common term for residents of Mexico City
        new() { State = "CO", Demonym = "Coahuilense", Country = "MX" },
        new() { State = "CL", Demonym = "Colimense", Country = "MX" },
        new() { State = "DG", Demonym = "Duranguense", Country = "MX" },
        new() { State = "GJ", Demonym = "Guanajuatense", Country = "MX" },
        new() { State = "GT", Demonym = "Guerrense", Country = "MX" },
        new() { State = "HG", Demonym = "Hidalguense", Country = "MX" },
        new() { State = "JAL", Demonym = "Jaliscienses", Country = "MX" },
        new() { State = "MC", Demonym = "Mexicano", Country = "MX" },
        new() { State = "MS", Demonym = "Morelense", Country = "MX" },
        new() { State = "NL", Demonym = "Nuevoleonense", Country = "MX" },
        new() { State = "OC", Demonym = "Oaxaqueño", Country = "MX" },
        new() { State = "PU", Demonym = "Poblano", Country = "MX" },
        new() { State = "QR", Demonym = "Quintanarroense", Country = "MX" },
        new() { State = "SL", Demonym = "San Luis Potosino", Country = "MX" },
        new() { State = "SO", Demonym = "Sinaloense", Country = "MX" },
        new() { State = "TB", Demonym = "Tabasqueño", Country = "MX" },
        new() { State = "TL", Demonym = "Tlaxcalteca", Country = "MX" },
        new() { State = "VER", Demonym = "Veracruzano", Country = "MX" },
        new() { State = "YU", Demonym = "Yucateco", Country = "MX" },
        new() { State = "ZA", Demonym = "Zacatecano", Country = "MX" },

        // Mongolia

        new () { State = "UL", Demonym = "ulano", Country = "MN" }, // Ulã Bator
        new () { State = "BA", Demonym = "bayangol", Country = "MN" }, // Província de Bayankhongor
        new () { State = "BU", Demonym = "buvsandi", Country = "MN" }, // Província de Buvsandi
        new () { State = "KH", Demonym = "khentii", Country = "MN" }, // Província de Khentii
        new () { State = "GV", Demonym = "govi", Country = "MN" }, // Província de Govi-Altai
        new () { State = "HO", Demonym = "hovd", Country = "MN" }, // Província de Hovd
        new () { State = "OV", Demonym = "ovorkhangai", Country = "MN" }, // Província de Övörkhangai
        new () { State = "SU", Demonym = "sukhbaatar", Country = "MN" }, // Província de Sukhbaatar
        new () { State = "DA", Demonym = "dornogovi", Country = "MN" }, // Província de Dornogovi
        new () { State = "DO", Demonym = "dornod", Country = "MN" }, // Província de Dornod
        new () { State = "ER", Demonym = "erdenet", Country = "MN" }, // Província de Erdenet
     
        // Nicaragua
        
        new () { State = "AN", Demonym = "managuense", Country = "NI" }, // Departamento de Managua
        new () { State = "CH", Demonym = "chinandegano", Country = "NI" }, // Departamento de Chinandega
        new () { State = "GR", Demonym = "granadino", Country = "NI" }, // Departamento de Granada
        new () { State = "ES", Demonym = "esteli", Country = "NI" }, // Departamento de Estelí
        new () { State = "NI", Demonym = "nicaraguense", Country = "NI" }, // Departamento de Nicarágua
        new () { State = "CO", Demonym = "caraceño", Country = "NI" }, // Departamento de Carazo
        new () { State = "MT", Demonym = "matagalpino", Country = "NI" }, // Departamento de Matagalpa
        new () { State = "SJ", Demonym = "sanjuaneño", Country = "NI" }, // Departamento de San Juan
        new () { State = "DO", Demonym = "diriangén", Country = "NI" }, // Departamento de Diriangén
        new () { State = "RA", Demonym = "rajas", Country = "NI" }, // Departamento de Rivas
        new () { State = "BO", Demonym = "boacoense", Country = "NI" }, // Departamento de Boaco
        new () { State = "LE", Demonym = "leonés", Country = "NI" }, // Departamento de León
        new () { State = "OC", Demonym = "ocotalense", Country = "NI" }, // Departamento de Ocotal
 
        // Nova Zelandia

        new () { State = "AUK", Demonym = "Aucklander", Country = "NZ" }, // Auckland
        new () { State = "BOP", Demonym = "Bay of Plenty", Country = "NZ" }, // Bay of Plenty
        new () { State = "CAN", Demonym = "Cantabrian", Country = "NZ" }, // Canterbury
        new () { State = "GIS", Demonym = "Gisbornian", Country = "NZ" }, // Gisborne
        new () { State = "HKB", Demonym = "Hawke's Bay", Country = "NZ" }, // Hawke's Bay
        new () { State = "MBH", Demonym = "Marlboroughian", Country = "NZ" }, // Marlborough
        new () { State = "NLD", Demonym = "Northland", Country = "NZ" }, // Northland
        new () { State = "OTG", Demonym = "Otagoan", Country = "NZ" }, // Otago
        new () { State = "TAS", Demonym = "Taranakian", Country = "NZ" }, // Taranaki
        new () { State = "WGN", Demonym = "Wellingtonian", Country = "NZ" }, // Wellington
        new () { State = "WKO", Demonym = "Waikatoan", Country = "NZ" }, // Waikato
        new () { State = "WTC", Demonym = "West Coaster", Country = "NZ" }, // West Coast
        
        // Panama

        new () { State = "PA", Demonym = "panamenho", Country = "PA" }, // Província de Panamá
        new () { State = "CH", Demonym = "chiricano", Country = "PA" }, // Província de Chiriquí
        new () { State = "BG", Demonym = "bocasdeltorense", Country = "PA" }, // Província de Bocas del Toro
        new () { State = "CN", Demonym = "coclesano", Country = "PA" }, // Província de Coclé
        new () { State = "HV", Demonym = "herrerano", Country = "PA" }, // Província de Herrera
        new () { State = "LS", Demonym = "losantosense", Country = "PA" }, // Província de Los Santos
        new () { State = "PN", Demonym = "panamenho", Country = "PA" }, // Província de Panamá Oeste
        new () { State = "NG", Demonym = "ngabe", Country = "PA" }, // Província de Ngäbe-Buglé
        new () { State = "EM", Demonym = "embara", Country = "PA" }, // Província de Emberá
        new () { State = "KR", Demonym = "kuna", Country = "PA" }, // Província de Guna Yala
        new () { State = "ZA", Demonym = "zons", Country = "PA" }, // Província de San Blas

        // Peru

        new() { State = "AM", Demonym = "Amazonense", Country = "PE" }, // Amazonas
        new() { State = "AN", Demonym = "Ancashino", Country = "PE" }, // Ancash
        new() { State = "AP", Demonym = "Apurimeño", Country = "PE" }, // Apurímac
        new() { State = "ARE", Demonym = "Arequipeño", Country = "PE" }, // Arequipa
        new() { State = "AY", Demonym = "Ayacuchano", Country = "PE" }, // Ayacucho
        new() { State = "CA", Demonym = "Cajamarquino", Country = "PE" }, // Cajamarca
        new() { State = "CU", Demonym = "Cusqueño", Country = "PE" }, // Cusco
        new() { State = "HU", Demonym = "Huanuqueño", Country = "PE" }, // Huánuco
        new() { State = "IC", Demonym = "Iqueño", Country = "PE" }, // Ica
        new() { State = "JU", Demonym = "Juninense", Country = "PE" }, // Junín
        new() { State = "LA", Demonym = "Lambayecano", Country = "PE" }, // Lambayeque
        new() { State = "LI", Demonym = "Limeño", Country = "PE" }, // Lima
        new() { State = "LO", Demonym = "Loreto", Country = "PE" }, // Loreto
        new() { State = "MO", Demonym = "Moqueguano", Country = "PE" }, // Moquegua
        new() { State = "NE", Demonym = "Negrense", Country = "PE" }, // Pasco
        new() { State = "PI", Demonym = "Piurano", Country = "PE" }, // Piura
        new() { State = "PU", Demonym = "Puno", Country = "PE" }, // Puno
        new() { State = "SAC", Demonym = "San Martín", Country = "PE" }, // San Martín
        new() { State = "TA", Demonym = "Tacneño", Country = "PE" }, // Tacna
        new() { State = "TUM", Demonym = "Tumbesino", Country = "PE" }, // Tumbes
        new() { State = "UC", Demonym = "Ucayalino", Country = "PE" }, // Ucayali

        // Paraguay

        new() { State = "AL", Demonym = "Alto-Paraguayo", Country = "PY" }, // Alto Paraguay
        new() { State = "AM", Demonym = "Amambayense", Country = "PY" }, // Amambay
        new() { State = "AR", Demonym = "Areguá", Country = "PY" }, // Areguá
        new() { State = "AS", Demonym = "Asunceno", Country = "PY" }, // Asunción
        new() { State = "BO", Demonym = "Boquerón", Country = "PY" }, // Boquerón
        new() { State = "CA", Demonym = "Caguazú", Country = "PY" }, // Caguazú
        new() { State = "CC", Demonym = "Caaguazú", Country = "PY" }, // Caaguazú
        new() { State = "CE", Demonym = "Central", Country = "PY" }, // Central
        new() { State = "CH", Demonym = "Chaco", Country = "PY" }, // Chaco
        new() { State = "CI", Demonym = "Ciudad del Este", Country = "PY" }, // Alto Paraná
        new() { State = "CO", Demonym = "Concepción", Country = "PY" }, // Concepción
        new() { State = "GU", Demonym = "Guairá", Country = "PY" }, // Guairá
        new() { State = "IT", Demonym = "Itapúa", Country = "PY" }, // Itapúa
        new() { State = "MI", Demonym = "Misiones", Country = "PY" }, // Misiones
        new() { State = "NE", Demonym = "Ñeembucú", Country = "PY" }, // Ñeembucú
        new() { State = "PA", Demonym = "Paraguarí", Country = "PY" }, // Paraguarí
        new() { State = "PI", Demonym = "Presidente Hayes", Country = "PY" }, // Presidente Hayes
        new() { State = "PY", Demonym = "Py", Country = "PY" }, // Paraguay
        new() { State = "SG", Demonym = "San Pedro", Country = "PY" }, // San Pedro

        // Polony

        new () { State = "MZ", Demonym = "varsoviano", Country = "PL" }, // Mazóvia (Mazowieckie)
        new () { State = "LD", Demonym = "lodziano", Country = "PL" }, // Łódź (Łódzkie)
        new () { State = "KP", Demonym = "kujausiano", Country = "PL" }, // Kuyávia-Pomerânia (Kujawsko-Pomorskie)
        new () { State = "PM", Demonym = "pomerano", Country = "PL" }, // Pomerânia (Pomorskie)
        new () { State = "WK", Demonym = "masuriano", Country = "PL" }, // Varmia-Masúria (Warmińsko-Mazurskie)
        new () { State = "LB", Demonym = "lubusziano", Country = "PL" }, // Lubusz (Lubuskie)
        new () { State = "SB", Demonym = "silesiano", Country = "PL" }, // Silésia (Śląskie)
        new () { State = "MA", Demonym = "małopolan", Country = "PL" }, // Pequena Polônia (Małopolskie)
        new () { State = "PK", Demonym = "podkarpackiano", Country = "PL" }, // Subcarpácia (Podkarpackie)
        new () { State = "LI", Demonym = "lublinense", Country = "PL" }, // Lublin (Lubelskie)
        new () { State = "OP", Demonym = "opoleano", Country = "PL" }, // Opole (Opolskie)
        new () { State = "KP", Demonym = "baixosilêsio", Country = "PL" }, // Baixo Silésia (Dolnośląskie)
     
        // Portugal

        new () { State = "AZ", Demonym = "Açoriano", Country = "PT" }, // Açores
        new () { State = "BE", Demonym = "Alentejano", Country = "PT" }, // Alentejo
        new () { State = "BA", Demonym = "Algarvio", Country = "PT" }, // Algarve
        new () { State = "CO", Demonym = "Alentejano", Country = "PT" }, // Alentejo
        new () { State = "LI", Demonym = "Lisboeta", Country = "PT" }, // Lisboa
        new () { State = "MA", Demonym = "Madeirense", Country = "PT" }, // Madeira
        new () { State = "NE", Demonym = "Norte", Country = "PT" }, // Norte
        new () { State = "SE", Demonym = "Lisboeta", Country = "PT" }, // Setúbal
      
        // Russia

        new () { State = "AL", Demonym = "alaudense", Country = "RU" }, // Alano
        new () { State = "BA", Demonym = "bascourtano", Country = "RU" }, // Bascortostão
        new () { State = "BU", Demonym = "buriate", Country = "RU" }, // Burátia
        new () { State = "CH", Demonym = "chechano", Country = "RU" }, // Chechênia
        new () { State = "DA", Demonym = "daguestano", Country = "RU" }, // Daguestão
        new () { State = "IR", Demonym = "irkutense", Country = "RU" }, // Irkutsk
        new () { State = "KR", Demonym = "karachevo-balcario", Country = "RU" }, // Karacháia-Cherkessia
        new () { State = "TA", Demonym = "tatar", Country = "RU" }, // Tatarstão
        new () { State = "SA", Demonym = "sámi", Country = "RU" }, // Sámi
        new () { State = "KO", Demonym = "komi", Country = "RU" }, // Komi
        new () { State = "KUR", Demonym = "kurgano", Country = "RU" }, // Kurgan
        new () { State = "MO", Demonym = "moscovita", Country = "RU" }, // Moscovo
        new () { State = "NV", Demonym = "novgorodense", Country = "RU" }, // Novgorod
        new () { State = "RS", Demonym = "rússia", Country = "RU" }, // Rússica
        new () { State = "TU", Demonym = "tuvan", Country = "RU" }, // Tuva
      
        // Suiss

        new () { State = "AG", Demonym = "argoviano", Country = "CH" }, // Argóvia
        new () { State = "AI", Demonym = "appenzellense", Country = "CH" }, // Appenzell Innerrhoden
        new () { State = "AR", Demonym = "appenzellense", Country = "CH" }, // Appenzell Außerrhoden
        new () { State = "BE", Demonym = "bernês", Country = "CH" }, // Berna
        new () { State = "BL", Demonym = "basileense", Country = "CH" }, // Basileia-Campo
        new () { State = "BS", Demonym = "basileense", Country = "CH" }, // Basileia-Cidade
        new () { State = "FR", Demonym = "friburguês", Country = "CH" }, // Friburgo
        new () { State = "GE", Demonym = "genevense", Country = "CH" }, // Genebra
        new () { State = "GL", Demonym = "glaronense", Country = "CH" }, // Glarus
        new () { State = "GR", Demonym = "grison", Country = "CH" }, // Grisons
        new () { State = "JU", Demonym = "jura", Country = "CH" }, // Jura
        new () { State = "LU", Demonym = "lucernense", Country = "CH" }, // Lucerna
        new () { State = "NE", Demonym = "neuchâtelois", Country = "CH" }, // Neuchâtel
        new () { State = "NW", Demonym = "nidaquense", Country = "CH" }, // Nidvaldo
        new () { State = "OW", Demonym = "oberlandês", Country = "CH" }, // Obvaldo
        new () { State = "SG", Demonym = "st. gallenense", Country = "CH" }, // St. Gallen
        new () { State = "SH", Demonym = "schaffausense", Country = "CH" }, // Schaffhausen
        new () { State = "SO", Demonym = "soleurense", Country = "CH" }, // Soleura
        new () { State = "SZ", Demonym = "schwyzense", Country = "CH" }, // Schwyz
        new () { State = "TG", Demonym = "thurgoviano", Country = "CH" }, // Turgóvia
        new () { State = "TI", Demonym = "ticinese", Country = "CH" }, // Ticino
        new () { State = "VD", Demonym = "vaudense", Country = "CH" }, // Vaud
        new () { State = "VS", Demonym = "valaisano", Country = "CH" }, // Valais
        new () { State = "ZG", Demonym = "zugueano", Country = "CH" }, // Zug
        new () { State = "ZH", Demonym = "zurique", Country = "CH" }, // Zurique

        // Suecia

        new () { State = "AB", Demonym = "norrlandês", Country = "SE" }, // Norrbotten
        new () { State = "C", Demonym = "estocolmense", Country = "SE" }, // Estocolmo
        new () { State = "D", Demonym = "uplandês", Country = "SE" }, // Uppsala
        new () { State = "E", Demonym = "södermanlandês", Country = "SE" }, // Södermanland
        new () { State = "F", Demonym = "örebroense", Country = "SE" }, // Örebro
        new () { State = "G", Demonym = "göteborgense", Country = "SE" }, // Västra Götaland
        new () { State = "H", Demonym = "hallandês", Country = "SE" }, // Halland
        new () { State = "I", Demonym = "skånsico", Country = "SE" }, // Skåne
        new () { State = "K", Demonym = "blekingês", Country = "SE" }, // Blekinge
        new () { State = "M", Demonym = "dalecarliano", Country = "SE" }, // Dalarna
        new () { State = "N", Demonym = "götalandês", Country = "SE" }, // Götaland
        new () { State = "O", Demonym = "ölandês", Country = "SE" }, // Öland
        new () { State = "S", Demonym = "värmlandês", Country = "SE" }, // Värmland
        new () { State = "T", Demonym = "västmanlandês", Country = "SE" }, // Västmanland
        new () { State = "U", Demonym = "hälsinglandês", Country = "SE" }, // Gävleborg
        new () { State = "W", Demonym = "värmlando", Country = "SE" }, // Värmland
        new () { State = "X", Demonym = "jönköpingense", Country = "SE" }, // Jönköping
        new () { State = "Y", Demonym = "österliano", Country = "SE" }, // Östergötland      
        
        // Taiwan

        new () { State = "TP", Demonym = "taipeiense", Country = "TW" }, // Taipei
        new () { State = "KA", Demonym = "kaohsiungense", Country = "TW" }, // Kaohsiung
        new () { State = "TA", Demonym = "taichungense", Country = "TW" }, // Taichung
        new () { State = "TY", Demonym = "tainanense", Country = "TW" }, // Tainan
        new () { State = "YL", Demonym = "yilanense", Country = "TW" }, // Yilan
        new () { State = "PH", Demonym = "penghuense", Country = "TW" }, // Penghu
        new () { State = "H", Demonym = "hualienense", Country = "TW" }, // Hualien
        new () { State = "T", Demonym = "tainanense", Country = "TW" }, // Taitung
     
        // Turquia
        
            new () { State = "34", Demonym = "istanbulita", Country = "TR" }, // Província de Istambul
            new () { State = "06", Demonym = "ankaraense", Country = "TR" }, // Província de Ancara
            new () { State = "35", Demonym = "izmelense", Country = "TR" }, // Província de Izmir
            new () { State = "01", Demonym = "adanalı", Country = "TR" }, // Província de Adana
            new () { State = "02", Demonym = "adiyamaneli", Country = "TR" }, // Província de Adiyaman
            new () { State = "03", Demonym = "afyonkarahisarlı", Country = "TR" }, // Província de Afyonkarahisar
            new () { State = "04", Demonym = "akaralı", Country = "TR" }, // Província de Aksaray
            new () { State = "05", Demonym = "amasyalı", Country = "TR" }, // Província de Amasya
            new () { State = "07", Demonym = "antalyalı", Country = "TR" }, // Província de Antalya
            new () { State = "08", Demonym = "artvinli", Country = "TR" }, // Província de Artvin
            new () { State = "09", Demonym = "aydinlı", Country = "TR" }, // Província de Aydin
            new () { State = "10", Demonym = "balıkesirli", Country = "TR" }, // Província de Balıkesir
            new () { State = "11", Demonym = "bileciklı", Country = "TR" }, // Província de Bilecik
            new () { State = "12", Demonym = "bingöllü", Country = "TR" }, // Província de Bingöl
            new () { State = "13", Demonym = "bitlisli", Country = "TR" }, // Província de Bitlis
            new () { State = "14", Demonym = "bolulu", Country = "TR" }, // Província de Bolu
            new () { State = "15", Demonym = "burdurlu", Country = "TR" }, // Província de Burdur
            new () { State = "16", Demonym = "bursalı", Country = "TR" }, // Província de Bursa
            new () { State = "17", Demonym = "çanakkale", Country = "TR" }, // Província de Çanakkale
            new () { State = "18", Demonym = "çankırılı", Country = "TR" }, // Província de Çankırı
            new () { State = "19", Demonym = "denizlili", Country = "TR" }, // Província de Denizli
            new () { State = "20", Demonym = "edirneli", Country = "TR" }, // Província de Edirne
            new () { State = "21", Demonym = "elazığlı", Country = "TR" }, // Província de Elazığ
            new () { State = "22", Demonym = "erzincanlı", Country = "TR" }, // Província de Erzincan
            new () { State = "23", Demonym = "erzurumlu", Country = "TR" }, // Província de Erzurum
            new () { State = "24", Demonym = "eskisehirli", Country = "TR" }, // Província de Eskişehir
            new () { State = "25", Demonym = "gaziantepli", Country = "TR" }, // Província de Gaziantep
            new () { State = "26", Demonym = "giresunlu", Country = "TR" }, // Província de Giresun
            new () { State = "27", Demonym = "gümüşhaneli", Country = "TR" }, // Província de Gümüşhane
            new () { State = "28", Demonym = "hakkarili", Country = "TR" }, // Província de Hakkari
            new () { State = "29", Demonym = "hataylı", Country = "TR" }, // Província de Hatay
            new () { State = "30", Demonym = "ısparta", Country = "TR" }, // Província de Isparta
            new () { State = "31", Demonym = "istanbullular", Country = "TR" }, // Província de İstanbul
            new () { State = "32", Demonym = "kahramanmaraşlı", Country = "TR" }, // Província de Kahramanmaraş
            new () { State = "33", Demonym = "karabüklü", Country = "TR" }, // Província de Karabük
            new () { State = "34", Demonym = "kastamonulu", Country = "TR" }, // Província de Kastamonu
            new () { State = "35", Demonym = "kayserili", Country = "TR" }, // Província de Kayseri
            new () { State = "36", Demonym = "kırklarelili", Country = "TR" }, // Província de Kırklareli
            new () { State = "37", Demonym = "kırıkkaleli", Country = "TR" }, // Província de Kırıkkale
            new () { State = "38", Demonym = "kastamonulu", Country = "TR" }, // Província de Kastamonu
            new () { State = "39", Demonym = "malatyalı", Country = "TR" }, // Província de Malatya
            new () { State = "40", Demonym = "manisalıl", Country = "TR" }, // Província de Manisa
            new () { State = "41", Demonym = "mersinli", Country = "TR" }, // Província de Mersin
            new () { State = "42", Demonym = "muğlalı", Country = "TR" }, // Província de Muğla
            new () { State = "43", Demonym = "nevşehirli", Country = "TR" }, // Província de Nevşehir
            new () { State = "44", Demonym = "niğdelili", Country = "TR" }, // Província de Niğde
            new () { State = "45", Demonym = "ordu", Country = "TR" }, // Província de Ordu
            new () { State = "46", Demonym = "rize", Country = "TR" }, // Província de Rize
            new () { State = "47", Demonym = "sakaryalı", Country = "TR" }, // Província de Sakarya
            new () { State = "48", Demonym = "samsunlu", Country = "TR" }, // Província de Samsun
            new () { State = "49", Demonym = "sinoplu", Country = "TR" }, // Província de Sinop
            new () { State = "50", Demonym = "sivaslı", Country = "TR" }, // Província de Sivas
            new () { State = "51", Demonym = "tekirdağlı", Country = "TR" }, // Província de Tekirdağ
            new () { State = "52", Demonym = "tokatlı", Country = "TR" }, // Província de Tokat
            new () { State = "53", Demonym = "trabzonlu", Country = "TR" }, // Província de Trabzon
            new () { State = "54", Demonym = "tuncelili", Country = "TR" }, // Província de Tunceli
            new () { State = "55", Demonym = "uygurlar", Country = "TR" }, // Província de Uşak
            new () { State = "56", Demonym = "vanlı", Country = "TR" }, // Província de Van
            new () { State = "57", Demonym = "yalovalı", Country = "TR" }, // Província de Yalova
            new () { State = "58", Demonym = "zonguldaklı", Country = "TR" }, // Província de Zonguldak
    
        // Ucrany

        new () { State = "KV", Demonym = "kievense", Country = "UA" }, // Kiev (Kyiv)
        new () { State = "LA", Demonym = "lvovense", Country = "UA" }, // Lviv (Lwów)
        new () { State = "OD", Demonym = "odessense", Country = "UA" }, // Odessa (Odesa)
        new () { State = "DN", Demonym = "donetsense", Country = "UA" }, // Donetsk (Donets'k)
        new () { State = "KH", Demonym = "kharkivense", Country = "UA" }, // Kharkiv
        new () { State = "ZA", Demonym = "zaporizense", Country = "UA" }, // Zaporizhia
        new () { State = "KR", Demonym = "krivorozhano", Country = "UA" }, // Krivoi Rog (Kryvyi Rih)
        new () { State = "RI", Demonym = "rivnense", Country = "UA" }, // Rivne
        new () { State = "CH", Demonym = "chernigovense", Country = "UA" }, // Chernigov (Chernihiv)
        new () { State = "VO", Demonym = "volyniano", Country = "UA" }, // Volyn
        new () { State = "IV", Demonym = "ivano-frankivskense", Country = "UA" }, // Ivano-Frankivsk
        new () { State = "MY", Demonym = "mykolaivense", Country = "UA" }, // Mykolaiv
        new () { State = "KM", Demonym = "khmelnytskyense", Country = "UA" }, // Khmelnytskyi
        new () { State = "KI", Demonym = "kirovograndense", Country = "UA" }, // Kirovohrad
        new () { State = "PO", Demonym = "poltavense", Country = "UA" }, // Poltava
      
        // Uganda
        
        new () { State = "C", Demonym = "central", Country = "UG" }, // Região Central
        new () { State = "E", Demonym = "eastern", Country = "UG" }, // Região Oriental
        new () { State = "N", Demonym = "northern", Country = "UG" }, // Região Norte
        new () { State = "W", Demonym = "western", Country = "UG" }, // Região Ocidental
        new () { State = "NW", Demonym = "northwestern", Country = "UG" }, // Região Noroeste
      
        // United Kingdon (England)

        new () { State = "ENG", Demonym = "English", Country = "GB" }, // England
        new () { State = "SCO", Demonym = "Scottish", Country = "GB" }, // Scotland
        new () { State = "WAL", Demonym = "Welsh", Country = "GB" }, // Wales
        new () { State = "NIR", Demonym = "Northern Irish", Country = "GB" }, // Northern Ireland
        new () { State = "GB", Demonym = "British", Country = "GB" }, // United Kingdom
 
        // Usa

        new() { State = "AL", Demonym = "Alabamian", Country = "US" },
        new() { State = "AK", Demonym = "Alaskan", Country = "US" },
        new() { State = "AZ", Demonym = "Arizonan", Country = "US" },
        new() { State = "AR", Demonym = "Arkansan", Country = "US" },
        new() { State = "CA", Demonym = "Californian", Country = "US" },
        new() { State = "CO", Demonym = "Coloradan", Country = "US" },
        new() { State = "CT", Demonym = "Connecticuter", Country = "US" },
        new() { State = "DE", Demonym = "Delawarean", Country = "US" },
        new() { State = "FL", Demonym = "Floridian", Country = "US" },
        new() { State = "GA", Demonym = "Georgian", Country = "US" },
        new() { State = "HI", Demonym = "Hawaiian", Country = "US" },
        new() { State = "ID", Demonym = "Idahoan", Country = "US" },
        new() { State = "IL", Demonym = "Illinoisan", Country = "US" },
        new() { State = "IN", Demonym = "Hoosier", Country = "US" },
        new() { State = "IA", Demonym = "Iowan", Country = "US" },
        new() { State = "KS", Demonym = "Kansan", Country = "US" },
        new() { State = "KY", Demonym = "Kentuckian", Country = "US" },
        new() { State = "LA", Demonym = "Louisianan", Country = "US" },
        new() { State = "ME", Demonym = "Mainer", Country = "US" },
        new() { State = "MD", Demonym = "Marylander", Country = "US" },
        new() { State = "MA", Demonym = "Massachusettsan", Country = "US" },
        new() { State = "MI", Demonym = "Michigander", Country = "US" },
        new() { State = "MN", Demonym = "Minnesotan", Country = "US" },
        new() { State = "MS", Demonym = "Mississippian", Country = "US" },
        new() { State = "MO", Demonym = "Missourian", Country = "US" },
        new() { State = "MT", Demonym = "Montanan", Country = "US" },
        new() { State = "NE", Demonym = "Nebraskan", Country = "US" },
        new() { State = "NV", Demonym = "Nevadan", Country = "US" },
        new() { State = "NH", Demonym = "New Hampshirite", Country = "US" },
        new() { State = "NJ", Demonym = "New Jerseyan", Country = "US" },
        new() { State = "NM", Demonym = "New Mexican", Country = "US" },
        new() { State = "NY", Demonym = "New Yorker", Country = "US" },
        new() { State = "NC", Demonym = "North Carolinian", Country = "US" },
        new() { State = "ND", Demonym = "North Dakotan", Country = "US" },
        new() { State = "OH", Demonym = "Ohioan", Country = "US" },
        new() { State = "OK", Demonym = "Oklahoman", Country = "US" },
        new() { State = "OR", Demonym = "Oregonian", Country = "US" },
        new() { State = "PA", Demonym = "Pennsylvanian", Country = "US" },
        new() { State = "RI", Demonym = "Rhode Islander", Country = "US" },
        new() { State = "SC", Demonym = "South Carolinian", Country = "US" },
        new() { State = "SD", Demonym = "South Dakotan", Country = "US" },
        new() { State = "TN", Demonym = "Tennessean", Country = "US" },
        new() { State = "TX", Demonym = "Texan", Country = "US" },
        new() { State = "UT", Demonym = "Utahn", Country = "US" },
        new() { State = "VT", Demonym = "Vermonter", Country = "US" },
        new() { State = "VA", Demonym = "Virginian", Country = "US" },
        new() { State = "WA", Demonym = "Washingtonian", Country = "US" },
        new() { State = "WV", Demonym = "West Virginian", Country = "US" },
        new() { State = "WI", Demonym = "Wisconsinite", Country = "US" },
        new() { State = "WY", Demonym = "Wyomingite", Country = "US" },

        // Uruguai 

        new() { State = "AR", Demonym = "Artiguense", Country = "UY" }, // Artigas
        new() { State = "CA", Demonym = "Canelones", Country = "UY" }, // Canelones
        new() { State = "CL", Demonym = "Cerro Largo", Country = "UY" }, // Cerro Largo
        new() { State = "CO", Demonym = "Colonia", Country = "UY" }, // Colonia
        new() { State = "DU", Demonym = "Durazno", Country = "UY" }, // Durazno
        new() { State = "FB", Demonym = "Florida", Country = "UY" }, // Florida
        new() { State = "FS", Demonym = "Flores", Country = "UY" }, // Flores
        new() { State = "LA", Demonym = "Lavalleja", Country = "UY" }, // Lavalleja
        new() { State = "MA", Demonym = "Maldonado", Country = "UY" }, // Maldonado
        new() { State = "MO", Demonym = "Montevideo", Country = "UY" }, // Montevideo
        new() { State = "PA", Demonym = "Paysandú", Country = "UY" }, // Paysandú
        new() { State = "RN", Demonym = "Río Negro", Country = "UY" }, // Río Negro
        new() { State = "RO", Demonym = "Rocha", Country = "UY" }, // Rocha
        new() { State = "SA", Demonym = "Salto", Country = "UY" }, // Salto
        new() { State = "SD", Demonym = "San José", Country = "UY" }, // San José
        new() { State = "SO", Demonym = "Soriano", Country = "UY" }, // Soriano
        new() { State = "TA", Demonym = "Tacuarembó", Country = "UY" }, // Tacuarembó
        new() { State = "TT", Demonym = "Treinta y Tres", Country = "UY" }, // Treinta y Tres

        // Venezuela

        new() { State = "A", Demonym = "Zuliano", Country = "VE" }, // Zulia
        new() { State = "B", Demonym = "Mérideño", Country = "VE" }, // Mérida
        new() { State = "C", Demonym = "Carabobeño", Country = "VE" }, // Carabobo
        new() { State = "D", Demonym = "Llanero", Country = "VE" }, // Apure
        new() { State = "E", Demonym = "Guarico", Country = "VE" }, // Guárico
        new() { State = "F", Demonym = "Lara", Country = "VE" }, // Lara
        new() { State = "G", Demonym = "Falcón", Country = "VE" }, // Falcón
        new() { State = "H", Demonym = "Portuguesa", Country = "VE" }, // Portuguesa
        new() { State = "I", Demonym = "Táchira", Country = "VE" }, // Táchira
        new() { State = "J", Demonym = "Mérida", Country = "VE" }, // Mérida
        new() { State = "K", Demonym = "Bolívar", Country = "VE" }, // Bolívar
        new() { State = "L", Demonym = "Amazonense", Country = "VE" }, // Amazonas
        new() { State = "M", Demonym = "Delta Amacuro", Country = "VE" }, // Delta Amacuro
        new() { State = "N", Demonym = "Sucre", Country = "VE" }, // Sucre
        new() { State = "O", Demonym = "Miranda", Country = "VE" }, // Miranda
        new() { State = "P", Demonym = "Anzoátegui", Country = "VE" }, // Anzoátegui
        new() { State = "R", Demonym = "Monagas", Country = "VE" }, // Monagas
        new() { State = "S", Demonym = "Distrito Capital", Country = "VE" }, // Capital District
        new() { State = "T", Demonym = "Nueva Esparta", Country = "VE" }, // Nueva Esparta
        new() { State = "U", Demonym = "Vargas", Country = "VE" }, // Vargas
        new() { State = "Y", Demonym = "Aragua", Country = "VE" }, // Aragua
        new() { State = "Z", Demonym = "Trujillo", Country = "VE" }, // Trujillo

        // Vaticano
        new () { State = "VA", Demonym = "vaticano", Country = "VA" }, // Cidade do Vaticano

        // Vietna
        
        new () { State = "HN", Demonym = "hanoiense", Country = "VN" }, // Cidade de Hanói
        new () { State = "SG", Demonym = "saigonense", Country = "VN" }, // Cidade de Ho Chi Minh
        new () { State = "HP", Demonym = "haiphonguense", Country = "VN" }, // Cidade de Haiphong
        new () { State = "DN", Demonym = "dananguense", Country = "VN" }, // Cidade de Da Nang
        new () { State = "TH", Demonym = "thaibinhense", Country = "VN" }, // Província de Thai Binh
        new () { State = "QT", Demonym = "quangtri", Country = "VN" }, // Província de Quang Tri
        new () { State = "BN", Demonym = "bentreense", Country = "VN" }, // Província de Ben Tre
        new () { State = "HG", Demonym = "haiduonguense", Country = "VN" }, // Província de Hai Duong
        new () { State = "BV", Demonym = "baovang", Country = "VN" }, // Província de Ba Ria - Vung Tau
        new () { State = "LD", Demonym = "lamdonguense", Country = "VN" }, // Província de Lam Dong
        new () { State = "TN", Demonym = "tayninhense", Country = "VN" }, // Província de Tay Ninh
        new () { State = "LD", Demonym = "lamdonguense", Country = "VN" }, // Província de Lam Dong
        new () { State = "BG", Demonym = "bacgiang", Country = "VN" }, // Província de Bac Giang


        // Falta 
        //
        // Costa Rica
        // Dominican Republic
        // Ecuador
        // El Salvador
        // Guatemala
        // Honduras
        // Nicaragua
        // Panama
        // Jamaica
        // Trinidad and Tobago
        // Haiti
        // Europa,
        // Asia
        // Groelandia
        // Oceania
    };
}


