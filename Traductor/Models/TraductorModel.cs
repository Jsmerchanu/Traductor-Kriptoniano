
namespace Traductor.Models
{
    public class TraductorModel
    {
        private readonly Dictionary<char, string> svgDictionary = new Dictionary<char, string>
        {

                    { '0', "/Caracteres/0.svg" },
                    { '1', "/Caracteres/1.svg" },
                    { '2', "/Caracteres/2.svg" },
                    { '3', "/Caracteres/3.svg" },
                    { '4', "/Caracteres/4.svg" },
                    { '5', "/Caracteres/5.svg" },
                    { '6', "/Caracteres/6.svg" },
                    { '7', "/Caracteres/7.svg" },
                    { '8', "/Caracteres/8.svg" },
                    { '9', "/Caracteres/9.svg" },
                    { 'a', "/Caracteres/A.svg" },
                    { 'b', "/Caracteres/B.svg" },
                    { 'c', "/Caracteres/C.svg" },
                    { 'd', "/Caracteres/D.svg" },
                    { 'e', "/Caracteres/E.svg" },
                    { 'f', "/Caracteres/F.svg" },
                    { 'g', "/Caracteres/G.svg" },
                    { 'h', "/Caracteres/H.svg" },
                    { 'i', "/Caracteres/I.svg" },
                    { 'j', "/Caracteres/J.svg" },
                    { 'k', "/Caracteres/K.svg" },
                    { 'l', "/Caracteres/L.svg" },
                    { 'm', "/Caracteres/M.svg" },
                    { 'n', "/Caracteres/N.svg" },
                    { 'o', "/Caracteres/O.svg" },
                    { 'p', "/Caracteres/P.svg" },
                    { 'q', "/Caracteres/Q.svg" },
                    { 'r', "/Caracteres/R.svg" },
                    { 's', "/Caracteres/S.svg" },
                    { 't', "/Caracteres/T.svg" },
                    { 'u', "/Caracteres/U.svg" },
                    { 'v', "/Caracteres/V.svg" },
                    { 'w', "/Caracteres/W.svg" },
                    { 'x', "/Caracteres/X.svg" },
                    { 'y', "/Caracteres/Y.svg" },
                    { 'z', "/Caracteres/Z.svg" }
        };
            
            public string ObtenerRutaSvg(char letra)
            {
                if (svgDictionary.ContainsKey(letra))
                {
                    return svgDictionary[letra];
                }
                else
                {
                    return "/Caracteres/3.svg";
                }
            }
        }
    }

