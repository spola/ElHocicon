using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElHocicon.Test
{
    [TestClass]
    public class Procesador_Coincide
    {
        private static string[] lineas = new string[]{
            "2012-12-08 09:58:19 W3SVC1 AMAZONA-NO3USPU 10.38.93.195 GET /Productos/Ficha.aspx ProductoID=5417&idCategoria=55&orden=OrdenPresentacion&Index=10&ts=0 80 - 66.249.73.15 HTTP/1.1 Mozilla/5.0+(compatible;+Googlebot/2.1;++http://www.google.com/bot.html) - - www.portalinmobiliario.com 200 0 0 49150 436 280",
            "2012-12-08 09:58:19 W3SVC1 AMAZONA-NO3USPU 10.38.93.195 GET /propiedades/fichas.asp PropID=1383475&Pag=4&Ant=80&Sig=82&TId=1&MoID=2&OId=1&IdCom=325&V1=6000&V2=8000&TotProGeo=19 80 - 201.239.23.97 HTTP/1.1 Mozilla/5.0+(iPad;+CPU+OS+5_1_1+like+Mac+OS+X)+AppleWebKit/534.46+(KHTML,+like+Gecko)+Version/5.1+Mobile/9B206+Safari/7534.48.3 IdUsuarioASP=;+Buscador=Venta=1&SuperficieMayor=&SuperficieMenor=&ValorDesde=6000&TipoMoneda=2&Banos=0&Dormitorios=0&ArriendoTemporada=0&Arriendo=0&ValorHasta=8000&Comuna=325&Tipo=1&RegionNro=XIII;+PI=jgzcuumqj1gvsyqdux3nmtac;+ASPSESSIONIDCSSSAQQD=MMPECECBPCPKODFDKKPBFIPD;+AWSELB=B7F7610B0847E23F5CF7F287B22A30677889CF06050EB964D51B8373F8582011AFF19FC4BEE2AD96AB50AECD56EF664C59A9BCF671B232ECF50C497D0BFE61A76D4091C75B;+__utma=200023599.1485872962.1354957407.1354957407.1354957407.1;+__utmb=200023599.353.10.1354957407;+__utmc=200023599;+__utmz=200023599.1354957407.1.1.utmcsr=(direct)|utmccn=(direct)|utmcmd=(none) http://www.portalinmobiliario.com/propiedades/fichas.asp?PropID=1394462&Pag=4&Ant=79&Sig=81&TId=1&MoID=2&OId=1&IdCom=325&V1=6000&V2=8000&TotProGeo=19 www.portalinmobiliario.com 200 0 0 17161 1326 265",
            "2012-12-08 09:58:19 W3SVC1 AMAZONA-NO3USPU 10.38.93.195 GET /images/Publicacion/registreseBTN.png - 80 - 190.100.67.74 HTTP/1.1 Mozilla/5.0+(Windows+NT+6.1;+rv:17.0)+Gecko/20100101+Firefox/17.0 __utma=200023599.1632632900.1353708560.1354558371.1354741224.5;+__utmz=200023599.1354741224.5.3.utmcsr=google|utmccn=(organic)|utmcmd=organic|utmctr=portal%20inmobiliario;+Buscador=Venta=1&Dormitorios=0&SuperficieMayor=&SuperficieMenor=&ValorDesde=3500&TipoMoneda=2&Banos=0&ArriendoTemporada=0&Arriendo=0&ValorHasta=4500&Comuna=71&Tipo=1&RegionNro=V;+AWSELB=B7F7610B0847E23F5CF7F287B22A30677889CF06050EB964D51B8373F8582011AFF19FC4BEE2AD96AB50AECD56EF664C59A9BCF671B232ECF50C497D0BFE61A76D4091C75B;+PI=c1tjz045wkbuzd55mjkzvize http://www.portalinmobiliario.com/MiPortal/default.aspx?ReturnUrl=%2fPropiedades%2fAdministracion%2fListadoPropiedades.aspx www.portalinmobiliario.com 200 0 0 4853 1068 0",
            "2012-12-08 09:58:20 W3SVC1 AMAZONA-NO3USPU 10.38.93.195 GET /buscar_resp.asp Pos=280&PropID=1390939&Pag=12&Ant=280&Sig=282&TId=1&MoID=2&OId=1&IdCom=291,327,326,325&S1=320&S2=450&V1=23000&V2=26499&TotProGeo=37 80 - 83.54.91.166 HTTP/1.1 Mozilla/5.0+(iPad;+CPU+OS+5_1_1+like+Mac+OS+X)+AppleWebKit/534.46+(KHTML,+like+Gecko)+Version/5.1+Mobile/9B206+Safari/7534.48.3 IdUsuarioASP=;+Buscador=Venta=1&Dormitorios=0&Tipo=1&RegionNro=XIII&ArriendoTemporada=0&Arriendo=0&ValorHasta=26499&Comuna=291%2C+327%2C+326%2C+325&TipoMoneda=2&Banos=0&SuperficieMayor=450&SuperficieMenor=320&ValorDesde=23000;+PI=lxz3de55rxptmeng11ofo22q;+ASPSESSIONIDCSSSAQQD=JFMECECBMDKLMFAJJINMFFEG;+AWSELB=B7F7610B0847E23F5CF7F287B22A30677889CF06050EB964D51B8373F8582011AFF19FC4BEE2AD96AB50AECD56EF664C59A9BCF671B232ECF50C497D0BFE61A76D4091C75B;+__utma=200023599.1112306457.1353703192.1354954910.1354960253.6;+__utmb=200023599.99.10.1354960253;+__utmc=200023599;+__utmz=200023599.1353703192.1.1.utmcsr=(direct)|utmccn=(direct)|utmcmd=(none) http://www.portalinmobiliario.com/propiedades/fichas.asp?PropID=1390939&Pag=12&Ant=280&Sig=282&TId=1&MoID=2&OId=1&IdCom=291,327,326,325&S1=320&S2=450&V1=23000&V2=26499&TotProGeo=37 www.portalinmobiliario.com 302 0 0 696 1416 93",
            "2012-12-08 09:00:04 W3SVC1 AMAZONA-NO3USPU 10.38.93.195 POST /Services/AutenticarService.svc/ajaxEndpoint/GetUsuarioActual - 80 - 2.138.28.44 HTTP/1.1 Mozilla/5.0+(Windows+NT+6.1;+WOW64)+AppleWebKit/537.11+(KHTML,+like+Gecko)+Chrome/23.0.1271.95+Safari/537.11 ASPSESSIONIDCSSSAQQD=HNOECECBEGNMHEAPDMHDNOIG;+AWSELB=B7F7610B0847E23F5CF7F287B22A30677889CF06050EB964D51B8373F8582011AFF19FC4BEE2AD96AB50AECD56EF664C59A9BCF671B232ECF50C497D0BFE61A76D4091C75B;+PI=x5leks2tncj3tyzctxxnyc55;+Buscador=Venta=0&Dormitorios=4&SuperficieMayor=&SuperficieMenor=190&ValorDesde=1200000&TipoMoneda=1&Banos=2&ArriendoTemporada=1&Arriendo=1&ValorHasta=3000000&Comuna=328%2C+327%2C+323%2C+325&Tipo=1&RegionNro=XIII&IPCliente=83%2E40%2E53%2E40;+__utma=200023599.1080697877.1341910272.1354736215.1354956770.41;+__utmb=200023599.27.10.1354956770;+__utmc=200023599;+__utmz=200023599.1354956770.41.38.utmcsr=google|utmccn=(organic)|utmcmd=organic|utmctr=arrendar%20casa%20en%20chile;+IdUsuarioASP= http://www.portalinmobiliario.com/propiedades/fichas.asp?PropID=1411779&Pag=1&Ant=6&Sig=8&TId=1&MoID=1&OId=2,4&IdCom=328,327,323,325&S1=190&V1=1199998,8652&V2=3000000,6006&P1=4&P2=2&TotProGeo=79 www.portalinmobiliario.com 200 0 0 236 1487 15",
"2012-12-08 09:00:04 W3SVC1 AMAZONA-NO3USPU 10.38.93.195 GET /__utm.gif utmwv=5.3.8&utms=28&utmn=2106641178&utmhn=www.portalinmobiliario.com&utmcs=ISO-8859-1&utmsr=1600x900&utmvp=1583x799&utmsc=32-bit&utmul=es&utmje=1&utmfl=11.5%20r31&utmdt=Portalinmobiliario.com%3A%20Casa%20en%20arriendo%20en%20Las%20Condes&utmhid=1817830354&utmr=0&utmp=%2Fpropiedades%2Ffichas.asp%3FPropID%3D1411779%26Pag%3D1%26Ant%3D6%26Sig%3D8%26TId%3D1%26MoID%3D1%26OId%3D2%2C4%26IdCom%3D328%2C327%2C323%2C325%26S1%3D190%26V1%3D1199998%2C8652%26V2%3D3000000%2C6006%26P1%3D4%26P2%3D2%26TotProGeo%3D79 80 - 2.138.28.44 HTTP/1.1 Mozilla/5.0+(Windows+NT+6.1;+WOW64)+AppleWebKit/537.11+(KHTML,+like+Gecko)+Chrome/23.0.1271.95+Safari/537.11 ASPSESSIONIDCSSSAQQD=HNOECECBEGNMHEAPDMHDNOIG;+AWSELB=B7F7610B0847E23F5CF7F287B22A30677889CF06050EB964D51B8373F8582011AFF19FC4BEE2AD96AB50AECD56EF664C59A9BCF671B232ECF50C497D0BFE61A76D4091C75B;+PI=x5leks2tncj3tyzctxxnyc55;+Buscador=Venta=0&Dormitorios=4&SuperficieMayor=&SuperficieMenor=190&ValorDesde=1200000&TipoMoneda=1&Banos=2&ArriendoTemporada=1&Arriendo=1&ValorHasta=3000000&Comuna=328%2C+327%2C+323%2C+325&Tipo=1&RegionNro=XIII&IPCliente=83%2E40%2E53%2E40;+IdUsuarioASP=;+__utma=200023599.1080697877.1341910272.1354736215.1354956770.41;+__utmb=200023599.30.10.1354956770;+__utmc=200023599;+__utmz=200023599.1354956770.41.38.utmcsr=google|utmccn=(organic)|utmcmd=organic|utmctr=arrendar%20casa%20en%20chile http://www.portalinmobiliario.com/propiedades/fichas.asp?PropID=1411779&Pag=1&Ant=6&Sig=8&TId=1&MoID=1&OId=2,4&IdCom=328,327,323,325&S1=190&V1=1199998,8652&V2=3000000,6006&P1=4&P2=2&TotProGeo=79 www.portalinmobiliario.com 200 0 0 311 1843 0",
"2012-12-08 09:00:28 W3SVC1 AMAZONA-NO3USPU 10.38.93.195 POST /Services/AutenticarService.svc/ajaxEndpoint/RefreshSessionDotNet - 80 - 2.138.28.44 HTTP/1.1 Mozilla/5.0+(Windows+NT+6.1;+WOW64)+AppleWebKit/537.11+(KHTML,+like+Gecko)+Chrome/23.0.1271.95+Safari/537.11 ASPSESSIONIDCSSSAQQD=HNOECECBEGNMHEAPDMHDNOIG;+AWSELB=B7F7610B0847E23F5CF7F287B22A30677889CF06050EB964D51B8373F8582011AFF19FC4BEE2AD96AB50AECD56EF664C59A9BCF671B232ECF50C497D0BFE61A76D4091C75B;+PI=x5leks2tncj3tyzctxxnyc55;+Buscador=Venta=0&Dormitorios=4&SuperficieMayor=&SuperficieMenor=190&ValorDesde=1200000&TipoMoneda=1&Banos=2&ArriendoTemporada=1&Arriendo=1&ValorHasta=3000000&Comuna=328%2C+327%2C+323%2C+325&Tipo=1&RegionNro=XIII&IPCliente=83%2E40%2E53%2E40;+IdUsuarioASP=;+__utma=200023599.1080697877.1341910272.1354736215.1354956770.41;+__utmb=200023599.30.10.1354956770;+__utmc=200023599;+__utmz=200023599.1354956770.41.38.utmcsr=google|utmccn=(organic)|utmcmd=organic|utmctr=arrendar%20casa%20en%20chile http://www.portalinmobiliario.com/buscar_resp.asp www.portalinmobiliario.com 200 0 0 236 1346 15"
        };

        private Procesador main;

        [TestInitialize]
        public void SetUp()
        {
            main = new Procesador("./test.txt");
        }

        [TestCleanup]
        public void Cleanup()
        {
            main.Dispose();
            main = null;
        }

        [TestMethod]
        public void Coincide()
        {
            Assert.IsFalse(main.Coincide(lineas[0]));
            Assert.IsTrue(main.Coincide(lineas[1]));
            Assert.IsFalse(main.Coincide(lineas[2]));
            Assert.IsTrue(main.Coincide(lineas[3]));
            Assert.IsFalse(main.Coincide(lineas[4]));
            Assert.IsFalse(main.Coincide(lineas[5]));
            Assert.IsFalse(main.Coincide(lineas[6]));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ParametroNulo()
        {
            main.Coincide(null);
        }

        [TestMethod]
        public void ParametroVacio()
        {
            Assert.IsFalse(main.Coincide(""));
        }

    }
}
